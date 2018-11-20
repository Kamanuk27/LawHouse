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
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label negPriceLabel;
            System.Windows.Forms.Label respEmployeeLabel;
            System.Windows.Forms.Label serviceLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label totalPriceLabel;
            this.CaseNumtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.negPriceTextBox = new System.Windows.Forms.TextBox();
            this.respEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            clientLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            negPriceLabel = new System.Windows.Forms.Label();
            respEmployeeLabel = new System.Windows.Forms.Label();
            serviceLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clientLabel.Location = new System.Drawing.Point(36, 462);
            clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(57, 20);
            clientLabel.TabIndex = 61;
            clientLabel.Text = "Client:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endDateLabel.Location = new System.Drawing.Point(36, 595);
            endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(84, 20);
            endDateLabel.TabIndex = 63;
            endDateLabel.Text = "End Date:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(36, 395);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(75, 20);
            idLabel.TabIndex = 65;
            idLabel.Text = "Case ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(36, 428);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 20);
            nameLabel.TabIndex = 67;
            nameLabel.Text = "Case Name:";
            // 
            // negPriceLabel
            // 
            negPriceLabel.AutoSize = true;
            negPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            negPriceLabel.Location = new System.Drawing.Point(36, 628);
            negPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            negPriceLabel.Name = "negPriceLabel";
            negPriceLabel.Size = new System.Drawing.Size(88, 20);
            negPriceLabel.TabIndex = 69;
            negPriceLabel.Text = "Neg Price:";
            // 
            // respEmployeeLabel
            // 
            respEmployeeLabel.AutoSize = true;
            respEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            respEmployeeLabel.Location = new System.Drawing.Point(36, 494);
            respEmployeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            respEmployeeLabel.Name = "respEmployeeLabel";
            respEmployeeLabel.Size = new System.Drawing.Size(131, 20);
            respEmployeeLabel.TabIndex = 71;
            respEmployeeLabel.Text = "Resp Employee:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serviceLabel.Location = new System.Drawing.Point(36, 528);
            serviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new System.Drawing.Size(70, 20);
            serviceLabel.TabIndex = 73;
            serviceLabel.Text = "Service:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.Location = new System.Drawing.Point(36, 561);
            startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(91, 20);
            startDateLabel.TabIndex = 75;
            startDateLabel.Text = "Start Date:";
           
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPriceLabel.Location = new System.Drawing.Point(36, 661);
            totalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(95, 20);
            totalPriceLabel.TabIndex = 77;
            totalPriceLabel.Text = "Total Price:";
            // 
            // CaseNumtextBox
            // 
            this.CaseNumtextBox.Location = new System.Drawing.Point(154, 28);
            this.CaseNumtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaseNumtextBox.Name = "CaseNumtextBox";
            this.CaseNumtextBox.Size = new System.Drawing.Size(100, 22);
            this.CaseNumtextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Case number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Get Cases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clientTextBox
            // 
            this.clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Client", true));
            this.clientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTextBox.Location = new System.Drawing.Point(184, 458);
            this.clientTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(265, 27);
            this.clientTextBox.TabIndex = 62;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(BusinessLogic.Case);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(184, 392);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(265, 27);
            this.idTextBox.TabIndex = 66;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(184, 425);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 27);
            this.nameTextBox.TabIndex = 68;
            // 
            // negPriceTextBox
            // 
            this.negPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "NegPrice", true));
            this.negPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negPriceTextBox.Location = new System.Drawing.Point(184, 624);
            this.negPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.negPriceTextBox.Name = "negPriceTextBox";
            this.negPriceTextBox.Size = new System.Drawing.Size(265, 27);
            this.negPriceTextBox.TabIndex = 70;
            // 
            // respEmployeeTextBox
            // 
            this.respEmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "RespEmployee", true));
            this.respEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respEmployeeTextBox.Location = new System.Drawing.Point(184, 491);
            this.respEmployeeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.respEmployeeTextBox.Name = "respEmployeeTextBox";
            this.respEmployeeTextBox.Size = new System.Drawing.Size(265, 27);
            this.respEmployeeTextBox.TabIndex = 72;
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Service", true));
            this.serviceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTextBox.Location = new System.Drawing.Point(184, 524);
            this.serviceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(265, 27);
            this.serviceTextBox.TabIndex = 74;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TotalPrice", true));
            this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(184, 657);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(265, 27);
            this.totalPriceTextBox.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 591);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 79;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 558);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 27);
            this.textBox2.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "Provided Sevice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Name,
            this.C_Client});
            this.dataGridView1.Location = new System.Drawing.Point(39, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 273);
            this.dataGridView1.TabIndex = 82;
            // 
            // C_ID
            // 
            this.C_ID.HeaderText = "Case ID";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            // 
            // C_Name
            // 
            this.C_Name.FillWeight = 150F;
            this.C_Name.HeaderText = "Case Name";
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            this.C_Name.Width = 150;
            // 
            // C_Client
            // 
            this.C_Client.FillWeight = 150F;
            this.C_Client.HeaderText = "Client";
            this.C_Client.Name = "C_Client";
            this.C_Client.ReadOnly = true;
            this.C_Client.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(700, 75);
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
            // RegisterServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 814);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(negPriceLabel);
            this.Controls.Add(this.negPriceTextBox);
            this.Controls.Add(respEmployeeLabel);
            this.Controls.Add(this.respEmployeeTextBox);
            this.Controls.Add(serviceLabel);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.CaseNumtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterServices";
            this.Text = "Sager";
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CaseNumtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox negPriceTextBox;
        private System.Windows.Forms.TextBox respEmployeeTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Client;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}