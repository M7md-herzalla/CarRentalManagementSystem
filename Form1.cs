using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewRentals_Click(object sender, EventArgs e)
        {
            RentalRecords viewForm = new RentalRecords();
            this.Hide();
            viewForm.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            RentCarsForm rentForm = new RentCarsForm();
            this.Hide();
            rentForm.ShowDialog();
            this.Show();
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {

            CarsForm carsForm = new CarsForm();
            this.Hide();
            carsForm.ShowDialog();
            this.Show();
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDeatails_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            Payments_History paymenthistory = new Payments_History();
            this.Hide();
            paymenthistory.ShowDialog();
            this.Show();
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {
            ManageClients ManageClients = new ManageClients();
            this.Hide();
            ManageClients.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
