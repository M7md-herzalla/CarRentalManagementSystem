namespace CarRentalSystem
{
    partial class Payments_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments_History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelRemaingAmount = new System.Windows.Forms.Label();
            this.textBoxRemaingAmount = new System.Windows.Forms.TextBox();
            this.labelFinancalInfo = new System.Windows.Forms.Label();
            this.labelPaymentInfo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.textBoxPaymentStatus = new System.Windows.Forms.TextBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelComboBoxClientName = new System.Windows.Forms.Label();
            this.labeltextBoxID = new System.Windows.Forms.Label();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.textBoxNationalID = new System.Windows.Forms.TextBox();
            this.labelTitleClientInfo = new System.Windows.Forms.Label();
            this.labelTitleRentalInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.TextBox();
            this.labelRentedCarPlate = new System.Windows.Forms.Label();
            this.labelRentDate = new System.Windows.Forms.Label();
            this.comboBoxRentedCarPlate = new System.Windows.Forms.ComboBox();
            this.RentDate = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSavePayment = new System.Windows.Forms.Button();
            this.buttonCalRemaing = new System.Windows.Forms.Button();
            this.labelTitlePaymentHistory = new System.Windows.Forms.Label();
            this.pictureBoxPayment = new System.Windows.Forms.PictureBox();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.textBoxCurrentBlanace = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(29, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 505);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.labelFinancalInfo);
            this.panel8.Controls.Add(this.labelPaymentInfo);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Location = new System.Drawing.Point(354, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 489);
            this.panel8.TabIndex = 12;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBoxPaidAmount);
            this.panel4.Controls.Add(this.labelPaidAmount);
            this.panel4.Controls.Add(this.labelRemaingAmount);
            this.panel4.Controls.Add(this.textBoxRemaingAmount);
            this.panel4.Location = new System.Drawing.Point(28, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 130);
            this.panel4.TabIndex = 5;
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaidAmount.Location = new System.Drawing.Point(11, 32);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(195, 24);
            this.textBoxPaidAmount.TabIndex = 8;
            this.textBoxPaidAmount.TextChanged += new System.EventHandler(this.textBoxPaidAmount_TextChanged);
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.BackColor = System.Drawing.Color.DarkGray;
            this.labelPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidAmount.Location = new System.Drawing.Point(-2, 9);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(120, 20);
            this.labelPaidAmount.TabIndex = 1;
            this.labelPaidAmount.Text = "Paid Amount : ";
            // 
            // labelRemaingAmount
            // 
            this.labelRemaingAmount.AutoSize = true;
            this.labelRemaingAmount.BackColor = System.Drawing.Color.DarkGray;
            this.labelRemaingAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRemaingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemaingAmount.Location = new System.Drawing.Point(-2, 59);
            this.labelRemaingAmount.Name = "labelRemaingAmount";
            this.labelRemaingAmount.Size = new System.Drawing.Size(166, 20);
            this.labelRemaingAmount.TabIndex = 3;
            this.labelRemaingAmount.Text = "Remaining Amount : ";
            // 
            // textBoxRemaingAmount
            // 
            this.textBoxRemaingAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxRemaingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemaingAmount.Location = new System.Drawing.Point(8, 82);
            this.textBoxRemaingAmount.Name = "textBoxRemaingAmount";
            this.textBoxRemaingAmount.ReadOnly = true;
            this.textBoxRemaingAmount.Size = new System.Drawing.Size(198, 24);
            this.textBoxRemaingAmount.TabIndex = 2;
            this.textBoxRemaingAmount.TextChanged += new System.EventHandler(this.textBoxRemaingAmount_TextChanged);
            // 
            // labelFinancalInfo
            // 
            this.labelFinancalInfo.BackColor = System.Drawing.Color.DimGray;
            this.labelFinancalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinancalInfo.Location = new System.Drawing.Point(28, 16);
            this.labelFinancalInfo.Name = "labelFinancalInfo";
            this.labelFinancalInfo.Size = new System.Drawing.Size(185, 30);
            this.labelFinancalInfo.TabIndex = 7;
            this.labelFinancalInfo.Text = "Financial Information : ";
            // 
            // labelPaymentInfo
            // 
            this.labelPaymentInfo.BackColor = System.Drawing.Color.DimGray;
            this.labelPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentInfo.Location = new System.Drawing.Point(24, 188);
            this.labelPaymentInfo.Name = "labelPaymentInfo";
            this.labelPaymentInfo.Size = new System.Drawing.Size(185, 30);
            this.labelPaymentInfo.TabIndex = 8;
            this.labelPaymentInfo.Text = "Payment Information : ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.labelPaymentType);
            this.panel5.Controls.Add(this.comboBoxPaymentType);
            this.panel5.Controls.Add(this.labelPaymentStatus);
            this.panel5.Controls.Add(this.textBoxPaymentStatus);
            this.panel5.Controls.Add(this.labelPaymentMethod);
            this.panel5.Controls.Add(this.comboBoxPaymentMethod);
            this.panel5.Location = new System.Drawing.Point(28, 221);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 196);
            this.panel5.TabIndex = 9;
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.BackColor = System.Drawing.Color.DarkGray;
            this.labelPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentType.Location = new System.Drawing.Point(-2, 64);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(131, 20);
            this.labelPaymentType.TabIndex = 11;
            this.labelPaymentType.Text = "Payment Type : ";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Location = new System.Drawing.Point(11, 87);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(195, 26);
            this.comboBoxPaymentType.TabIndex = 10;
            this.comboBoxPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentType_SelectedIndexChanged);
            // 
            // labelPaymentStatus
            // 
            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.BackColor = System.Drawing.Color.DarkGray;
            this.labelPaymentStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentStatus.Location = new System.Drawing.Point(-2, 125);
            this.labelPaymentStatus.Name = "labelPaymentStatus";
            this.labelPaymentStatus.Size = new System.Drawing.Size(143, 20);
            this.labelPaymentStatus.TabIndex = 5;
            this.labelPaymentStatus.Text = "Payment Status : ";
            // 
            // textBoxPaymentStatus
            // 
            this.textBoxPaymentStatus.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaymentStatus.Location = new System.Drawing.Point(8, 148);
            this.textBoxPaymentStatus.Name = "textBoxPaymentStatus";
            this.textBoxPaymentStatus.ReadOnly = true;
            this.textBoxPaymentStatus.Size = new System.Drawing.Size(195, 24);
            this.textBoxPaymentStatus.TabIndex = 4;
            this.textBoxPaymentStatus.TextChanged += new System.EventHandler(this.textBoxPaymentStatus_TextChanged);
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.BackColor = System.Drawing.Color.DarkGray;
            this.labelPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMethod.Location = new System.Drawing.Point(-2, 9);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(151, 20);
            this.labelPaymentMethod.TabIndex = 1;
            this.labelPaymentMethod.Text = "Payment Method : ";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(11, 32);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(195, 26);
            this.comboBoxPaymentMethod.TabIndex = 0;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.labelTitleClientInfo);
            this.panel7.Controls.Add(this.labelTitleRentalInfo);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(6, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 489);
            this.panel7.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelComboBoxClientName);
            this.panel2.Controls.Add(this.labeltextBoxID);
            this.panel2.Controls.Add(this.comboBoxClientName);
            this.panel2.Controls.Add(this.textBoxNationalID);
            this.panel2.Location = new System.Drawing.Point(28, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 134);
            this.panel2.TabIndex = 4;
            // 
            // labelComboBoxClientName
            // 
            this.labelComboBoxClientName.AutoSize = true;
            this.labelComboBoxClientName.BackColor = System.Drawing.Color.DarkGray;
            this.labelComboBoxClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelComboBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComboBoxClientName.Location = new System.Drawing.Point(-2, 9);
            this.labelComboBoxClientName.Name = "labelComboBoxClientName";
            this.labelComboBoxClientName.Size = new System.Drawing.Size(117, 20);
            this.labelComboBoxClientName.TabIndex = 1;
            this.labelComboBoxClientName.Text = "Client Name : ";
            // 
            // labeltextBoxID
            // 
            this.labeltextBoxID.AutoSize = true;
            this.labeltextBoxID.BackColor = System.Drawing.Color.DarkGray;
            this.labeltextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeltextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltextBoxID.Location = new System.Drawing.Point(1, 77);
            this.labeltextBoxID.Name = "labeltextBoxID";
            this.labeltextBoxID.Size = new System.Drawing.Size(108, 20);
            this.labeltextBoxID.TabIndex = 3;
            this.labeltextBoxID.Text = "National ID : ";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(11, 32);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(195, 26);
            this.comboBoxClientName.TabIndex = 0;
            this.comboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientName_SelectedIndexChanged_1);
            // 
            // textBoxNationalID
            // 
            this.textBoxNationalID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNationalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNationalID.Location = new System.Drawing.Point(11, 100);
            this.textBoxNationalID.Name = "textBoxNationalID";
            this.textBoxNationalID.ReadOnly = true;
            this.textBoxNationalID.Size = new System.Drawing.Size(195, 24);
            this.textBoxNationalID.TabIndex = 2;
            this.textBoxNationalID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTitleClientInfo
            // 
            this.labelTitleClientInfo.BackColor = System.Drawing.Color.DimGray;
            this.labelTitleClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleClientInfo.Location = new System.Drawing.Point(27, 3);
            this.labelTitleClientInfo.Name = "labelTitleClientInfo";
            this.labelTitleClientInfo.Size = new System.Drawing.Size(185, 30);
            this.labelTitleClientInfo.TabIndex = 5;
            this.labelTitleClientInfo.Text = "Client Information";
            this.labelTitleClientInfo.Click += new System.EventHandler(this.labelTitleClientInfo_Click);
            // 
            // labelTitleRentalInfo
            // 
            this.labelTitleRentalInfo.BackColor = System.Drawing.Color.DimGray;
            this.labelTitleRentalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRentalInfo.Location = new System.Drawing.Point(27, 177);
            this.labelTitleRentalInfo.Name = "labelTitleRentalInfo";
            this.labelTitleRentalInfo.Size = new System.Drawing.Size(185, 30);
            this.labelTitleRentalInfo.TabIndex = 6;
            this.labelTitleRentalInfo.Text = "Rental Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBoxCurrentBlanace);
            this.panel3.Controls.Add(this.labelCurrentPrice);
            this.panel3.Controls.Add(this.labelTotalPrice);
            this.panel3.Controls.Add(this.TotalPrice);
            this.panel3.Controls.Add(this.labelReturnDate);
            this.panel3.Controls.Add(this.ReturnDate);
            this.panel3.Controls.Add(this.labelRentedCarPlate);
            this.panel3.Controls.Add(this.labelRentDate);
            this.panel3.Controls.Add(this.comboBoxRentedCarPlate);
            this.panel3.Controls.Add(this.RentDate);
            this.panel3.Location = new System.Drawing.Point(28, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 272);
            this.panel3.TabIndex = 5;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.DarkGray;
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(-5, 158);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(107, 20);
            this.labelTotalPrice.TabIndex = 7;
            this.labelTotalPrice.Text = "Total Price : ";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(5, 181);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(195, 24);
            this.TotalPrice.TabIndex = 6;
            this.TotalPrice.TextChanged += new System.EventHandler(this.TotalPrice_TextChanged);
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.BackColor = System.Drawing.Color.DarkGray;
            this.labelReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(-5, 109);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(115, 20);
            this.labelReturnDate.TabIndex = 5;
            this.labelReturnDate.Text = "Return Date : ";
            // 
            // ReturnDate
            // 
            this.ReturnDate.BackColor = System.Drawing.SystemColors.Info;
            this.ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Location = new System.Drawing.Point(5, 132);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Size = new System.Drawing.Size(195, 24);
            this.ReturnDate.TabIndex = 4;
            this.ReturnDate.TextChanged += new System.EventHandler(this.ReturnDate_TextChanged);
            // 
            // labelRentedCarPlate
            // 
            this.labelRentedCarPlate.AutoSize = true;
            this.labelRentedCarPlate.BackColor = System.Drawing.Color.DarkGray;
            this.labelRentedCarPlate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRentedCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentedCarPlate.Location = new System.Drawing.Point(-2, 9);
            this.labelRentedCarPlate.Name = "labelRentedCarPlate";
            this.labelRentedCarPlate.Size = new System.Drawing.Size(153, 20);
            this.labelRentedCarPlate.TabIndex = 1;
            this.labelRentedCarPlate.Text = "Rented Car Plate : ";
            // 
            // labelRentDate
            // 
            this.labelRentDate.AutoSize = true;
            this.labelRentDate.BackColor = System.Drawing.Color.DarkGray;
            this.labelRentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentDate.Location = new System.Drawing.Point(-2, 61);
            this.labelRentDate.Name = "labelRentDate";
            this.labelRentDate.Size = new System.Drawing.Size(100, 20);
            this.labelRentDate.TabIndex = 3;
            this.labelRentDate.Text = "Rent Date : ";
            // 
            // comboBoxRentedCarPlate
            // 
            this.comboBoxRentedCarPlate.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxRentedCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRentedCarPlate.FormattingEnabled = true;
            this.comboBoxRentedCarPlate.Location = new System.Drawing.Point(9, 32);
            this.comboBoxRentedCarPlate.Name = "comboBoxRentedCarPlate";
            this.comboBoxRentedCarPlate.Size = new System.Drawing.Size(195, 26);
            this.comboBoxRentedCarPlate.TabIndex = 0;
            this.comboBoxRentedCarPlate.SelectedIndexChanged += new System.EventHandler(this.comboBoxRentedCarPlate_SelectedIndexChanged_1);
            // 
            // RentDate
            // 
            this.RentDate.BackColor = System.Drawing.SystemColors.Info;
            this.RentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate.Location = new System.Drawing.Point(8, 84);
            this.RentDate.Name = "RentDate";
            this.RentDate.ReadOnly = true;
            this.RentDate.Size = new System.Drawing.Size(195, 24);
            this.RentDate.TabIndex = 2;
            this.RentDate.TextChanged += new System.EventHandler(this.RentDate_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.buttonBack);
            this.panel6.Controls.Add(this.buttonClear);
            this.panel6.Controls.Add(this.buttonSavePayment);
            this.panel6.Controls.Add(this.buttonCalRemaing);
            this.panel6.Location = new System.Drawing.Point(694, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 239);
            this.panel6.TabIndex = 10;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Silver;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(17, 183);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(211, 44);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Silver;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(17, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(211, 44);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonSavePayment
            // 
            this.buttonSavePayment.BackColor = System.Drawing.Color.Silver;
            this.buttonSavePayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSavePayment.Location = new System.Drawing.Point(17, 59);
            this.buttonSavePayment.Name = "buttonSavePayment";
            this.buttonSavePayment.Size = new System.Drawing.Size(211, 44);
            this.buttonSavePayment.TabIndex = 1;
            this.buttonSavePayment.Text = "Save Payment";
            this.buttonSavePayment.UseVisualStyleBackColor = false;
            this.buttonSavePayment.Click += new System.EventHandler(this.buttonSavePayment_Click_1);
            // 
            // buttonCalRemaing
            // 
            this.buttonCalRemaing.BackColor = System.Drawing.Color.Silver;
            this.buttonCalRemaing.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCalRemaing.Location = new System.Drawing.Point(17, 3);
            this.buttonCalRemaing.Name = "buttonCalRemaing";
            this.buttonCalRemaing.Size = new System.Drawing.Size(211, 44);
            this.buttonCalRemaing.TabIndex = 0;
            this.buttonCalRemaing.Text = "Calculate Remaining";
            this.buttonCalRemaing.UseVisualStyleBackColor = false;
            this.buttonCalRemaing.Click += new System.EventHandler(this.buttonCalRemaing_Click);
            // 
            // labelTitlePaymentHistory
            // 
            this.labelTitlePaymentHistory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitlePaymentHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitlePaymentHistory.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePaymentHistory.Location = new System.Drawing.Point(29, 9);
            this.labelTitlePaymentHistory.Name = "labelTitlePaymentHistory";
            this.labelTitlePaymentHistory.Size = new System.Drawing.Size(742, 75);
            this.labelTitlePaymentHistory.TabIndex = 1;
            this.labelTitlePaymentHistory.Text = " Payments History ";
            // 
            // pictureBoxPayment
            // 
            this.pictureBoxPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPayment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPayment.Image")));
            this.pictureBoxPayment.Location = new System.Drawing.Point(759, 9);
            this.pictureBoxPayment.Name = "pictureBoxPayment";
            this.pictureBoxPayment.Size = new System.Drawing.Size(262, 229);
            this.pictureBoxPayment.TabIndex = 2;
            this.pictureBoxPayment.TabStop = false;
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.BackColor = System.Drawing.Color.DarkGray;
            this.labelCurrentPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(-2, 208);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(125, 20);
            this.labelCurrentPrice.TabIndex = 13;
            this.labelCurrentPrice.Text = "Current Price : ";
            // 
            // textBoxCurrentBlanace
            // 
            this.textBoxCurrentBlanace.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCurrentBlanace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentBlanace.Location = new System.Drawing.Point(5, 231);
            this.textBoxCurrentBlanace.Name = "textBoxCurrentBlanace";
            this.textBoxCurrentBlanace.ReadOnly = true;
            this.textBoxCurrentBlanace.Size = new System.Drawing.Size(195, 24);
            this.textBoxCurrentBlanace.TabIndex = 13;
            this.textBoxCurrentBlanace.TextChanged += new System.EventHandler(this.textBoxCurrentBlanace_TextChanged);
            // 
            // Payments_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1032, 640);
            this.Controls.Add(this.pictureBoxPayment);
            this.Controls.Add(this.labelTitlePaymentHistory);
            this.Controls.Add(this.panel1);
            this.Name = "Payments_History";
            this.Text = "Payments_History";
            this.Load += new System.EventHandler(this.Payments_History_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitlePaymentHistory;
        private System.Windows.Forms.PictureBox pictureBoxPayment;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.Label labelComboBoxClientName;
        private System.Windows.Forms.Label labeltextBoxID;
        private System.Windows.Forms.TextBox textBoxNationalID;
        private System.Windows.Forms.Label labelTitleRentalInfo;
        private System.Windows.Forms.Label labelTitleClientInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.TextBox ReturnDate;
        private System.Windows.Forms.Label labelRentedCarPlate;
        private System.Windows.Forms.Label labelRentDate;
        private System.Windows.Forms.ComboBox comboBoxRentedCarPlate;
        private System.Windows.Forms.TextBox RentDate;
        private System.Windows.Forms.Label labelFinancalInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelRemaingAmount;
        private System.Windows.Forms.TextBox textBoxRemaingAmount;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPaymentStatus;
        private System.Windows.Forms.TextBox textBoxPaymentStatus;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelPaymentInfo;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSavePayment;
        private System.Windows.Forms.Button buttonCalRemaing;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.TextBox textBoxCurrentBlanace;
    }
}