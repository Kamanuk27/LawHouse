namespace LawHouseGUI
{
    partial class CaseCrud
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            this.CalculatePriceBt = new System.Windows.Forms.Button();
            this.EndCaseTimePictbx = new System.Windows.Forms.DateTimePicker();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.RespEmpCbx = new System.Windows.Forms.ComboBox();
            this.CloseCaseBut = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalPricetbx = new System.Windows.Forms.TextBox();
            this.NegPricetbx = new System.Windows.Forms.TextBox();
            this.UpdateBut = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculatePriceBt
            // 
            this.CalculatePriceBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatePriceBt.Location = new System.Drawing.Point(528, 60);
            this.CalculatePriceBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculatePriceBt.Name = "CalculatePriceBt";
            this.CalculatePriceBt.Size = new System.Drawing.Size(105, 44);
            this.CalculatePriceBt.TabIndex = 137;
            this.CalculatePriceBt.Text = "Beregn pris";
            this.CalculatePriceBt.UseVisualStyleBackColor = true;
            this.CalculatePriceBt.Click += new System.EventHandler(this.CalculatePriceBt_Click);
            // 
            // EndCaseTimePictbx
            // 
            this.EndCaseTimePictbx.Location = new System.Drawing.Point(487, 1);
            this.EndCaseTimePictbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndCaseTimePictbx.Name = "EndCaseTimePictbx";
            this.EndCaseTimePictbx.Size = new System.Drawing.Size(146, 22);
            this.EndCaseTimePictbx.TabIndex = 136;
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBut.Location = new System.Drawing.Point(31, 63);
            this.DeleteBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(109, 46);
            this.DeleteBut.TabIndex = 135;
            this.DeleteBut.Text = "Slet sagen";
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // RespEmpCbx
            // 
            this.RespEmpCbx.FormattingEnabled = true;
            this.RespEmpCbx.Location = new System.Drawing.Point(139, 4);
            this.RespEmpCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RespEmpCbx.Name = "RespEmpCbx";
            this.RespEmpCbx.Size = new System.Drawing.Size(159, 24);
            this.RespEmpCbx.TabIndex = 134;
            // 
            // CloseCaseBut
            // 
            this.CloseCaseBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CloseCaseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseCaseBut.Location = new System.Drawing.Point(370, 60);
            this.CloseCaseBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseCaseBut.Name = "CloseCaseBut";
            this.CloseCaseBut.Size = new System.Drawing.Size(109, 44);
            this.CloseCaseBut.TabIndex = 133;
            this.CloseCaseBut.Text = "Afslut sag";
            this.CloseCaseBut.UseVisualStyleBackColor = false;
            this.CloseCaseBut.Click += new System.EventHandler(this.CloseCaseBut_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 132;
            this.label13.Text = "Slut Dato:";
            // 
            // TotalPricetbx
            // 
            this.TotalPricetbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPricetbx.Location = new System.Drawing.Point(484, 29);
            this.TotalPricetbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalPricetbx.Name = "TotalPricetbx";
            this.TotalPricetbx.Size = new System.Drawing.Size(149, 27);
            this.TotalPricetbx.TabIndex = 131;
            // 
            // NegPricetbx
            // 
            this.NegPricetbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegPricetbx.Location = new System.Drawing.Point(139, 32);
            this.NegPricetbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NegPricetbx.Name = "NegPricetbx";
            this.NegPricetbx.Size = new System.Drawing.Size(159, 27);
            this.NegPricetbx.TabIndex = 130;
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBut.Location = new System.Drawing.Point(181, 63);
            this.UpdateBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(117, 46);
            this.UpdateBut.TabIndex = 126;
            this.UpdateBut.Text = "Opdatere sagen";
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(387, 33);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(73, 20);
            label11.TabIndex = 129;
            label11.Text = "Slut Pris";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(5, 13);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 20);
            label8.TabIndex = 128;
            label8.Text = "Advokat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(5, 37);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 20);
            label7.TabIndex = 127;
            label7.Text = "Aftalt/fast pris:";
            // 
            // CaseCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalculatePriceBt);
            this.Controls.Add(this.EndCaseTimePictbx);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.RespEmpCbx);
            this.Controls.Add(this.CloseCaseBut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TotalPricetbx);
            this.Controls.Add(this.NegPricetbx);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(label11);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Name = "CaseCrud";
            this.Size = new System.Drawing.Size(650, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculatePriceBt;
        private System.Windows.Forms.DateTimePicker EndCaseTimePictbx;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.ComboBox RespEmpCbx;
        private System.Windows.Forms.Button CloseCaseBut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TotalPricetbx;
        private System.Windows.Forms.TextBox NegPricetbx;
        private System.Windows.Forms.Button UpdateBut;
    }
}
