namespace CarRentalSystem
{
    partial class RentCarsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCarsForm));
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.labelCarRentalInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBoxClientInfo = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDailyPrice = new System.Windows.Forms.Label();
            this.labelPlateNumber = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxDailyPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBoxPaymet = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.panelRentalPeriod = new System.Windows.Forms.Panel();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.labelRentDate = new System.Windows.Forms.Label();
            this.dateTimePickerRentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddRental = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCalTotal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBoxClientInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBoxPaymet.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            this.panelRentalPeriod.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(9, 37);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(174, 26);
            this.comboBoxClientName.TabIndex = 0;
            this.comboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientName_SelectedIndexChanged);
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(9, 104);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(174, 26);
            this.comboBoxCarModel.TabIndex = 1;
            this.comboBoxCarModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarModel_SelectedIndexChanged);
            // 
            // labelCarRentalInformation
            // 
            this.labelCarRentalInformation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelCarRentalInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCarRentalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCarRentalInformation.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelCarRentalInformation.Location = new System.Drawing.Point(0, 0);
            this.labelCarRentalInformation.Name = "labelCarRentalInformation";
            this.labelCarRentalInformation.Size = new System.Drawing.Size(1031, 67);
            this.labelCarRentalInformation.TabIndex = 2;
            this.labelCarRentalInformation.Text = "Car Rental Information";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 515);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.groupBoxClientInfo);
            this.panel10.Location = new System.Drawing.Point(5, 34);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(211, 226);
            this.panel10.TabIndex = 4;
            // 
            // groupBoxClientInfo
            // 
            this.groupBoxClientInfo.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxClientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxClientInfo.Controls.Add(this.panel3);
            this.groupBoxClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClientInfo.Location = new System.Drawing.Point(4, 13);
            this.groupBoxClientInfo.Name = "groupBoxClientInfo";
            this.groupBoxClientInfo.Size = new System.Drawing.Size(200, 190);
            this.groupBoxClientInfo.TabIndex = 6;
            this.groupBoxClientInfo.TabStop = false;
            this.groupBoxClientInfo.Text = "Client Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelClientID);
            this.panel3.Controls.Add(this.labelClientName);
            this.panel3.Controls.Add(this.comboBoxCarModel);
            this.panel3.Controls.Add(this.comboBoxClientName);
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 144);
            this.panel3.TabIndex = 8;
            // 
            // labelClientID
            // 
            this.labelClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientID.AutoSize = true;
            this.labelClientID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelClientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClientID.ForeColor = System.Drawing.Color.White;
            this.labelClientID.Location = new System.Drawing.Point(0, 81);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(156, 20);
            this.labelClientID.TabIndex = 3;
            this.labelClientID.Text = "Client National ID : ";
            this.labelClientID.Click += new System.EventHandler(this.labelClientID_Click);
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.White;
            this.labelClientName.Location = new System.Drawing.Point(0, 17);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(105, 18);
            this.labelClientName.TabIndex = 2;
            this.labelClientName.Text = "Client Name : ";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Location = new System.Drawing.Point(222, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(229, 308);
            this.panel9.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 276);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelDailyPrice);
            this.panel2.Controls.Add(this.labelPlateNumber);
            this.panel2.Controls.Add(this.labelModel);
            this.panel2.Controls.Add(this.textBoxDailyPrice);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBoxPlateNumber);
            this.panel2.Controls.Add(this.labelCarModel);
            this.panel2.Controls.Add(this.textBoxCarModel);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 233);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelDailyPrice
            // 
            this.labelDailyPrice.AutoSize = true;
            this.labelDailyPrice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDailyPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDailyPrice.ForeColor = System.Drawing.Color.White;
            this.labelDailyPrice.Location = new System.Drawing.Point(-1, 176);
            this.labelDailyPrice.Name = "labelDailyPrice";
            this.labelDailyPrice.Size = new System.Drawing.Size(106, 20);
            this.labelDailyPrice.TabIndex = 7;
            this.labelDailyPrice.Text = "Daily Price : ";
            this.labelDailyPrice.Click += new System.EventHandler(this.labelDailyPrice_Click);
            // 
            // labelPlateNumber
            // 
            this.labelPlateNumber.AutoSize = true;
            this.labelPlateNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPlateNumber.ForeColor = System.Drawing.Color.White;
            this.labelPlateNumber.Location = new System.Drawing.Point(-5, 125);
            this.labelPlateNumber.Name = "labelPlateNumber";
            this.labelPlateNumber.Size = new System.Drawing.Size(127, 20);
            this.labelPlateNumber.TabIndex = 6;
            this.labelPlateNumber.Text = "Plate Number : ";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelModel.ForeColor = System.Drawing.Color.White;
            this.labelModel.Location = new System.Drawing.Point(-1, 70);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(103, 20);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "Car Model : ";
            // 
            // textBoxDailyPrice
            // 
            this.textBoxDailyPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDailyPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxDailyPrice.Location = new System.Drawing.Point(15, 197);
            this.textBoxDailyPrice.Name = "textBoxDailyPrice";
            this.textBoxDailyPrice.ReadOnly = true;
            this.textBoxDailyPrice.Size = new System.Drawing.Size(160, 24);
            this.textBoxDailyPrice.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPlateNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxPlateNumber.Location = new System.Drawing.Point(15, 146);
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.ReadOnly = true;
            this.textBoxPlateNumber.Size = new System.Drawing.Size(160, 24);
            this.textBoxPlateNumber.TabIndex = 3;
            this.textBoxPlateNumber.TextChanged += new System.EventHandler(this.textBoxPlateNumber_TextChanged);
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelCarModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarModel.ForeColor = System.Drawing.Color.White;
            this.labelCarModel.Location = new System.Drawing.Point(-5, 17);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(93, 18);
            this.labelCarModel.TabIndex = 1;
            this.labelCarModel.Text = "Select Car : ";
            this.labelCarModel.Click += new System.EventHandler(this.labelCarModel_Click);
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCarModel.ForeColor = System.Drawing.Color.White;
            this.textBoxCarModel.Location = new System.Drawing.Point(15, 91);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.ReadOnly = true;
            this.textBoxCarModel.Size = new System.Drawing.Size(160, 24);
            this.textBoxCarModel.TabIndex = 2;
            this.textBoxCarModel.TextChanged += new System.EventHandler(this.textBoxCarModel_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.groupBoxPaymet);
            this.panel8.Location = new System.Drawing.Point(4, 276);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(212, 168);
            this.panel8.TabIndex = 16;
            // 
            // groupBoxPaymet
            // 
            this.groupBoxPaymet.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxPaymet.Controls.Add(this.panel4);
            this.groupBoxPaymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPaymet.Location = new System.Drawing.Point(3, 13);
            this.groupBoxPaymet.Name = "groupBoxPaymet";
            this.groupBoxPaymet.Size = new System.Drawing.Size(200, 138);
            this.groupBoxPaymet.TabIndex = 8;
            this.groupBoxPaymet.TabStop = false;
            this.groupBoxPaymet.Text = "Payments";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBoxTotalPrice);
            this.panel4.Controls.Add(this.labelTotalPrice);
            this.panel4.Location = new System.Drawing.Point(0, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 101);
            this.panel4.TabIndex = 0;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(15, 34);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 24);
            this.textBoxTotalPrice.TabIndex = 1;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(-2, 14);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(97, 18);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "Total Price : ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.groupBoxPeriod);
            this.panel7.Location = new System.Drawing.Point(457, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(323, 234);
            this.panel7.TabIndex = 15;
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxPeriod.Controls.Add(this.panelRentalPeriod);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(3, 13);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(313, 193);
            this.groupBoxPeriod.TabIndex = 9;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Rental Period";
            // 
            // panelRentalPeriod
            // 
            this.panelRentalPeriod.BackColor = System.Drawing.SystemColors.Info;
            this.panelRentalPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRentalPeriod.Controls.Add(this.labelReturnDate);
            this.panelRentalPeriod.Controls.Add(this.labelRentDate);
            this.panelRentalPeriod.Controls.Add(this.dateTimePickerRentDate);
            this.panelRentalPeriod.Controls.Add(this.dateTimePickerReturnDate);
            this.panelRentalPeriod.Location = new System.Drawing.Point(0, 18);
            this.panelRentalPeriod.Name = "panelRentalPeriod";
            this.panelRentalPeriod.Size = new System.Drawing.Size(313, 146);
            this.panelRentalPeriod.TabIndex = 0;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelReturnDate.Location = new System.Drawing.Point(-1, 81);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(113, 18);
            this.labelReturnDate.TabIndex = 4;
            this.labelReturnDate.Text = "Return Date : ";
            // 
            // labelRentDate
            // 
            this.labelRentDate.AutoSize = true;
            this.labelRentDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelRentDate.Location = new System.Drawing.Point(-2, 1);
            this.labelRentDate.Name = "labelRentDate";
            this.labelRentDate.Size = new System.Drawing.Size(93, 18);
            this.labelRentDate.TabIndex = 3;
            this.labelRentDate.Text = "RentDate : ";
            // 
            // dateTimePickerRentDate
            // 
            this.dateTimePickerRentDate.Location = new System.Drawing.Point(5, 22);
            this.dateTimePickerRentDate.Name = "dateTimePickerRentDate";
            this.dateTimePickerRentDate.Size = new System.Drawing.Size(301, 24);
            this.dateTimePickerRentDate.TabIndex = 2;
            this.dateTimePickerRentDate.ValueChanged += new System.EventHandler(this.dateTimePickerRentDate_ValueChanged);
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(5, 103);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(301, 24);
            this.dateTimePickerReturnDate.TabIndex = 0;
            this.dateTimePickerReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerRetuenDate_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Location = new System.Drawing.Point(291, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 151);
            this.panel5.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.buttonClear);
            this.panel11.Controls.Add(this.buttonAddRental);
            this.panel11.Controls.Add(this.buttonBack);
            this.panel11.Controls.Add(this.buttonCalTotal);
            this.panel11.Location = new System.Drawing.Point(22, 10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(375, 128);
            this.panel11.TabIndex = 18;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(200, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 44);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddRental
            // 
            this.buttonAddRental.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddRental.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonAddRental.Location = new System.Drawing.Point(12, 67);
            this.buttonAddRental.Name = "buttonAddRental";
            this.buttonAddRental.Size = new System.Drawing.Size(159, 44);
            this.buttonAddRental.TabIndex = 10;
            this.buttonAddRental.Text = "Add Rental";
            this.buttonAddRental.UseVisualStyleBackColor = false;
            this.buttonAddRental.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(200, 67);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(159, 44);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // buttonCalTotal
            // 
            this.buttonCalTotal.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCalTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalTotal.Location = new System.Drawing.Point(12, 12);
            this.buttonCalTotal.Name = "buttonCalTotal";
            this.buttonCalTotal.Size = new System.Drawing.Size(159, 44);
            this.buttonCalTotal.TabIndex = 9;
            this.buttonCalTotal.Text = "Calculate Total";
            this.buttonCalTotal.UseVisualStyleBackColor = false;
            this.buttonCalTotal.Click += new System.EventHandler(this.buttonCalTotal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 409);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(793, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 429);
            this.panel6.TabIndex = 19;
            // 
            // RentCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1031, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCarRentalInformation);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RentCarsForm";
            this.Text = "RentCarsForm";
            this.Load += new System.EventHandler(this.RentCarsForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.groupBoxClientInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBoxPaymet.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBoxPeriod.ResumeLayout(false);
            this.panelRentalPeriod.ResumeLayout(false);
            this.panelRentalPeriod.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.Label labelCarRentalInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBoxClientInfo;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxDailyPrice;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPlateNumber;
        private System.Windows.Forms.Label labelDailyPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddRental;
        private System.Windows.Forms.Button buttonCalTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.Panel panelRentalPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.GroupBox groupBoxPaymet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelRentDate;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
    }
}