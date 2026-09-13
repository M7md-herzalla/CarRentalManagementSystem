using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class RentCarsForm : Form
    {
        List<RentalCar> cars = new List<RentalCar>();
        bool isLoading = false;

        public RentCarsForm()
        {
            InitializeComponent();

            this.Load += RentCarsForm_Load;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            buttonBack.Click += buttonBack_Click;
        }

        private void RentCarsForm_Load(object sender, EventArgs e)
        {
            isLoading = true;

            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();
            RentalData.UpdateFinishedRentals();

            RefreshAvailableCars();
            LoadClientsToComboBox();

            comboBoxClientName.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCarModel.DropDownStyle = ComboBoxStyle.DropDown;

            textBoxCarModel.ReadOnly = true;
            textBoxPlateNumber.ReadOnly = true;
            textBoxDailyPrice.ReadOnly = true;
            textBoxTotalPrice.ReadOnly = true;

            comboBox1.SelectedIndex = -1;
            ClearCarFields();

            isLoading = false;
        }

        private void LoadClientsToComboBox()
        {
            comboBoxClientName.Items.Clear();

            foreach (Client client in ClientData.Clients)
            {
                comboBoxClientName.Items.Add(client);
            }

            comboBoxClientName.DisplayMember = "Name";
            comboBoxClientName.DropDownStyle = ComboBoxStyle.DropDown;

            comboBoxCarModel.Items.Clear();
            comboBoxCarModel.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void RefreshAvailableCars()
        {
            comboBox1.DataSource = null;

            comboBox1.DataSource = CarData.Cars
                .Where(car => car.Status == "Available")
                .ToList();

            comboBox1.DisplayMember = "DisplayText";
            comboBox1.ValueMember = "PlateNumber";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            RentalCar selectedCar = comboBox1.SelectedItem as RentalCar;

            if (selectedCar == null)
            {
                ClearCarFields();
                return;
            }

            textBoxCarModel.Text = selectedCar.Model + " " + selectedCar.Year;
            textBoxPlateNumber.Text = selectedCar.PlateNumber;
            textBoxDailyPrice.Text = selectedCar.DailyPrice.ToString();
        }

        private void comboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client selectedClient = comboBoxClientName.SelectedItem as Client;

            if (selectedClient != null)
            {
                comboBoxClientName.Text = selectedClient.Name;
                comboBoxCarModel.Text = selectedClient.NationalID;
            }
        }

        private void buttonCalTotal_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car first.");
                return;
            }

            DateTime rentDate = dateTimePickerRentDate.Value.Date;
            DateTime returnDate = dateTimePickerReturnDate.Value.Date;

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Return Date must be after Rent Date.");
                return;
            }

            decimal dailyPrice;

            if (!decimal.TryParse(textBoxDailyPrice.Text, out dailyPrice))
            {
                MessageBox.Show("Invalid daily price.");
                return;
            }

            int days = (returnDate - rentDate).Days;
            decimal totalPrice = days * dailyPrice;

            textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void buttonAddRental_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clientName = comboBoxClientName.Text.Trim();
            string nationalID = comboBoxCarModel.Text.Trim();

            Client selectedClient = comboBoxClientName.SelectedItem as Client;

            if (selectedClient != null)
            {
                clientName = selectedClient.Name;
                nationalID = selectedClient.NationalID;
                comboBoxCarModel.Text = selectedClient.NationalID;
            }

            if (clientName == "")
            {
                MessageBox.Show("Please enter client name.");
                return;
            }

            if (!clientName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Client Name must contain letters only.");
                return;
            }

            if (nationalID == "")
            {
                MessageBox.Show("Please enter client national ID.");
                return;
            }

            if (!nationalID.All(char.IsDigit))
            {
                MessageBox.Show("Client National ID must contain numbers only.");
                return;
            }

            Client clientWithSameName = ClientData.Clients
                .FirstOrDefault(client => client.Name.ToLower() == clientName.ToLower());

            Client clientWithSameID = ClientData.Clients
                .FirstOrDefault(client => client.NationalID == nationalID);

            if (clientWithSameName != null && clientWithSameName.NationalID != nationalID)
            {
                MessageBox.Show("This client name already exists with a different National ID. Please select the client from the list.");
                comboBoxCarModel.Text = clientWithSameName.NationalID;
                return;
            }

            if (clientWithSameID != null && clientWithSameID.Name.ToLower() != clientName.ToLower())
            {
                MessageBox.Show("This National ID already belongs to another client: " + clientWithSameID.Name);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an available car.");
                return;
            }

            if (textBoxTotalPrice.Text == "")
            {
                MessageBox.Show("Please calculate total price first.");
                return;
            }

            RentalCar selectedCar = comboBox1.SelectedItem as RentalCar;

            if (selectedCar == null)
            {
                MessageBox.Show("Invalid car selection.");
                return;
            }

            if (selectedCar.Status != "Available")
            {
                MessageBox.Show("This car is not available for rent.");
                return;
            }

            DateTime rentDate = dateTimePickerRentDate.Value.Date;
            DateTime returnDate = dateTimePickerReturnDate.Value.Date;

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Return Date must be after Rent Date.");
                return;
            }

            decimal totalPrice;

            if (!decimal.TryParse(textBoxTotalPrice.Text, out totalPrice))
            {
                MessageBox.Show("Invalid total price.");
                return;
            }

            if (clientWithSameID == null)
            {
                ClientData.Clients.Add(new Client
                {
                    Name = clientName,
                    NationalID = nationalID,
                    Phone = "Not Provided",
                    Address = "Not Provided",
                    Email = "Not Provided",
                    LicenseNumber = "Not Provided"
                });
            }

            RentalData.Rentals.Add(new Rental
            {
                ClientName = clientName,
                ClientNationalID = nationalID,
                PlateNumber = selectedCar.PlateNumber,
                RentDate = rentDate,
                ReturnDate = returnDate,
                TotalPrice = totalPrice,
                IsFinished = false
            });

            selectedCar.Status = "Rented";

            MessageBox.Show("Rental added successfully. Car status changed to Rented.");

            LoadClientsToComboBox();
            RefreshAvailableCars();
            ClearRentalForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearRentalForm();
        }

        private void ClearRentalForm()
        {
            comboBoxClientName.SelectedIndex = -1;
            comboBoxCarModel.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

            comboBoxClientName.Text = "";
            comboBoxCarModel.Text = "";

            dateTimePickerRentDate.Value = DateTime.Now;
            dateTimePickerReturnDate.Value = DateTime.Now;

            ClearCarFields();
        }

        private void ClearCarFields()
        {
            textBoxCarModel.Clear();
            textBoxPlateNumber.Clear();
            textBoxDailyPrice.Clear();
            textBoxTotalPrice.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCarModel.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void dateTimePickerRentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerRetuenDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCarModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDailyPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelCarModel_Click(object sender, EventArgs e)
        {

        }

        private void labelClientID_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void RentCarsForm_Load_1(object sender, EventArgs e)
        {
            RentCarsForm_Load(sender, e);
        }
    }
}