using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
namespace CarRentalSystem
{
    public partial class ManageClients : Form
    {
        public ManageClients()
        {
            InitializeComponent();
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxLincesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void labelTittle_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void labelPlateNumber_Click(object sender, EventArgs e)
        {

        }

        private void labelNational_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this client?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string nationalID = dgvClients.SelectedRows[0].Cells["NationalID"].Value.ToString();

                Client clientToRemove = ClientData.Clients
                    .FirstOrDefault(client => client.NationalID == nationalID);

                if (clientToRemove != null)
                {
                    ClientData.Clients.Remove(clientToRemove);
                }

                LoadClientsFromData();
                ClearClientInputs();

                MessageBox.Show("Client deleted successfully.");
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.Columns.Count == 0)
            {
                SetupClientsGrid();
            }

            if (!ValidateClientInputs())
            {
                return;
            }

            ClientData.Clients.Add(new Client
            {
                Name = textBoxName.Text.Trim(),
                Phone = textBoxPhoneNumber.Text.Trim(),
                NationalID = textBoxID.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                LicenseNumber = textBoxLincesNumber.Text.Trim()
            });

            LoadClientsFromData();
            ClearClientInputs();

            MessageBox.Show("Client added successfully.");
        }
        private void LoadClientsFromData(string searchValue = "")
        {
            dgvClients.Rows.Clear();

            searchValue = searchValue.ToLower();

            var clients = ClientData.Clients.Where(client =>
                searchValue == "" ||
                client.Name.ToLower().Contains(searchValue) ||
                client.Phone.Contains(searchValue) ||
                client.NationalID.Contains(searchValue) ||
                client.Address.ToLower().Contains(searchValue) ||
                client.Email.ToLower().Contains(searchValue) ||
                client.LicenseNumber.Contains(searchValue)
            ).ToList();

            for (int i = 0; i < clients.Count; i++)
            {
                Client client = clients[i];

                var activeRentals = RentalData.Rentals
                    .Where(rental =>
                        rental.ClientNationalID == client.NationalID &&
                        rental.IsFinished == false)
                    .ToList();

                string rentedCars = "-";

                if (activeRentals.Count > 0)
                {
                    rentedCars = string.Join(", ", activeRentals.Select(r => r.PlateNumber));
                }

                dgvClients.Rows.Add(
                    (i + 1).ToString(),
                    client.Name,
                    client.Phone,
                    client.NationalID,
                    client.Address,
                    client.Email,
                    client.LicenseNumber,
                    activeRentals.Count.ToString(),
                    rentedCars
                );
            }
        }
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];

                textBoxName.Text = row.Cells["ClientName"].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells["Phone"].Value.ToString();
                textBoxID.Text = row.Cells["NationalID"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxLincesNumber.Text = row.Cells["LicenseNumber"].Value.ToString();
            }
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

        private void ManageClients_Load(object sender, EventArgs e)
        {
            SetupClientsGrid();
            StyleDataGridView(dgvClients);
            ClientData.LoadDefaultClients();
            LoadClientsFromData();
        }
        private void RefreshClientsGrid()
        {
            ClientData.LoadDefaultClients();

            SetupClientsGrid();
            StyleDataGridView(dgvClients);
            LoadClientsFromData();
        }
        private bool ValidateClientInputs()
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhoneNumber.Text.Trim();
            string nationalID = textBoxID.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string license = textBoxLincesNumber.Text.Trim();

            if (name == "" ||
                phone == "" ||
                nationalID == "" ||
                address == "" ||
                email == "" ||
                license == "")
            {
                MessageBox.Show("Please fill all client fields.");
                return false;
            }

            if (!name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Client Name must contain letters only.");
                return false;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone Number must contain numbers only.");
                return false;
            }

            if (!nationalID.All(char.IsDigit))
            {
                MessageBox.Show("National ID must contain numbers only.");
                return false;
            }

            if (!license.All(char.IsDigit))
            {
                MessageBox.Show("License Number must contain numbers only.");
                return false;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com");
                return false;
            }

            return true;
        }

        private void ClearClientInputs()
        {
            textBoxName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxID.Clear();
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxLincesNumber.Clear();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLincesNumber_TextChanged(object sender, EventArgs e)
        {

        }
        
       
        private void SetupClientsGrid()
        {
            dgvClients.Columns.Clear();

            dgvClients.Columns.Add("No", "No.");
            dgvClients.Columns.Add("ClientName", "Client Name");
            dgvClients.Columns.Add("Phone", "Phone Number");
            dgvClients.Columns.Add("NationalID", "National ID");
            dgvClients.Columns.Add("Address", "Address");
            dgvClients.Columns.Add("Email", "Email");
            dgvClients.Columns.Add("LicenseNumber", "License Number");
            dgvClients.Columns.Add("ActiveRentals", "Active Rentals");
            dgvClients.Columns.Add("RentedCars", "Rented Cars");

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;
            dgvClients.ReadOnly = true;
            dgvClients.AllowUserToAddRows = false;
        }
        private void btnLoadClients_Click(object sender, EventArgs e)
        {
            RefreshClientsGrid();

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to update.");
                return;
            }

            if (!ValidateClientInputs())
            {
                return;
            }

            string oldNationalID = dgvClients.SelectedRows[0].Cells["NationalID"].Value.ToString();

            Client clientToUpdate = ClientData.Clients
                .FirstOrDefault(client => client.NationalID == oldNationalID);

            if (clientToUpdate != null)
            {
                clientToUpdate.Name = textBoxName.Text.Trim();
                clientToUpdate.Phone = textBoxPhoneNumber.Text.Trim();
                clientToUpdate.NationalID = textBoxID.Text.Trim();
                clientToUpdate.Address = textBoxAddress.Text.Trim();
                clientToUpdate.Email = textBoxEmail.Text.Trim();
                clientToUpdate.LicenseNumber = textBoxLincesNumber.Text.Trim();
            }

            LoadClientsFromData();
            ClearClientInputs();

            MessageBox.Show("Client updated successfully.");
        }

        private void btnSearchClienet_Click(object sender, EventArgs e)
        {
            string searchValue = "";

            if (textBoxName.Text.Trim() != "")
                searchValue = textBoxName.Text.Trim();
            else if (textBoxPhoneNumber.Text.Trim() != "")
                searchValue = textBoxPhoneNumber.Text.Trim();
            else if (textBoxID.Text.Trim() != "")
                searchValue = textBoxID.Text.Trim();
            else if (textBoxEmail.Text.Trim() != "")
                searchValue = textBoxEmail.Text.Trim();
            else if (textBoxLincesNumber.Text.Trim() != "")
                searchValue = textBoxLincesNumber.Text.Trim();

            if (searchValue == "")
            {
                MessageBox.Show("Please enter client name, phone, ID, email, or license number to search.");
                return;
            }

            LoadClientsFromData(searchValue);

            if (dgvClients.Rows.Count == 0)
            {
                MessageBox.Show("Client not found.");
            }
        }

        private void btnClearClient_Click(object sender, EventArgs e)
        {
            ClearClientInputs();
            LoadClientsFromData();
            dgvClients.ClearSelection();
        }
    }
}
