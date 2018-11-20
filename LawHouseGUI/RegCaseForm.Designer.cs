namespace LawHouseGUI
{
    partial class RegCaseForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.negPriceTextBox = new System.Windows.Forms.TextBox();
            this.respEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CaseNumtextBox = new System.Windows.Forms.TextBox();
            this.andDatetextBox1 = new System.Windows.Forms.TextBox();
            this.startDatetextBox = new System.Windows.Forms.TextBox();
            clientLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            negPriceLabel = new System.Windows.Forms.Label();
            respEmployeeLabel = new System.Windows.Forms.Label();
            serviceLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // caseModelBindingSource
            // 
            this.caseModelBindingSource.DataSource = typeof(LawHouseLibrary.CaseModel);
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(69, 98);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(47, 17);
            clientLabel.TabIndex = 20;
            clientLabel.Text = "Client:";
            // 
            // clientTextBox
            // 
            this.clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "Client", true));
            this.clientTextBox.Location = new System.Drawing.Point(186, 95);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(200, 22);
            this.clientTextBox.TabIndex = 21;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(69, 127);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(71, 17);
            endDateLabel.TabIndex = 22;
            endDateLabel.Text = "End Date:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(69, 154);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 24;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(186, 151);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 25;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(69, 182);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(186, 179);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 27;
            // 
            // negPriceLabel
            // 
            negPriceLabel.AutoSize = true;
            negPriceLabel.Location = new System.Drawing.Point(69, 210);
            negPriceLabel.Name = "negPriceLabel";
            negPriceLabel.Size = new System.Drawing.Size(74, 17);
            negPriceLabel.TabIndex = 28;
            negPriceLabel.Text = "Neg Price:";
            // 
            // negPriceTextBox
            // 
            this.negPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "NegPrice", true));
            this.negPriceTextBox.Location = new System.Drawing.Point(186, 207);
            this.negPriceTextBox.Name = "negPriceTextBox";
            this.negPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.negPriceTextBox.TabIndex = 29;
            // 
            // respEmployeeLabel
            // 
            respEmployeeLabel.AutoSize = true;
            respEmployeeLabel.Location = new System.Drawing.Point(69, 238);
            respEmployeeLabel.Name = "respEmployeeLabel";
            respEmployeeLabel.Size = new System.Drawing.Size(111, 17);
            respEmployeeLabel.TabIndex = 30;
            respEmployeeLabel.Text = "Resp Employee:";
            // 
            // respEmployeeTextBox
            // 
            this.respEmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "RespEmployee", true));
            this.respEmployeeTextBox.Location = new System.Drawing.Point(186, 235);
            this.respEmployeeTextBox.Name = "respEmployeeTextBox";
            this.respEmployeeTextBox.Size = new System.Drawing.Size(200, 22);
            this.respEmployeeTextBox.TabIndex = 31;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new System.Drawing.Point(69, 266);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new System.Drawing.Size(59, 17);
            serviceLabel.TabIndex = 32;
            serviceLabel.Text = "Service:";
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "Service", true));
            this.serviceTextBox.Location = new System.Drawing.Point(186, 263);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(200, 22);
            this.serviceTextBox.TabIndex = 33;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(69, 295);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(76, 17);
            startDateLabel.TabIndex = 34;
            startDateLabel.Text = "Start Date:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new System.Drawing.Point(69, 322);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(80, 17);
            totalPriceLabel.TabIndex = 36;
            totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseModelBindingSource, "TotalPrice", true));
            this.totalPriceTextBox.Location = new System.Drawing.Point(186, 319);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalPriceTextBox.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Get Case";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Case number";
            // 
            // CaseNumtextBox
            // 
            this.CaseNumtextBox.Location = new System.Drawing.Point(186, 62);
            this.CaseNumtextBox.Name = "CaseNumtextBox";
            this.CaseNumtextBox.Size = new System.Drawing.Size(100, 22);
            this.CaseNumtextBox.TabIndex = 40;
            // 
            // andDatetextBox1
            // 
            this.andDatetextBox1.Location = new System.Drawing.Point(186, 121);
            this.andDatetextBox1.Name = "andDatetextBox1";
            this.andDatetextBox1.Size = new System.Drawing.Size(200, 22);
            this.andDatetextBox1.TabIndex = 41;
            // 
            // startDatetextBox
            // 
            this.startDatetextBox.Location = new System.Drawing.Point(186, 295);
            this.startDatetextBox.Name = "startDatetextBox";
            this.startDatetextBox.Size = new System.Drawing.Size(200, 22);
            this.startDatetextBox.TabIndex = 42;
            // 
            // RegCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 690);
            this.Controls.Add(this.startDatetextBox);
            this.Controls.Add(this.andDatetextBox1);
            this.Controls.Add(this.CaseNumtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Name = "RegCaseForm";
            this.Text = "RegCaseForm";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.BindingSource caseModelBindingSource;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox negPriceTextBox;
        private System.Windows.Forms.TextBox respEmployeeTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CaseNumtextBox;
        private System.Windows.Forms.TextBox andDatetextBox1;
        private System.Windows.Forms.TextBox startDatetextBox;
    }
}