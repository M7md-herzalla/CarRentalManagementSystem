    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    namespace CarRentalSystem
    {
        public partial class RentalRecords : Form
        {
            public RentalRecords()
            {
                InitializeComponent();

                this.Load += RentalRecords_Load;
            }

            private void RentalRecords_Load(object sender, EventArgs e)
        {
            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();

            SetupRentalRecordsGrid();
            StyleRentalRecordsGrid();
            LoadClientsToSearchComboBox();
            LoadRentalRecords();
        }

            private void LoadClientsToSearchComboBox()
            {
                ClientData.LoadDefaultClients();

                comboBoxSearchClient.Items.Clear();

                foreach (Client client in ClientData.Clients)
                {
                    comboBoxSearchClient.Items.Add(client);
                }

                comboBoxSearchClient.DisplayMember = "Name";
                comboBoxSearchClient.DropDownStyle = ComboBoxStyle.DropDownList;

                textBoxNationalID.ReadOnly = true;
                textBoxNationalID.Clear();
            }

            private void StyleRentalRecordsGrid()
            {
                dgvRentalRecords.BackgroundColor = Color.White;
                dgvRentalRecords.BorderStyle = BorderStyle.None;

                dgvRentalRecords.EnableHeadersVisualStyles = false;

                dgvRentalRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 65, 81);
                dgvRentalRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvRentalRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dgvRentalRecords.DefaultCellStyle.BackColor = Color.White;
                dgvRentalRecords.DefaultCellStyle.ForeColor = Color.Black;
                dgvRentalRecords.DefaultCellStyle.Font = new Font("Segoe UI", 9);

                dgvRentalRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

                dgvRentalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRentalRecords.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
                dgvRentalRecords.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvRentalRecords.RowHeadersVisible = false;
                dgvRentalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRentalRecords.AllowUserToAddRows = false;
                dgvRentalRecords.ReadOnly = true;
            }

            private void SetupRentalRecordsGrid()
            {
                dgvRentalRecords.Columns.Clear();

                dgvRentalRecords.Columns.Add("No", "No.");
                dgvRentalRecords.Columns.Add("ClientName", "Client Name");
                dgvRentalRecords.Columns.Add("NationalID", "National ID");
                dgvRentalRecords.Columns.Add("Car", "Car");
                dgvRentalRecords.Columns.Add("PlateNumber", "Plate Number");
                dgvRentalRecords.Columns.Add("RentDate", "Rent Date");
                dgvRentalRecords.Columns.Add("ReturnDate", "Return Date");
                dgvRentalRecords.Columns.Add("Days", "Days");
                dgvRentalRecords.Columns.Add("TotalPrice", "Total Price");
                dgvRentalRecords.Columns.Add("Status", "Rental Status");

                dgvRentalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRentalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRentalRecords.MultiSelect = false;
                dgvRentalRecords.ReadOnly = true;
                dgvRentalRecords.AllowUserToAddRows = false;
            }

            private void LoadRentalRecords(string nationalIDFilter = "")
            {
                dgvRentalRecords.Rows.Clear();

                int counter = 1;

                foreach (Rental rental in RentalData.Rentals)
                {
                    if (nationalIDFilter != "" && rental.ClientNationalID != nationalIDFilter)
                    {
                        continue;
                    }

                    RentalCar car = CarData.Cars
                        .FirstOrDefault(c => c.PlateNumber == rental.PlateNumber);

                    string carInfo = "Unknown Car";

                    if (car != null)
                    {
                        carInfo = car.Brand + " " + car.Type + " " + car.Year;
                    }

                    int days = (rental.ReturnDate.Date - rental.RentDate.Date).Days;

                    string status = GetRentalStatus(rental);

                    int rowIndex = dgvRentalRecords.Rows.Add(
                        counter.ToString(),
                        rental.ClientName,
                        rental.ClientNationalID,
                        carInfo,
                        rental.PlateNumber,
                        rental.RentDate.ToShortDateString(),
                        rental.ReturnDate.ToShortDateString(),
                        days.ToString(),
                        rental.TotalPrice.ToString(),
                        status
                    );

                    dgvRentalRecords.Rows[rowIndex].Tag = rental;

                    counter++;
                }
            }

            private string GetRentalStatus(Rental rental)
            {
                if (rental.IsFinished)
                {
                    return "Finished";
                }

                if (DateTime.Today > rental.ReturnDate.Date)
                {
                    return "Expired";
                }

                if (DateTime.Today == rental.ReturnDate.Date)
                {
                    return "Due Today";
                }

                return "Active";
            }

            private bool CanFinishRental(Rental rental)
            {
                return !rental.IsFinished && DateTime.Today >= rental.ReturnDate.Date;
            }

            private void SearchRentalRecords()
            {
                string nationalID = textBoxNationalID.Text.Trim();

                if (nationalID == "")
                {
                    MessageBox.Show("Please select a client first.");
                    return;
                }

                LoadRentalRecords(nationalID);

                if (dgvRentalRecords.Rows.Count == 0)
                {
                    MessageBox.Show("No rental records found for this client.");
                }
            }

            private void FinishSelectedRental()
            {
                if (dgvRentalRecords.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a rental record.");
                    return;
                }

                Rental rental = dgvRentalRecords.SelectedRows[0].Tag as Rental;

                if (rental == null)
                {
                    MessageBox.Show("Invalid rental record.");
                    return;
                }

                if (rental.IsFinished)
                {
                    MessageBox.Show("This rental is already finished.");
                    return;
                }

                if (!CanFinishRental(rental))
                {
                    MessageBox.Show(
                        "This rental is not expired yet. It can be finished on: " +
                        rental.ReturnDate.ToShortDateString()
                    );
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to finish this rental and make the car available again?",
                    "Finish Rental",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    rental.IsFinished = true;

                    RentalCar car = CarData.Cars
                        .FirstOrDefault(c => c.PlateNumber == rental.PlateNumber);

                    if (car != null)
                    {
                        car.Status = "Available";
                    }

                    LoadRentalRecords(textBoxNationalID.Text.Trim());

                    MessageBox.Show("Rental finished successfully. Car status changed to Available.");
                }
            }

            private void ClearSearch()
            {
                comboBoxSearchClient.SelectedIndex = -1;
                textBoxNationalID.Clear();

                LoadRentalRecords();
                dgvRentalRecords.ClearSelection();
            }

            private void btnLoadRecords_Click(object sender, EventArgs e)
            {
            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();
            RentalData.LoadSampleRentals();

            SetupRentalRecordsGrid();
            StyleRentalRecordsGrid();
            LoadClientsToSearchComboBox();
            LoadRentalRecords();

            }

            private void btnSearchRecord_Click(object sender, EventArgs e)
            {
                SearchRentalRecords();
            }

            private void btnSearchRecord_Click_1(object sender, EventArgs e)
            {
                SearchRentalRecords();
            }

            private void btnFinishRental_Click(object sender, EventArgs e)
            {
                FinishSelectedRental();
            }

            private void btnFinishRental_Click_1(object sender, EventArgs e)
            {
                FinishSelectedRental();
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearSearch();
            }

            private void btnClear_Click_1(object sender, EventArgs e)
            {
                ClearSearch();
            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnBack_Click_1(object sender, EventArgs e)
            {
                this.Close();
            }

            private void comboBoxSearchClient_SelectedIndexChanged(object sender, EventArgs e)
            {
                Client selectedClient = comboBoxSearchClient.SelectedItem as Client;

                if (selectedClient != null)
                {
                    textBoxNationalID.Text = selectedClient.NationalID;
                }
            }

            private void dgvRentalRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void textBoxSearch_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBoxNationalID_TextChanged(object sender, EventArgs e)
            {

            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel2_Paint_1(object sender, PaintEventArgs e)
            {

            }

            private void labelSearchClient_Click(object sender, EventArgs e)
            {

            }
        }
    }