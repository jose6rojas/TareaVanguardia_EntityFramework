namespace EntityFrameworkCRUDApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(15, 25);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(237, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(15, 299);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.City});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCostumer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCostumer.Location = new System.Drawing.Point(268, 12);
            this.dgvCostumer.Name = "dgvCostumer";
            this.dgvCostumer.ReadOnly = true;
            this.dgvCostumer.RowTemplate.Height = 30;
            this.dgvCostumer.Size = new System.Drawing.Size(350, 300);
            this.dgvCostumer.TabIndex = 3;
            this.dgvCostumer.DoubleClick += new System.EventHandler(this.dgvCostumer_DoubleClick);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(15, 74);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(237, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(15, 123);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(237, 20);
            this.tbCity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(15, 176);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(237, 107);
            this.tbAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(96, 299);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(177, 299);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CostumerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 336);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCostumer);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Entity Framework - CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}

