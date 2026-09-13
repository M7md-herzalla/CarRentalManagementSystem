using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace CarRentalSystem
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
         
        }
        private void SetupCarsGrid()
        {
            dgvCars.Columns.Clear();

            dgvCars.Columns.Add("No", "No.");
            dgvCars.Columns.Add("Brand", "Car Brand");
            dgvCars.Columns.Add("Type", "Car Type");
            dgvCars.Columns.Add("Model", "Car Model");
            dgvCars.Columns.Add("Plate", "Plate Number");
            dgvCars.Columns.Add("Color", "Car Color");
            dgvCars.Columns.Add("Price", "Car Price");
            dgvCars.Columns.Add("Status", "Status");
            dgvCars.Columns.Add("RentedBy", "Rented By");
            dgvCars.Columns.Add("ReturnDate", "Return Date");

            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.MultiSelect = false;
            dgvCars.ReadOnly = true;
            dgvCars.AllowUserToAddRows = false;
            dgvCars.ScrollBars = ScrollBars.Both;
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 65, 81);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 32;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
        }
        private void LoadCarsFromData(string searchValue = "")
        {
            dgvCars.Rows.Clear();

            searchValue = searchValue.ToLower();

            var cars = CarData.Cars.Where(car =>
                searchValue == "" ||
                car.Brand.ToLower().Contains(searchValue) ||
                car.Type.ToLower().Contains(searchValue) ||
                car.Year.ToLower().Contains(searchValue) ||
                car.PlateNumber.ToLower().Contains(searchValue) ||
                car.Color.ToLower().Contains(searchValue) ||
                car.DailyPrice.ToString().Contains(searchValue) ||
                car.Status.ToLower().Contains(searchValue)
            ).ToList();

            for (int i = 0; i < cars.Count; i++)
            {
                RentalCar car = cars[i];

                Rental activeRental = RentalData.Rentals
                    .FirstOrDefault(rental =>
                        rental.PlateNumber == car.PlateNumber &&
                        rental.IsFinished == false);

                string rentedBy = "-";
                string returnDate = "-";

                if (activeRental != null)
                {
                    rentedBy = activeRental.ClientName;
                    returnDate = activeRental.ReturnDate.ToShortDateString();
                    car.Status = "Rented";
                }
                else if (car.Status == "Rented")
                {
                    car.Status = "Available";
                }

                dgvCars.Rows.Add(
                    (i + 1).ToString(),
                    car.Brand,
                    car.Type,
                    car.Year,
                    car.PlateNumber,
                    car.Color,
                    car.DailyPrice.ToString(),
                    car.Status,
                    rentedBy,
                    returnDate
                );
            }
        }

        private void RefreshCarsGrid()
        {
            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();

            SetupCarsGrid();
            StyleDataGridView(dgvCars);
            LoadCarsFromData();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();
            RefreshCarsGrid();
        }

        
        private bool ValidateInputs()
        {
            if (textBoxBrand.Text == "" ||
                textBoxYear.Text == "" ||
                textBoxPlateNumber.Text == "" ||
                textBoxColor.Text == "" ||
                textBoxPrice.Text == "" ||
                comboBoxCarType.SelectedIndex == -1 ||
                comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            int year;
            if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show("Car model must be a number.");
                return false;
            }

            double price;
            if (!double.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Car price must be a number.");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            textBoxPlateNumber.Clear();
            textBoxPrice.Clear();
            textBoxColor.Clear();
            textBoxBrand.Clear();
            textBoxYear.Clear();

            comboBoxCarType.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string plateNumber = textBoxPlateNumber.Text.Trim();

            if (CarData.Cars.Any(car => car.PlateNumber == plateNumber))
            {
                MessageBox.Show("This plate number already exists.");
                return;
            }

            decimal price = decimal.Parse(textBoxPrice.Text.Trim());

            CarData.Cars.Add(new RentalCar
            {
                Brand = textBoxBrand.Text.Trim(),
                Type = comboBoxCarType.Text.Trim(),
                Model = textBoxBrand.Text.Trim() + " " + comboBoxCarType.Text.Trim(),
                Year = textBoxYear.Text.Trim(),
                PlateNumber = textBoxPlateNumber.Text.Trim(),
                Color = textBoxColor.Text.Trim(),
                DailyPrice = price,
                Status = comboBoxStatus.Text.Trim(),
                ImageFileName = "default.jpg"
            });

            LoadCarsFromData();
            ClearInputs();

            MessageBox.Show("Car added successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to update.");
                return;
            }

            if (!ValidateInputs())
            {
                return;
            }

            string oldPlate = dgvCars.CurrentRow.Cells["Plate"].Value.ToString();
            string newPlate = textBoxPlateNumber.Text.Trim();

            bool plateExists = CarData.Cars.Any(car =>
                car.PlateNumber == newPlate &&
                car.PlateNumber != oldPlate
            );

            if (plateExists)
            {
                MessageBox.Show("This plate number already exists.");
                return;
            }

            RentalCar carToUpdate = CarData.Cars.FirstOrDefault(car => car.PlateNumber == oldPlate);

            if (carToUpdate != null)
            {
                carToUpdate.Brand = textBoxBrand.Text.Trim();
                carToUpdate.Type = comboBoxCarType.Text.Trim();
                carToUpdate.Model = textBoxBrand.Text.Trim() + " " + comboBoxCarType.Text.Trim();
                carToUpdate.Year = textBoxYear.Text.Trim();
                carToUpdate.PlateNumber = textBoxPlateNumber.Text.Trim();
                carToUpdate.Color = textBoxColor.Text.Trim();
                carToUpdate.DailyPrice = decimal.Parse(textBoxPrice.Text.Trim());
                carToUpdate.Status = comboBoxStatus.Text.Trim();
            }

            LoadCarsFromData();
            ClearInputs();

            MessageBox.Show("Car updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            string plateNumber = dgvCars.CurrentRow.Cells["Plate"].Value.ToString();

            RentalCar carToRemove = CarData.Cars.FirstOrDefault(car => car.PlateNumber == plateNumber);

            if (carToRemove != null)
            {
                CarData.Cars.Remove(carToRemove);
            }

            LoadCarsFromData();
            ClearInputs();

            MessageBox.Show("Car deleted successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = "";

            if (textBoxBrand.Text.Trim() != "")
                searchValue = textBoxBrand.Text.Trim();
            else if (comboBoxCarType.Text.Trim() != "")
                searchValue = comboBoxCarType.Text.Trim();
            else if (textBoxYear.Text.Trim() != "")
                searchValue = textBoxYear.Text.Trim();
            else if (textBoxPlateNumber.Text.Trim() != "")
                searchValue = textBoxPlateNumber.Text.Trim();
            else if (textBoxColor.Text.Trim() != "")
                searchValue = textBoxColor.Text.Trim();
            else if (textBoxPrice.Text.Trim() != "")
                searchValue = textBoxPrice.Text.Trim();
            else if (comboBoxStatus.Text.Trim() != "")
                searchValue = comboBoxStatus.Text.Trim();

            if (searchValue == "")
            {
                MessageBox.Show("Please enter car brand, type, model, plate, color, price, or status to search.");
                return;
            }

            LoadCarsFromData(searchValue);

            if (dgvCars.Rows.Count == 0)
            {
                MessageBox.Show("Car not found.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadCarsFromData();
            dgvCars.ClearSelection();
        }

        private void btnLoadCars_Click(object sender, EventArgs e)
        {
            RefreshCarsGrid();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                textBoxBrand.Text = row.Cells["Brand"].Value.ToString();
                comboBoxCarType.Text = row.Cells["Type"].Value.ToString();
                textBoxYear.Text = row.Cells["Model"].Value.ToString();
                textBoxPlateNumber.Text = row.Cells["Plate"].Value.ToString();
                textBoxColor.Text = row.Cells["Color"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                comboBoxStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        // Empty event handlers required by Designer
        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPlateNumber_Click(object sender, EventArgs e)
        {

        }

        private void labelBrand_Click(object sender, EventArgs e)
        {

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        private void labelModel_Click(object sender, EventArgs e)
        {

        }

        private void labelTittle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCarType_Click(object sender, EventArgs e)
        {

        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}