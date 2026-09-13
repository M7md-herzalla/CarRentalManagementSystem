namespace CarRentalSystem
{
    partial class RentalRecords
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
            this.dgvRentalRecords = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNationalID = new System.Windows.Forms.TextBox();
            this.labelNationalID = new System.Windows.Forms.Label();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.comboBoxSearchClient = new System.Windows.Forms.ComboBox();
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinishRental = new System.Windows.Forms.Button();
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.labelTittleRentalRecords = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRentalRecords
            // 
            this.dgvRentalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalRecords.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRentalRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRentalRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecords.Location = new System.Drawing.Point(12, 85);
            this.dgvRentalRecords.Name = "dgvRentalRecords";
            this.dgvRentalRecords.RowHeadersWidth = 51;
            this.dgvRentalRecords.RowTemplate.Height = 24;
            this.dgvRentalRecords.Size = new System.Drawing.Size(1008, 289);
            this.dgvRentalRecords.TabIndex = 0;
            this.dgvRentalRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalRecords_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 265);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxNationalID);
            this.panel2.Controls.Add(this.labelNationalID);
            this.panel2.Controls.Add(this.labelSearchClient);
            this.panel2.Controls.Add(this.comboBoxSearchClient);
            this.panel2.Controls.Add(this.btnSearchRecord);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 232);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // textBoxNationalID
            // 
            this.textBoxNationalID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNationalID.Location = new System.Drawing.Point(16, 100);
            this.textBoxNationalID.Name = "textBoxNationalID";
            this.textBoxNationalID.ReadOnly = true;
            this.textBoxNationalID.Size = new System.Drawing.Size(201, 24);
            this.textBoxNationalID.TabIndex = 5;
            this.textBoxNationalID.TextChanged += new System.EventHandler(this.textBoxNationalID_TextChanged);
            // 
            // labelNationalID
            // 
            this.labelNationalID.AutoSize = true;
            this.labelNationalID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNationalID.Location = new System.Drawing.Point(0, 79);
            this.labelNationalID.Name = "labelNationalID";
            this.labelNationalID.Size = new System.Drawing.Size(106, 18);
            this.labelNationalID.TabIndex = 4;
            this.labelNationalID.Text = "National ID : ";
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelSearchClient.Location = new System.Drawing.Point(0, 18);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(124, 18);
            this.labelSearchClient.TabIndex = 3;
            this.labelSearchClient.Text = "Search Client : ";
            this.labelSearchClient.Click += new System.EventHandler(this.labelSearchClient_Click);
            // 
            // comboBoxSearchClient
            // 
            this.comboBoxSearchClient.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSearchClient.FormattingEnabled = true;
            this.comboBoxSearchClient.Location = new System.Drawing.Point(16, 39);
            this.comboBoxSearchClient.Name = "comboBoxSearchClient";
            this.comboBoxSearchClient.Size = new System.Drawing.Size(201, 26);
            this.comboBoxSearchClient.TabIndex = 2;
            this.comboBoxSearchClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchClient_SelectedIndexChanged);
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.BackColor = System.Drawing.Color.DimGray;
            this.btnSearchRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearchRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchRecord.Location = new System.Drawing.Point(344, 164);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(182, 49);
            this.btnSearchRecord.TabIndex = 1;
            this.btnSearchRecord.Text = "Search Record";
            this.btnSearchRecord.UseVisualStyleBackColor = false;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(70, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(140, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnFinishRental
            // 
            this.btnFinishRental.BackColor = System.Drawing.Color.DarkGray;
            this.btnFinishRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFinishRental.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinishRental.Location = new System.Drawing.Point(137, 18);
            this.btnFinishRental.Name = "btnFinishRental";
            this.btnFinishRental.Size = new System.Drawing.Size(182, 49);
            this.btnFinishRental.TabIndex = 2;
            this.btnFinishRental.Text = "Finish Rental";
            this.btnFinishRental.UseVisualStyleBackColor = false;
            this.btnFinishRental.Click += new System.EventHandler(this.btnFinishRental_Click_1);
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.BackColor = System.Drawing.Color.DarkGray;
            this.btnLoadRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLoadRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadRecords.Location = new System.Drawing.Point(70, 79);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(182, 49);
            this.btnLoadRecords.TabIndex = 0;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click);
            // 
            // labelTittleRentalRecords
            // 
            this.labelTittleRentalRecords.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTittleRentalRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTittleRentalRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittleRentalRecords.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelTittleRentalRecords.Location = new System.Drawing.Point(0, 0);
            this.labelTittleRentalRecords.Name = "labelTittleRentalRecords";
            this.labelTittleRentalRecords.Size = new System.Drawing.Size(1032, 67);
            this.labelTittleRentalRecords.TabIndex = 2;
            this.labelTittleRentalRecords.Text = "Rental Records";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnFinishRental);
            this.panel3.Controls.Add(this.btnLoadRecords);
            this.panel3.Location = new System.Drawing.Point(619, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 265);
            this.panel3.TabIndex = 3;
            // 
            // RentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1032, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelTittleRentalRecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRentalRecords);
            this.Name = "RentalRecords";
            this.Text = "ViewRentsCars";
            this.Load += new System.EventHandler(this.RentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentalRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTittleRentalRecords;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinishRental;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSearchClient;
        private System.Windows.Forms.ComboBox comboBoxSearchClient;
        private System.Windows.Forms.Label labelNationalID;
        private System.Windows.Forms.TextBox textBoxNationalID;
    }
}