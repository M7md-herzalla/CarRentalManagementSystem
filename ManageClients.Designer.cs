namespace CarRentalSystem
{
    partial class ManageClients
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
            this.labelTittleManageClients = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelNational = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelLicenseNumber = new System.Windows.Forms.Label();
            this.textBoxLincesNumber = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnLoadClients = new System.Windows.Forms.Button();
            this.btnSearchClienet = new System.Windows.Forms.Button();
            this.btnClearClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTittleManageClients
            // 
            this.labelTittleManageClients.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTittleManageClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTittleManageClients.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleManageClients.Location = new System.Drawing.Point(24, 12);
            this.labelTittleManageClients.Name = "labelTittleManageClients";
            this.labelTittleManageClients.Size = new System.Drawing.Size(329, 60);
            this.labelTittleManageClients.TabIndex = 21;
            this.labelTittleManageClients.Text = "Manage Clients";
            this.labelTittleManageClients.Click += new System.EventHandler(this.labelTittle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelNational);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelLicenseNumber);
            this.panel1.Controls.Add(this.textBoxLincesNumber);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Location = new System.Drawing.Point(22, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 346);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(19, 132);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(153, 37);
            this.textBoxPhoneNumber.TabIndex = 22;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(9, 113);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(135, 18);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Phone Number : ";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(19, 58);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 35);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(4, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 49);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelNational
            // 
            this.labelNational.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNational.Location = new System.Drawing.Point(10, 187);
            this.labelNational.Name = "labelNational";
            this.labelNational.Size = new System.Drawing.Size(106, 16);
            this.labelNational.TabIndex = 19;
            this.labelNational.Text = "National ID : ";
            this.labelNational.Click += new System.EventHandler(this.labelNational_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(19, 205);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(153, 37);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(215, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 18);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Email : ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(231, 132);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(153, 37);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 18);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Client Name : ";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(231, 58);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(153, 37);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelLicenseNumber
            // 
            this.labelLicenseNumber.AutoSize = true;
            this.labelLicenseNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelLicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseNumber.Location = new System.Drawing.Point(215, 186);
            this.labelLicenseNumber.Name = "labelLicenseNumber";
            this.labelLicenseNumber.Size = new System.Drawing.Size(145, 18);
            this.labelLicenseNumber.TabIndex = 16;
            this.labelLicenseNumber.Text = "License Number : ";
            // 
            // textBoxLincesNumber
            // 
            this.textBoxLincesNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLincesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLincesNumber.Location = new System.Drawing.Point(231, 205);
            this.textBoxLincesNumber.Multiline = true;
            this.textBoxLincesNumber.Name = "textBoxLincesNumber";
            this.textBoxLincesNumber.Size = new System.Drawing.Size(153, 37);
            this.textBoxLincesNumber.TabIndex = 5;
            this.textBoxLincesNumber.TextChanged += new System.EventHandler(this.textBoxLincesNumber_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(223, 39);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 18);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Address : ";
            this.labelAddress.Click += new System.EventHandler(this.labelPlateNumber_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panelButtons);
            this.panel2.Location = new System.Drawing.Point(467, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 247);
            this.panel2.TabIndex = 25;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.btnUpdateClient);
            this.panelButtons.Controls.Add(this.btnAddClient);
            this.panelButtons.Controls.Add(this.btnDeleteClient);
            this.panelButtons.Controls.Add(this.btnLoadClients);
            this.panelButtons.Controls.Add(this.btnSearchClienet);
            this.panelButtons.Controls.Add(this.btnClearClient);
            this.panelButtons.Location = new System.Drawing.Point(98, 22);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(745, 201);
            this.panelButtons.TabIndex = 22;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateClient.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(291, 43);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(149, 49);
            this.btnUpdateClient.TabIndex = 9;
            this.btnUpdateClient.Text = "Update";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.DimGray;
            this.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(98, 43);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(149, 49);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(475, 43);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(149, 49);
            this.btnDeleteClient.TabIndex = 10;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnLoadClients
            // 
            this.btnLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadClients.BackColor = System.Drawing.Color.DimGray;
            this.btnLoadClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClients.Location = new System.Drawing.Point(475, 115);
            this.btnLoadClients.Name = "btnLoadClients";
            this.btnLoadClients.Size = new System.Drawing.Size(149, 49);
            this.btnLoadClients.TabIndex = 13;
            this.btnLoadClients.Text = "Load Clients";
            this.btnLoadClients.UseVisualStyleBackColor = false;
            this.btnLoadClients.Click += new System.EventHandler(this.btnLoadClients_Click);
            // 
            // btnSearchClienet
            // 
            this.btnSearchClienet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClienet.BackColor = System.Drawing.Color.DimGray;
            this.btnSearchClienet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClienet.Location = new System.Drawing.Point(98, 115);
            this.btnSearchClienet.Name = "btnSearchClienet";
            this.btnSearchClienet.Size = new System.Drawing.Size(149, 49);
            this.btnSearchClienet.TabIndex = 11;
            this.btnSearchClienet.Text = "Search";
            this.btnSearchClienet.UseVisualStyleBackColor = false;
            this.btnSearchClienet.Click += new System.EventHandler(this.btnSearchClienet_Click);
            // 
            // btnClearClient
            // 
            this.btnClearClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearClient.BackColor = System.Drawing.Color.DimGray;
            this.btnClearClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearClient.Location = new System.Drawing.Point(291, 115);
            this.btnClearClient.Name = "btnClearClient";
            this.btnClearClient.Size = new System.Drawing.Size(149, 49);
            this.btnClearClient.TabIndex = 12;
            this.btnClearClient.Text = "Clear";
            this.btnClearClient.UseVisualStyleBackColor = false;
            this.btnClearClient.Click += new System.EventHandler(this.btnClearClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(468, 12);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(972, 278);
            this.dgvClients.TabIndex = 24;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1452, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTittleManageClients);
            this.Name = "ManageClients";
            this.Text = "ManageClients";
            this.Load += new System.EventHandler(this.ManageClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTittleManageClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelNational;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelLicenseNumber;
        private System.Windows.Forms.TextBox textBoxLincesNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnLoadClients;
        private System.Windows.Forms.Button btnSearchClienet;
        private System.Windows.Forms.Button btnClearClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}