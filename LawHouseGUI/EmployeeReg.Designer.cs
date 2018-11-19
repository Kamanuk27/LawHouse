namespace LawHouseGUI
{
    partial class EmployeeReg
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
            this.add_info_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efternavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_name = new System.Windows.Forms.Label();
            this.change_spes = new System.Windows.Forms.Button();
            this.add_spes = new System.Windows.Forms.Button();
            this.change_Employee = new System.Windows.Forms.Button();
            this.new_Employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_info_button
            // 
            this.add_info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_info_button.Location = new System.Drawing.Point(205, 502);
            this.add_info_button.Name = "add_info_button";
            this.add_info_button.Size = new System.Drawing.Size(99, 33);
            this.add_info_button.TabIndex = 35;
            this.add_info_button.Text = "Tilføj";
            this.add_info_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vedlæg  dokument for afsluttet udd.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titel,
            this.Fornavn,
            this.Efternavn,
            this.Speciale});
            this.dataGridView1.Location = new System.Drawing.Point(436, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 466);
            this.dataGridView1.TabIndex = 31;
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            // 
            // Fornavn
            // 
            this.Fornavn.HeaderText = "Fornavn";
            this.Fornavn.Name = "Fornavn";
            this.Fornavn.ReadOnly = true;
            // 
            // Efternavn
            // 
            this.Efternavn.HeaderText = "Efternavn";
            this.Efternavn.Name = "Efternavn";
            this.Efternavn.ReadOnly = true;
            // 
            // Speciale
            // 
            this.Speciale.HeaderText = "Spesiale";
            this.Speciale.Name = "Speciale";
            this.Speciale.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ansatte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tilføj spesialer";
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_name.Location = new System.Drawing.Point(64, 309);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(85, 29);
            this.login_name.TabIndex = 28;
            this.login_name.Text = "label1";
            // 
            // change_spes
            // 
            this.change_spes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_spes.Location = new System.Drawing.Point(69, 216);
            this.change_spes.Name = "change_spes";
            this.change_spes.Size = new System.Drawing.Size(181, 26);
            this.change_spes.TabIndex = 27;
            this.change_spes.Text = "Rediger spesiale";
            this.change_spes.UseVisualStyleBackColor = true;
            // 
            // add_spes
            // 
            this.add_spes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_spes.Location = new System.Drawing.Point(69, 173);
            this.add_spes.Name = "add_spes";
            this.add_spes.Size = new System.Drawing.Size(181, 26);
            this.add_spes.TabIndex = 26;
            this.add_spes.Text = "Tilføj speciale";
            this.add_spes.UseVisualStyleBackColor = true;
            // 
            // change_Employee
            // 
            this.change_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_Employee.Location = new System.Drawing.Point(69, 131);
            this.change_Employee.Name = "change_Employee";
            this.change_Employee.Size = new System.Drawing.Size(181, 26);
            this.change_Employee.TabIndex = 25;
            this.change_Employee.Text = "Rediger kollega";
            this.change_Employee.UseVisualStyleBackColor = true;
            // 
            // new_Employee
            // 
            this.new_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Employee.Location = new System.Drawing.Point(69, 90);
            this.new_Employee.Name = "new_Employee";
            this.new_Employee.Size = new System.Drawing.Size(181, 26);
            this.new_Employee.TabIndex = 24;
            this.new_Employee.Text = "Tilføj ny kollega";
            this.new_Employee.UseVisualStyleBackColor = true;
            // 
            // EmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 747);
            this.Controls.Add(this.add_info_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.change_spes);
            this.Controls.Add(this.add_spes);
            this.Controls.Add(this.change_Employee);
            this.Controls.Add(this.new_Employee);
            this.Name = "EmployeeReg";
            this.Text = "EmployeeReg";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_info_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efternavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.Button change_spes;
        private System.Windows.Forms.Button add_spes;
        private System.Windows.Forms.Button change_Employee;
        private System.Windows.Forms.Button new_Employee;
    }
}