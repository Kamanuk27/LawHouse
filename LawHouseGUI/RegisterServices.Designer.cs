namespace LawHouseGUI
{
    partial class RegisterServices
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.InsertCaseIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.CaseIDtxb = new System.Windows.Forms.TextBox();
            this.CaseNametxb = new System.Windows.Forms.TextBox();
            this.Clienttxt = new System.Windows.Forms.TextBox();
            this.ResoEmptxt = new System.Windows.Forms.TextBox();
            this.Servicetxt = new System.Windows.Forms.TextBox();
            this.StartDatetxt = new System.Windows.Forms.TextBox();
            this.EndDatetxt = new System.Windows.Forms.TextBox();
            this.NegPricetxt = new System.Windows.Forms.TextBox();
            this.TotalPricetxt = new System.Windows.Forms.TextBox();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Case_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertCaseIDtxt
            // 
            this.InsertCaseIDtxt.Location = new System.Drawing.Point(158, 33);
            this.InsertCaseIDtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertCaseIDtxt.Name = "InsertCaseIDtxt";
            this.InsertCaseIDtxt.Size = new System.Drawing.Size(100, 22);
            this.InsertCaseIDtxt.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Sagsnummer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "Få Sag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Ydelse";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Case_ID,
            this.CaseName,
            this.Client});
            this.dataGridView1.Location = new System.Drawing.Point(39, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 273);
            this.dataGridView1.TabIndex = 82;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(920, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(793, 273);
            this.dataGridView2.TabIndex = 83;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 738);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 38);
            this.button2.TabIndex = 84;
            this.button2.Text = "Ny sag";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(35, 489);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 20);
            label3.TabIndex = 85;
            label3.Text = "Klient:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(35, 622);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 20);
            label4.TabIndex = 86;
            label4.Text = "Slut Dato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(35, 422);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 87;
            label5.Text = "Sag ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(35, 455);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 20);
            label6.TabIndex = 88;
            label6.Text = "Sagsnavn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(35, 655);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 20);
            label7.TabIndex = 89;
            label7.Text = "Neg Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(35, 521);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(153, 20);
            label8.TabIndex = 90;
            label8.Text = "Ansv. Medarbejder:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(35, 555);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 20);
            label9.TabIndex = 91;
            label9.Text = "Service:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(35, 588);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(91, 20);
            label10.TabIndex = 92;
            label10.Text = "Start Dato:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(35, 688);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(95, 20);
            label11.TabIndex = 93;
            label11.Text = "Total Price:";
            // 
            // CaseIDtxb
            // 
            this.CaseIDtxb.Location = new System.Drawing.Point(198, 419);
            this.CaseIDtxb.Name = "CaseIDtxb";
            this.CaseIDtxb.Size = new System.Drawing.Size(292, 22);
            this.CaseIDtxb.TabIndex = 94;
            // 
            // CaseNametxb
            // 
            this.CaseNametxb.Location = new System.Drawing.Point(198, 452);
            this.CaseNametxb.Name = "CaseNametxb";
            this.CaseNametxb.Size = new System.Drawing.Size(292, 22);
            this.CaseNametxb.TabIndex = 95;
            // 
            // Clienttxt
            // 
            this.Clienttxt.Location = new System.Drawing.Point(198, 485);
            this.Clienttxt.Name = "Clienttxt";
            this.Clienttxt.Size = new System.Drawing.Size(292, 22);
            this.Clienttxt.TabIndex = 96;
            // 
            // ResoEmptxt
            // 
            this.ResoEmptxt.Location = new System.Drawing.Point(198, 518);
            this.ResoEmptxt.Name = "ResoEmptxt";
            this.ResoEmptxt.Size = new System.Drawing.Size(292, 22);
            this.ResoEmptxt.TabIndex = 97;
            // 
            // Servicetxt
            // 
            this.Servicetxt.Location = new System.Drawing.Point(198, 551);
            this.Servicetxt.Name = "Servicetxt";
            this.Servicetxt.Size = new System.Drawing.Size(292, 22);
            this.Servicetxt.TabIndex = 98;
            // 
            // StartDatetxt
            // 
            this.StartDatetxt.Location = new System.Drawing.Point(198, 584);
            this.StartDatetxt.Name = "StartDatetxt";
            this.StartDatetxt.Size = new System.Drawing.Size(292, 22);
            this.StartDatetxt.TabIndex = 99;
            // 
            // EndDatetxt
            // 
            this.EndDatetxt.Location = new System.Drawing.Point(198, 617);
            this.EndDatetxt.Name = "EndDatetxt";
            this.EndDatetxt.Size = new System.Drawing.Size(292, 22);
            this.EndDatetxt.TabIndex = 100;
            // 
            // NegPricetxt
            // 
            this.NegPricetxt.Location = new System.Drawing.Point(198, 650);
            this.NegPricetxt.Name = "NegPricetxt";
            this.NegPricetxt.Size = new System.Drawing.Size(292, 22);
            this.NegPricetxt.TabIndex = 101;
            // 
            // TotalPricetxt
            // 
            this.TotalPricetxt.Location = new System.Drawing.Point(198, 683);
            this.TotalPricetxt.Name = "TotalPricetxt";
            this.TotalPricetxt.Size = new System.Drawing.Size(292, 22);
            this.TotalPricetxt.TabIndex = 102;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(BusinessLogic.Case);
            // 
            // Case_ID
            // 
            this.Case_ID.FillWeight = 80F;
            this.Case_ID.HeaderText = "Sag ID";
            this.Case_ID.Name = "Case_ID";
            this.Case_ID.ReadOnly = true;
            this.Case_ID.Width = 80;
            // 
            // CaseName
            // 
            this.CaseName.FillWeight = 181F;
            this.CaseName.HeaderText = "Sagsnavn";
            this.CaseName.Name = "CaseName";
            this.CaseName.ReadOnly = true;
            this.CaseName.Width = 181;
            // 
            // Client
            // 
            this.Client.FillWeight = 181F;
            this.Client.HeaderText = "Klient";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 181;
            // 
            // RegisterServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 814);
            this.Controls.Add(this.TotalPricetxt);
            this.Controls.Add(this.NegPricetxt);
            this.Controls.Add(this.EndDatetxt);
            this.Controls.Add(this.StartDatetxt);
            this.Controls.Add(this.Servicetxt);
            this.Controls.Add(this.ResoEmptxt);
            this.Controls.Add(this.Clienttxt);
            this.Controls.Add(this.CaseNametxb);
            this.Controls.Add(this.CaseIDtxb);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertCaseIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InsertCaseIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CaseIDtxb;
        private System.Windows.Forms.TextBox CaseNametxb;
        private System.Windows.Forms.TextBox Clienttxt;
        private System.Windows.Forms.TextBox ResoEmptxt;
        private System.Windows.Forms.TextBox Servicetxt;
        private System.Windows.Forms.TextBox StartDatetxt;
        private System.Windows.Forms.TextBox EndDatetxt;
        private System.Windows.Forms.TextBox NegPricetxt;
        private System.Windows.Forms.TextBox TotalPricetxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}