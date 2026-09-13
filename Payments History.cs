using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Payments_History : Form
    {
        public Payments_History()
        {
            InitializeComponent();

            this.Load -= Payments_History_Load;
            this.Load -= Payments_History_Load_1;
            this.Load += Payments_History_Load;

            comboBoxClientName.SelectedIndexChanged -= comboBoxClientName_SelectedIndexChanged;
            comboBoxClientName.SelectedIndexChanged -= comboBoxClientName_SelectedIndexChanged_1;
            comboBoxClientName.SelectedIndexChanged += comboBoxClientName_SelectedIndexChanged;

            comboBoxRentedCarPlate.SelectedIndexChanged -= comboBoxRentedCarPlate_SelectedIndexChanged;
            comboBoxRentedCarPlate.SelectedIndexChanged -= comboBoxRentedCarPlate_SelectedIndexChanged_1;
            comboBoxRentedCarPlate.SelectedIndexChanged += comboBoxRentedCarPlate_SelectedIndexChanged;

            buttonCalRemaing.Click -= buttonCalRemaing_Click;
            buttonCalRemaing.Click += buttonCalRemaing_Click;

            buttonSavePayment.Click -= buttonSavePayment_Click;
            buttonSavePayment.Click -= buttonSavePayment_Click_1;
            buttonSavePayment.Click += buttonSavePayment_Click;

            buttonClear.Click -= buttonClear_Click;
            buttonClear.Click -= buttonClear_Click_1;
            buttonClear.Click += buttonClear_Click;

            buttonBack.Click -= buttonBack_Click;
            buttonBack.Click += buttonBack_Click;
        }

        private void Payments_History_Load(object sender, EventArgs e)
        {
            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();

            LoadClients();

            textBoxNationalID.ReadOnly = true;
            RentDate.ReadOnly = true;
            ReturnDate.ReadOnly = true;
            TotalPrice.ReadOnly = true;
            textBoxCurrentBlanace.ReadOnly = true;
            textBoxRemaingAmount.ReadOnly = true;
            textBoxPaymentStatus.ReadOnly = true;

            comboBoxClientName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRentedCarPlate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxPaymentMethod.Items.Clear();
            comboBoxPaymentMethod.Items.Add("Cash");
            comboBoxPaymentMethod.Items.Add("Visa");
            comboBoxPaymentMethod.Items.Add("Bank Transfer");
            comboBoxPaymentMethod.Items.Add("CliQ");

            comboBoxPaymentType.Items.Clear();
            comboBoxPaymentType.Items.Add("Full Payment");
            comboBoxPaymentType.Items.Add("Installments");
        }

        private void LoadClients()
        {
            comboBoxClientName.Items.Clear();

            foreach (Client client in ClientData.Clients)
            {
                comboBoxClientName.Items.Add(client);
            }

            comboBoxClientName.DisplayMember = "Name";
        }

        private void comboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client selectedClient = comboBoxClientName.SelectedItem as Client;

            if (selectedClient == null)
            {
                return;
            }

            textBoxNationalID.Text = selectedClient.NationalID;
            LoadClientRentedCars(selectedClient.NationalID);
        }

        private void LoadClientRentedCars(string nationalID)
        {
            comboBoxRentedCarPlate.Items.Clear();

            var clientRentals = RentalData.Rentals
                .Where(rental =>
                    rental.ClientNationalID == nationalID &&
                    rental.IsFinished == false)
                .ToList();

            foreach (Rental rental in clientRentals)
            {
                comboBoxRentedCarPlate.Items.Add(rental.PlateNumber);
            }

            ClearRentalInfoOnly();

            if (clientRentals.Count == 0)
            {
                MessageBox.Show("This client does not have any active rented cars.");
            }
        }

        private void comboBoxRentedCarPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rental selectedRental = GetSelectedRental();

            if (selectedRental == null)
            {
                return;
            }

            RentDate.Text = selectedRental.RentDate.ToShortDateString();
            ReturnDate.Text = selectedRental.ReturnDate.ToShortDateString();

            TotalPrice.Text = selectedRental.TotalPrice.ToString();
            textBoxCurrentBlanace.Text = GetCurrentBalance(selectedRental).ToString();

            textBoxPaidAmount.Clear();
            textBoxRemaingAmount.Clear();
            textBoxPaymentStatus.Clear();

            comboBoxPaymentMethod.SelectedIndex = -1;
            comboBoxPaymentType.SelectedIndex = -1;
        }

        private Rental GetSelectedRental()
        {
            string nationalID = textBoxNationalID.Text.Trim();

            if (comboBoxRentedCarPlate.SelectedIndex == -1)
            {
                return null;
            }

            string plateNumber = comboBoxRentedCarPlate.Text.Trim();

            return RentalData.Rentals.FirstOrDefault(rental =>
                rental.ClientNationalID == nationalID &&
                rental.PlateNumber == plateNumber &&
                rental.IsFinished == false);
        }

        private decimal GetOldPaidAmount(Rental rental)
        {
            return PaymentData.Payments
                .Where(payment =>
                    payment.ClientNationalID == rental.ClientNationalID &&
                    payment.PlateNumber == rental.PlateNumber &&
                    payment.RentDate.Date == rental.RentDate.Date)
                .Sum(payment => payment.PaidAmount);
        }

        private decimal GetCurrentBalance(Rental rental)
        {
            decimal oldPaidAmount = GetOldPaidAmount(rental);
            decimal balance = rental.TotalPrice - oldPaidAmount;

            if (balance < 0)
            {
                balance = 0;
            }

            return balance;
        }

        private void buttonCalRemaing_Click(object sender, EventArgs e)
        {
            Rental selectedRental = GetSelectedRental();

            if (selectedRental == null)
            {
                MessageBox.Show("Please select a rented car first.");
                return;
            }

            if (textBoxPaidAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please enter paid amount.");
                textBoxPaidAmount.Focus();
                return;
            }

            decimal paidAmount;

            if (!decimal.TryParse(textBoxPaidAmount.Text.Trim(), out paidAmount))
            {
                MessageBox.Show("Paid Amount must be a valid number.");
                return;
            }

            if (paidAmount <= 0)
            {
                MessageBox.Show("Paid Amount must be greater than zero.");
                return;
            }

            decimal currentBalance = GetCurrentBalance(selectedRental);

            if (currentBalance == 0)
            {
                MessageBox.Show("This rental is already fully paid.");
                textBoxRemaingAmount.Text = "0";
                textBoxPaymentStatus.Text = "Paid";
                comboBoxPaymentType.Text = "Full Payment";
                return;
            }

            if (paidAmount > currentBalance)
            {
                MessageBox.Show("Paid amount is more than the current balance.");
                return;
            }

            decimal remainingAmount = currentBalance - paidAmount;

            textBoxRemaingAmount.Text = remainingAmount.ToString();

            if (remainingAmount == 0)
            {
                textBoxPaymentStatus.Text = "Paid";
                comboBoxPaymentType.Text = "Full Payment";
            }
            else
            {
                textBoxPaymentStatus.Text = "Partially Paid";
                comboBoxPaymentType.Text = "Installments";
            }
        }

        private void buttonSavePayment_Click(object sender, EventArgs e)
        {
            if (comboBoxClientName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a client first.");
                return;
            }

            if (comboBoxRentedCarPlate.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rented car first.");
                return;
            }

            Rental selectedRental = GetSelectedRental();

            if (selectedRental == null)
            {
                MessageBox.Show("Please select a rented car first.");
                return;
            }

            if (textBoxPaidAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please enter paid amount.");
                textBoxPaidAmount.Focus();
                return;
            }

            if (textBoxRemaingAmount.Text.Trim() == "" ||
                textBoxPaymentStatus.Text.Trim() == "")
            {
                MessageBox.Show("Please calculate remaining amount first.");
                return;
            }

            if (comboBoxPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            if (comboBoxPaymentType.Text.Trim() == "")
            {
                MessageBox.Show("Please select payment type.");
                return;
            }

            decimal paidAmount = decimal.Parse(textBoxPaidAmount.Text.Trim());
            decimal remainingAmount = decimal.Parse(textBoxRemaingAmount.Text.Trim());

            Payment newPayment = new Payment
            {
                ClientName = selectedRental.ClientName,
                ClientNationalID = selectedRental.ClientNationalID,
                PlateNumber = selectedRental.PlateNumber,

                RentDate = selectedRental.RentDate,
                ReturnDate = selectedRental.ReturnDate,

                TotalPrice = selectedRental.TotalPrice,
                PaidAmount = paidAmount,
                RemainingAmount = remainingAmount,

                PaymentMethod = comboBoxPaymentMethod.Text,
                PaymentType = comboBoxPaymentType.Text,
                PaymentStatus = textBoxPaymentStatus.Text,

                PaymentDate = DateTime.Now
            };

            PaymentData.Payments.Add(newPayment);

            textBoxCurrentBlanace.Text = remainingAmount.ToString();

            MessageBox.Show("Payment saved successfully.");

            ClearPaymentFieldsOnly();
        }

        private void ClearRentalInfoOnly()
        {
            comboBoxRentedCarPlate.SelectedIndex = -1;

            RentDate.Clear();
            ReturnDate.Clear();
            TotalPrice.Clear();
            textBoxCurrentBlanace.Clear();

            ClearPaymentFieldsOnly();
        }

        private void ClearPaymentFieldsOnly()
        {
            textBoxPaidAmount.Clear();
            textBoxRemaingAmount.Clear();
            textBoxPaymentStatus.Clear();

            comboBoxPaymentMethod.SelectedIndex = -1;
            comboBoxPaymentType.SelectedIndex = -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxClientName.SelectedIndex = -1;

            comboBoxRentedCarPlate.SelectedIndex = -1;
            comboBoxRentedCarPlate.Items.Clear();

            textBoxNationalID.Clear();

            RentDate.Clear();
            ReturnDate.Clear();
            TotalPrice.Clear();
            textBoxCurrentBlanace.Clear();

            ClearPaymentFieldsOnly();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxClientName_SelectedIndexChanged(sender, e);
        }

        private void comboBoxRentedCarPlate_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxRentedCarPlate_SelectedIndexChanged(sender, e);
        }

        private void buttonSavePayment_Click_1(object sender, EventArgs e)
        {
            buttonSavePayment_Click(sender, e);
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            buttonClear_Click(sender, e);
        }

        private void Payments_History_Load_1(object sender, EventArgs e)
        {
            Payments_History_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitleClientInfo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRemaingAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPaymentStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxLastPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurrentBlanace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}