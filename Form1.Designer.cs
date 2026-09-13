namespace CarRentalSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarRentalManagementSystemLabel = new System.Windows.Forms.Label();
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnViewRentals = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.groupBoxDeatails = new System.Windows.Forms.GroupBox();
            this.panelMainTittel = new System.Windows.Forms.Panel();
            this.labelAdminDashBoard = new System.Windows.Forms.Label();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.buttonManageCustomers = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureMain2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxDeatails.SuspendLayout();
            this.panelMainTittel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain2)).BeginInit();
            this.SuspendLayout();
            // 
            // CarRentalManagementSystemLabel
            // 
            this.CarRentalManagementSystemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarRentalManagementSystemLabel.AutoSize = true;
            this.CarRentalManagementSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarRentalManagementSystemLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarRentalManagementSystemLabel.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalManagementSystemLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.CarRentalManagementSystemLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CarRentalManagementSystemLabel.Location = new System.Drawing.Point(31, 8);
            this.CarRentalManagementSystemLabel.Name = "CarRentalManagementSystemLabel";
            this.CarRentalManagementSystemLabel.Size = new System.Drawing.Size(582, 66);
            this.CarRentalManagementSystemLabel.TabIndex = 0;
            this.CarRentalManagementSystemLabel.Text = "Car Rental Management System";
            this.CarRentalManagementSystemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CarRentalManagementSystemLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManageCars
            // 
            this.btnManageCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageCars.BackColor = System.Drawing.Color.White;
            this.btnManageCars.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManageCars.FlatAppearance.BorderSize = 0;
            this.btnManageCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnManageCars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnManageCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnManageCars.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageCars.Location = new System.Drawing.Point(271, 127);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(180, 55);
            this.btnManageCars.TabIndex = 1;
            this.btnManageCars.Text = "Manage Cars";
            this.btnManageCars.UseVisualStyleBackColor = false;
            this.btnManageCars.Click += new System.EventHandler(this.btnManageCars_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRentCar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRentCar.FlatAppearance.BorderSize = 0;
            this.btnRentCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnRentCar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRentCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentCar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRentCar.Location = new System.Drawing.Point(271, 301);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(180, 55);
            this.btnRentCar.TabIndex = 2;
            this.btnRentCar.Text = "New Rentals";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnViewRentals
            // 
            this.btnViewRentals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewRentals.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewRentals.FlatAppearance.BorderSize = 0;
            this.btnViewRentals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnViewRentals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRentals.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewRentals.Location = new System.Drawing.Point(324, 215);
            this.btnViewRentals.Name = "btnViewRentals";
            this.btnViewRentals.Size = new System.Drawing.Size(180, 55);
            this.btnViewRentals.TabIndex = 3;
            this.btnViewRentals.TabStop = false;
            this.btnViewRentals.Text = "Rental Records";
            this.btnViewRentals.UseVisualStyleBackColor = true;
            this.btnViewRentals.Click += new System.EventHandler(this.btnViewRentals_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(6, 111);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(386, 19);
            this.labelText.TabIndex = 5;
            this.labelText.Tag = "Manage cars, rentals, and customer records easily. ";
            this.labelText.Text = "Manage cars, rentals, and clients records easily. ";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // groupBoxDeatails
            // 
            this.groupBoxDeatails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxDeatails.Controls.Add(this.labelText);
            this.groupBoxDeatails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDeatails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDeatails.Font = new System.Drawing.Font("Nirmala Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeatails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDeatails.Location = new System.Drawing.Point(0, 425);
            this.groupBoxDeatails.Name = "groupBoxDeatails";
            this.groupBoxDeatails.Size = new System.Drawing.Size(1032, 148);
            this.groupBoxDeatails.TabIndex = 6;
            this.groupBoxDeatails.TabStop = false;
            this.groupBoxDeatails.Text = "More Deatails";
            this.groupBoxDeatails.Enter += new System.EventHandler(this.groupBoxDeatails_Enter);
            // 
            // panelMainTittel
            // 
            this.panelMainTittel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainTittel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainTittel.Controls.Add(this.labelAdminDashBoard);
            this.panelMainTittel.Controls.Add(this.CarRentalManagementSystemLabel);
            this.panelMainTittel.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.panelMainTittel.Location = new System.Drawing.Point(-1, 0);
            this.panelMainTittel.Name = "panelMainTittel";
            this.panelMainTittel.Size = new System.Drawing.Size(753, 86);
            this.panelMainTittel.TabIndex = 9;
            // 
            // labelAdminDashBoard
            // 
            this.labelAdminDashBoard.AutoSize = true;
            this.labelAdminDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminDashBoard.Location = new System.Drawing.Point(569, 55);
            this.labelAdminDashBoard.Name = "labelAdminDashBoard";
            this.labelAdminDashBoard.Size = new System.Drawing.Size(180, 25);
            this.labelAdminDashBoard.TabIndex = 13;
            this.labelAdminDashBoard.Text = "AdminDashBoard";
            // 
            // buttonPayments
            // 
            this.buttonPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayments.Location = new System.Drawing.Point(541, 215);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(180, 55);
            this.buttonPayments.TabIndex = 10;
            this.buttonPayments.Text = "Payments History";
            this.buttonPayments.UseVisualStyleBackColor = true;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // buttonManageCustomers
            // 
            this.buttonManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonManageCustomers.Location = new System.Drawing.Point(490, 127);
            this.buttonManageCustomers.Name = "buttonManageCustomers";
            this.buttonManageCustomers.Size = new System.Drawing.Size(180, 55);
            this.buttonManageCustomers.TabIndex = 12;
            this.buttonManageCustomers.Text = "Manage Clients";
            this.buttonManageCustomers.UseVisualStyleBackColor = true;
            this.buttonManageCustomers.Click += new System.EventHandler(this.buttonManageCustomers_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(752, -1);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(279, 281);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 7;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // pictureMain2
            // 
            this.pictureMain2.BackColor = System.Drawing.Color.Transparent;
            this.pictureMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureMain2.Image = ((System.Drawing.Image)(resources.GetObject("pictureMain2.Image")));
            this.pictureMain2.Location = new System.Drawing.Point(10, 162);
            this.pictureMain2.Name = "pictureMain2";
            this.pictureMain2.Size = new System.Drawing.Size(209, 194);
            this.pictureMain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMain2.TabIndex = 8;
            this.pictureMain2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(490, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 55);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 573);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonManageCustomers);
            this.Controls.Add(this.buttonPayments);
            this.Controls.Add(this.panelMainTittel);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.pictureMain2);
            this.Controls.Add(this.groupBoxDeatails);
            this.Controls.Add(this.btnViewRentals);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.btnManageCars);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDeatails.ResumeLayout(false);
            this.groupBoxDeatails.PerformLayout();
            this.panelMainTittel.ResumeLayout(false);
            this.panelMainTittel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CarRentalManagementSystemLabel;
        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnViewRentals;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.GroupBox groupBoxDeatails;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox pictureMain2;
        private System.Windows.Forms.Panel panelMainTittel;
        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.Button buttonManageCustomers;
        private System.Windows.Forms.Label labelAdminDashBoard;
        private System.Windows.Forms.Button buttonExit;
    }
}

