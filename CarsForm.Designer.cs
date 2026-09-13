namespace CarRentalSystem
{
    partial class CarsForm
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
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadCars = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelPlateNumber = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCarType = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelTittle = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrand.Location = new System.Drawing.Point(21, 55);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(153, 35);
            this.textBoxBrand.TabIndex = 0;
            this.textBoxBrand.TextChanged += new System.EventHandler(this.textBoxBrand_TextChanged);
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "Classic",
            "Sport",
            "Luxury",
            "4x4",
            "Eco",
            "Family"});
            this.comboBoxCarType.Location = new System.Drawing.Point(16, 113);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(163, 26);
            this.comboBoxCarType.TabIndex = 1;
            this.comboBoxCarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarType_SelectedIndexChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(21, 170);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(153, 37);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(233, 53);
            this.textBoxColor.Multiline = true;
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(153, 37);
            this.textBoxColor.TabIndex = 3;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlateNumber.Location = new System.Drawing.Point(20, 237);
            this.textBoxPlateNumber.Multiline = true;
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(153, 37);
            this.textBoxPlateNumber.TabIndex = 4;
            this.textBoxPlateNumber.TextChanged += new System.EventHandler(this.textBoxPlateNumber_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(233, 132);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(153, 37);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Maintenance"});
            this.comboBoxStatus.Location = new System.Drawing.Point(233, 203);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(165, 26);
            this.comboBoxStatus.TabIndex = 6;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(450, 12);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(988, 291);
            this.dgvCars.TabIndex = 7;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(152, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(343, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 49);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(538, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(152, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 49);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(343, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 49);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadCars
            // 
            this.btnLoadCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCars.BackColor = System.Drawing.Color.DimGray;
            this.btnLoadCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCars.Location = new System.Drawing.Point(538, 109);
            this.btnLoadCars.Name = "btnLoadCars";
            this.btnLoadCars.Size = new System.Drawing.Size(149, 49);
            this.btnLoadCars.TabIndex = 13;
            this.btnLoadCars.Text = "Load Cars";
            this.btnLoadCars.UseVisualStyleBackColor = false;
            this.btnLoadCars.Click += new System.EventHandler(this.btnLoadCars_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(5, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 49);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelPlateNumber
            // 
            this.labelPlateNumber.AutoSize = true;
            this.labelPlateNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlateNumber.Location = new System.Drawing.Point(11, 216);
            this.labelPlateNumber.Name = "labelPlateNumber";
            this.labelPlateNumber.Size = new System.Drawing.Size(125, 18);
            this.labelPlateNumber.TabIndex = 15;
            this.labelPlateNumber.Text = "Plate Number : ";
            this.labelPlateNumber.Click += new System.EventHandler(this.labelPlateNumber_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(217, 112);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(94, 18);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Car Price : ";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(15, 36);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(99, 18);
            this.labelBrand.TabIndex = 17;
            this.labelBrand.Text = "Car Brand : ";
            this.labelBrand.Click += new System.EventHandler(this.labelBrand_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(217, 34);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(97, 18);
            this.labelColor.TabIndex = 18;
            this.labelColor.Text = "Car Color : ";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(10, 150);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(101, 18);
            this.labelModel.TabIndex = 19;
            this.labelModel.Text = "Car Model : ";
            this.labelModel.Click += new System.EventHandler(this.labelModel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCarType);
            this.panel1.Controls.Add(this.textBoxBrand);
            this.panel1.Controls.Add(this.comboBoxCarType);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelModel);
            this.panel1.Controls.Add(this.textBoxYear);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.textBoxColor);
            this.panel1.Controls.Add(this.labelBrand);
            this.panel1.Controls.Add(this.textBoxPlateNumber);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPlateNumber);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(20, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 409);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Car Status : ";
            // 
            // labelCarType
            // 
            this.labelCarType.AutoSize = true;
            this.labelCarType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarType.Location = new System.Drawing.Point(10, 94);
            this.labelCarType.Name = "labelCarType";
            this.labelCarType.Size = new System.Drawing.Size(91, 18);
            this.labelCarType.TabIndex = 20;
            this.labelCarType.Text = "Car Type : ";
            this.labelCarType.Click += new System.EventHandler(this.labelCarType_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(22, 17);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(289, 59);
            this.labelTittle.TabIndex = 20;
            this.labelTittle.Text = "Manage Cars";
            this.labelTittle.Click += new System.EventHandler(this.labelTittle_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.btnUpdate);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnLoadCars);
            this.panelButtons.Controls.Add(this.btnSearch);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Location = new System.Drawing.Point(93, 13);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(808, 201);
            this.panelButtons.TabIndex = 22;
            this.panelButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelButtons_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panelButtons);
            this.panel2.Location = new System.Drawing.Point(450, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 235);
            this.panel2.TabIndex = 23;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1450, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadCars;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelPlateNumber;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelCarType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}