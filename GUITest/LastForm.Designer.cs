namespace GUITest
{
    partial class Ydelser
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
            this.UnitRateButt = new System.Windows.Forms.Button();
            this.UnitCombo = new System.Windows.Forms.ComboBox();
            this.UnitRate = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.MakeNewServBut = new System.Windows.Forms.Button();
            this.MkServiceFixPr = new System.Windows.Forms.TextBox();
            this.MkServiceTime = new System.Windows.Forms.TextBox();
            this.MkServiceHours = new System.Windows.Forms.TextBox();
            this.MkServiceName = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.UpdateServButt = new System.Windows.Forms.Button();
            this.DeleteServButt = new System.Windows.Forms.Button();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitRateButt
            // 
            this.UnitRateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitRateButt.Location = new System.Drawing.Point(1102, 254);
            this.UnitRateButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnitRateButt.Name = "UnitRateButt";
            this.UnitRateButt.Size = new System.Drawing.Size(152, 44);
            this.UnitRateButt.TabIndex = 276;
            this.UnitRateButt.Text = "Unit";
            this.UnitRateButt.UseVisualStyleBackColor = true;
            // 
            // UnitCombo
            // 
            this.UnitCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitCombo.FormattingEnabled = true;
            this.UnitCombo.Location = new System.Drawing.Point(1102, 135);
            this.UnitCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnitCombo.Name = "UnitCombo";
            this.UnitCombo.Size = new System.Drawing.Size(152, 28);
            this.UnitCombo.TabIndex = 275;
            // 
            // UnitRate
            // 
            this.UnitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitRate.Location = new System.Drawing.Point(1102, 200);
            this.UnitRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnitRate.Name = "UnitRate";
            this.UnitRate.Size = new System.Drawing.Size(152, 27);
            this.UnitRate.TabIndex = 274;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(1102, 172);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 20);
            this.label56.TabIndex = 273;
            this.label56.Text = "Rate";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(1102, 107);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 20);
            this.label55.TabIndex = 272;
            this.label55.Text = "Name";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(1098, 70);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(82, 20);
            this.label54.TabIndex = 271;
            this.label54.Text = "UnitRate";
            // 
            // MakeNewServBut
            // 
            this.MakeNewServBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeNewServBut.Location = new System.Drawing.Point(78, 341);
            this.MakeNewServBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MakeNewServBut.Name = "MakeNewServBut";
            this.MakeNewServBut.Size = new System.Drawing.Size(152, 44);
            this.MakeNewServBut.TabIndex = 270;
            this.MakeNewServBut.Text = "Ny Service";
            this.MakeNewServBut.UseVisualStyleBackColor = true;
            this.MakeNewServBut.Click += new System.EventHandler(this.MakeNewServBut_Click);
            // 
            // MkServiceFixPr
            // 
            this.MkServiceFixPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkServiceFixPr.Location = new System.Drawing.Point(15, 287);
            this.MkServiceFixPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MkServiceFixPr.Name = "MkServiceFixPr";
            this.MkServiceFixPr.Size = new System.Drawing.Size(215, 27);
            this.MkServiceFixPr.TabIndex = 269;
            // 
            // MkServiceTime
            // 
            this.MkServiceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkServiceTime.Location = new System.Drawing.Point(15, 224);
            this.MkServiceTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MkServiceTime.Name = "MkServiceTime";
            this.MkServiceTime.Size = new System.Drawing.Size(215, 27);
            this.MkServiceTime.TabIndex = 268;
            // 
            // MkServiceHours
            // 
            this.MkServiceHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkServiceHours.Location = new System.Drawing.Point(15, 161);
            this.MkServiceHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MkServiceHours.Name = "MkServiceHours";
            this.MkServiceHours.Size = new System.Drawing.Size(215, 27);
            this.MkServiceHours.TabIndex = 267;
            // 
            // MkServiceName
            // 
            this.MkServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkServiceName.Location = new System.Drawing.Point(15, 98);
            this.MkServiceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MkServiceName.Name = "MkServiceName";
            this.MkServiceName.Size = new System.Drawing.Size(215, 27);
            this.MkServiceName.TabIndex = 266;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(15, 196);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(117, 20);
            this.label53.TabIndex = 265;
            this.label53.Text = "TimeEstimate:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(15, 259);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(98, 20);
            this.label50.TabIndex = 264;
            this.label50.Text = "Fixed Price:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(15, 70);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(116, 20);
            this.label49.TabIndex = 263;
            this.label49.Text = "Service name:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(21, 31);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(128, 20);
            this.label48.TabIndex = 262;
            this.label48.Text = "LegalServices";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(15, 133);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(131, 20);
            this.label47.TabIndex = 261;
            this.label47.Text = "Hours Estimate:";
            // 
            // UpdateServButt
            // 
            this.UpdateServButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateServButt.Location = new System.Drawing.Point(78, 413);
            this.UpdateServButt.Name = "UpdateServButt";
            this.UpdateServButt.Size = new System.Drawing.Size(152, 44);
            this.UpdateServButt.TabIndex = 277;
            this.UpdateServButt.Text = "Update";
            this.UpdateServButt.UseVisualStyleBackColor = true;
            this.UpdateServButt.Click += new System.EventHandler(this.UpdateServButt_Click);
            // 
            // DeleteServButt
            // 
            this.DeleteServButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteServButt.Location = new System.Drawing.Point(78, 485);
            this.DeleteServButt.Name = "DeleteServButt";
            this.DeleteServButt.Size = new System.Drawing.Size(152, 44);
            this.DeleteServButt.TabIndex = 278;
            this.DeleteServButt.Text = "Slet";
            this.DeleteServButt.UseVisualStyleBackColor = true;
            this.DeleteServButt.Click += new System.EventHandler(this.DeleteServButt_Click);
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ServiceName,
            this.Hours,
            this.Time,
            this.Price});
            this.ServiceGridView.Location = new System.Drawing.Point(263, 98);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowTemplate.Height = 24;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(661, 150);
            this.ServiceGridView.TabIndex = 279;
            this.ServiceGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceGridView_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours Estimate";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time Estimate";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Fixed Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Ydelser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 791);
            this.Controls.Add(this.ServiceGridView);
            this.Controls.Add(this.DeleteServButt);
            this.Controls.Add(this.UpdateServButt);
            this.Controls.Add(this.UnitRateButt);
            this.Controls.Add(this.UnitCombo);
            this.Controls.Add(this.UnitRate);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.MakeNewServBut);
            this.Controls.Add(this.MkServiceFixPr);
            this.Controls.Add(this.MkServiceTime);
            this.Controls.Add(this.MkServiceHours);
            this.Controls.Add(this.MkServiceName);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Name = "Ydelser";
            this.Text = "Ydelser";
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnitRateButt;
        private System.Windows.Forms.ComboBox UnitCombo;
        private System.Windows.Forms.TextBox UnitRate;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button MakeNewServBut;
        private System.Windows.Forms.TextBox MkServiceFixPr;
        private System.Windows.Forms.TextBox MkServiceTime;
        private System.Windows.Forms.TextBox MkServiceHours;
        private System.Windows.Forms.TextBox MkServiceName;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button UpdateServButt;
        private System.Windows.Forms.Button DeleteServButt;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}