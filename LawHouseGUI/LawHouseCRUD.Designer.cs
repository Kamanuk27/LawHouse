namespace LawHouseGUI
{
    partial class LawHouseCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CaseDataGrid = new System.Windows.Forms.DataGridView();
            this.Case_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resp_empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.Service_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateButt = new System.Windows.Forms.Button();
            this.CaseIDtxb = new System.Windows.Forms.TextBox();
            this.CaseNametxb = new System.Windows.Forms.TextBox();
            this.Clienttxt = new System.Windows.Forms.TextBox();
            this.Servicetxt = new System.Windows.Forms.TextBox();
            this.StartDatetxt = new System.Windows.Forms.TextBox();
            this.EndDatetxt = new System.Windows.Forms.TextBox();
            this.NegPricetxt = new System.Windows.Forms.TextBox();
            this.TotalPricetxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EndCaseTimePictxt = new System.Windows.Forms.DateTimePicker();
            this.ServiseDeleteBut = new System.Windows.Forms.Button();
            this.NyYdButton = new System.Windows.Forms.Button();
            this.YUpdate = new System.Windows.Forms.Button();
            this.YCommentTxt = new System.Windows.Forms.RichTextBox();
            this.YKmTxt = new System.Windows.Forms.TextBox();
            this.YHouresTxt = new System.Windows.Forms.TextBox();
            this.YDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.YEmploeeCombox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.RespEmpCombo = new System.Windows.Forms.ComboBox();
            this.ClosedCaseBut = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HoursEsttxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(84, 506);
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
            label4.Location = new System.Drawing.Point(84, 620);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(161, 20);
            label4.TabIndex = 86;
            label4.Text = "Forvented slutsdato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(84, 430);
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
            label6.Location = new System.Drawing.Point(84, 468);
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
            label7.Location = new System.Drawing.Point(552, 466);
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
            label8.Location = new System.Drawing.Point(552, 429);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 20);
            label8.TabIndex = 90;
            label8.Text = "Advokat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(84, 545);
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
            label10.Location = new System.Drawing.Point(84, 581);
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
            label11.Location = new System.Drawing.Point(551, 663);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(95, 20);
            label11.TabIndex = 93;
            label11.Text = "Total Price:";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchBox.Location = new System.Drawing.Point(517, 24);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(217, 27);
            this.searchBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Sager";
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(758, 21);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(119, 30);
            this.search_button.TabIndex = 59;
            this.search_button.Text = "Søg";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1004, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Ydelser på sagen:";
            // 
            // CaseDataGrid
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CaseDataGrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.CaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CaseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Case_ID,
            this.CaseName,
            this.Resp_empl,
            this.Client});
            this.CaseDataGrid.Location = new System.Drawing.Point(84, 64);
            this.CaseDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaseDataGrid.Name = "CaseDataGrid";
            this.CaseDataGrid.RowTemplate.Height = 24;
            this.CaseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CaseDataGrid.Size = new System.Drawing.Size(792, 322);
            this.CaseDataGrid.TabIndex = 82;
            this.CaseDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CaseDataGrid_CellMouseClick);
            this.CaseDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CaseDataGrid_CellMouseDoubleClick);
            // 
            // Case_ID
            // 
            this.Case_ID.FillWeight = 50F;
            this.Case_ID.HeaderText = "ID";
            this.Case_ID.Name = "Case_ID";
            this.Case_ID.ReadOnly = true;
            this.Case_ID.Width = 50;
            // 
            // CaseName
            // 
            this.CaseName.FillWeight = 200F;
            this.CaseName.HeaderText = "Sagsnavn";
            this.CaseName.Name = "CaseName";
            this.CaseName.ReadOnly = true;
            this.CaseName.Width = 200;
            // 
            // Resp_empl
            // 
            this.Resp_empl.FillWeight = 150F;
            this.Resp_empl.HeaderText = "Advokat";
            this.Resp_empl.Name = "Resp_empl";
            this.Resp_empl.ReadOnly = true;
            this.Resp_empl.Width = 150;
            // 
            // Client
            // 
            this.Client.FillWeight = 150F;
            this.Client.HeaderText = "Klient";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 150;
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service_Id,
            this.Empl_id,
            this.Date,
            this.Comments,
            this.Hours,
            this.Km});
            this.ServiceDataGrid.Location = new System.Drawing.Point(1054, 64);
            this.ServiceDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowTemplate.Height = 24;
            this.ServiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDataGrid.Size = new System.Drawing.Size(953, 322);
            this.ServiceDataGrid.TabIndex = 83;
            this.ServiceDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceDataGrid_CellMouseDoubleClick);
            // 
            // Service_Id
            // 
            this.Service_Id.FillWeight = 50F;
            this.Service_Id.HeaderText = "ID";
            this.Service_Id.Name = "Service_Id";
            this.Service_Id.ReadOnly = true;
            this.Service_Id.Visible = false;
            this.Service_Id.Width = 50;
            // 
            // Empl_id
            // 
            this.Empl_id.FillWeight = 170F;
            this.Empl_id.HeaderText = "Advokat";
            this.Empl_id.Name = "Empl_id";
            this.Empl_id.ReadOnly = true;
            this.Empl_id.Width = 170;
            // 
            // Date
            // 
            this.Date.FillWeight = 125F;
            this.Date.HeaderText = "Dato";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Comments
            // 
            this.Comments.FillWeight = 225F;
            this.Comments.HeaderText = "Ydelse";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 225;
            // 
            // Hours
            // 
            this.Hours.FillWeight = 85F;
            this.Hours.HeaderText = "Timer";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 85;
            // 
            // Km
            // 
            this.Km.FillWeight = 65F;
            this.Km.HeaderText = "Km";
            this.Km.Name = "Km";
            this.Km.ReadOnly = true;
            this.Km.Width = 65;
            // 
            // UpdateButt
            // 
            this.UpdateButt.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButt.Location = new System.Drawing.Point(725, 506);
            this.UpdateButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.Size = new System.Drawing.Size(152, 44);
            this.UpdateButt.TabIndex = 84;
            this.UpdateButt.Text = "Opdatere sag";
            this.UpdateButt.UseVisualStyleBackColor = false;
            this.UpdateButt.Click += new System.EventHandler(this.UpdateCaseButton_Click);
            // 
            // CaseIDtxb
            // 
            this.CaseIDtxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseIDtxb.Location = new System.Drawing.Point(292, 426);
            this.CaseIDtxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaseIDtxb.Name = "CaseIDtxb";
            this.CaseIDtxb.ReadOnly = true;
            this.CaseIDtxb.Size = new System.Drawing.Size(231, 27);
            this.CaseIDtxb.TabIndex = 94;
            // 
            // CaseNametxb
            // 
            this.CaseNametxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseNametxb.Location = new System.Drawing.Point(292, 465);
            this.CaseNametxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaseNametxb.Name = "CaseNametxb";
            this.CaseNametxb.ReadOnly = true;
            this.CaseNametxb.Size = new System.Drawing.Size(231, 27);
            this.CaseNametxb.TabIndex = 95;
            // 
            // Clienttxt
            // 
            this.Clienttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clienttxt.Location = new System.Drawing.Point(292, 501);
            this.Clienttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienttxt.Name = "Clienttxt";
            this.Clienttxt.ReadOnly = true;
            this.Clienttxt.Size = new System.Drawing.Size(231, 27);
            this.Clienttxt.TabIndex = 96;
            // 
            // Servicetxt
            // 
            this.Servicetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicetxt.Location = new System.Drawing.Point(292, 540);
            this.Servicetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Servicetxt.Name = "Servicetxt";
            this.Servicetxt.ReadOnly = true;
            this.Servicetxt.Size = new System.Drawing.Size(231, 27);
            this.Servicetxt.TabIndex = 98;
            // 
            // StartDatetxt
            // 
            this.StartDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatetxt.Location = new System.Drawing.Point(292, 578);
            this.StartDatetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDatetxt.Name = "StartDatetxt";
            this.StartDatetxt.ReadOnly = true;
            this.StartDatetxt.Size = new System.Drawing.Size(231, 27);
            this.StartDatetxt.TabIndex = 99;
            // 
            // EndDatetxt
            // 
            this.EndDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatetxt.Location = new System.Drawing.Point(292, 616);
            this.EndDatetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndDatetxt.Name = "EndDatetxt";
            this.EndDatetxt.ReadOnly = true;
            this.EndDatetxt.Size = new System.Drawing.Size(231, 27);
            this.EndDatetxt.TabIndex = 100;
            // 
            // NegPricetxt
            // 
            this.NegPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegPricetxt.Location = new System.Drawing.Point(655, 463);
            this.NegPricetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NegPricetxt.Name = "NegPricetxt";
            this.NegPricetxt.Size = new System.Drawing.Size(222, 27);
            this.NegPricetxt.TabIndex = 101;
            // 
            // TotalPricetxt
            // 
            this.TotalPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPricetxt.Location = new System.Drawing.Point(654, 657);
            this.TotalPricetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalPricetxt.Name = "TotalPricetxt";
            this.TotalPricetxt.Size = new System.Drawing.Size(222, 27);
            this.TotalPricetxt.TabIndex = 102;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 969);
            this.tabControl1.TabIndex = 103;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.EndCaseTimePictxt);
            this.tabPage1.Controls.Add(this.ServiseDeleteBut);
            this.tabPage1.Controls.Add(this.NyYdButton);
            this.tabPage1.Controls.Add(this.YUpdate);
            this.tabPage1.Controls.Add(this.YCommentTxt);
            this.tabPage1.Controls.Add(this.YKmTxt);
            this.tabPage1.Controls.Add(this.YHouresTxt);
            this.tabPage1.Controls.Add(this.YDateTimePicker1);
            this.tabPage1.Controls.Add(this.YEmploeeCombox);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.DeleteButt);
            this.tabPage1.Controls.Add(this.RespEmpCombo);
            this.tabPage1.Controls.Add(this.ClosedCaseBut);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.HoursEsttxt);
            this.tabPage1.Controls.Add(this.CaseDataGrid);
            this.tabPage1.Controls.Add(this.TotalPricetxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NegPricetxt);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.EndDatetxt);
            this.tabPage1.Controls.Add(this.search_button);
            this.tabPage1.Controls.Add(this.StartDatetxt);
            this.tabPage1.Controls.Add(this.ServiceDataGrid);
            this.tabPage1.Controls.Add(this.Servicetxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CaseIDtxb);
            this.tabPage1.Controls.Add(this.Clienttxt);
            this.tabPage1.Controls.Add(this.UpdateButt);
            this.tabPage1.Controls.Add(this.CaseNametxb);
            this.tabPage1.Controls.Add(label11);
            this.tabPage1.Controls.Add(label10);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(label9);
            this.tabPage1.Controls.Add(label4);
            this.tabPage1.Controls.Add(label8);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(label7);
            this.tabPage1.Controls.Add(label6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1916, 936);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opdatere/Afslute";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EndCaseTimePictxt
            // 
            this.EndCaseTimePictxt.Location = new System.Drawing.Point(656, 613);
            this.EndCaseTimePictxt.Name = "EndCaseTimePictxt";
            this.EndCaseTimePictxt.Size = new System.Drawing.Size(221, 27);
            this.EndCaseTimePictxt.TabIndex = 124;
            // 
            // ServiseDeleteBut
            // 
            this.ServiseDeleteBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ServiseDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiseDeleteBut.Location = new System.Drawing.Point(1652, 833);
            this.ServiseDeleteBut.Name = "ServiseDeleteBut";
            this.ServiseDeleteBut.Size = new System.Drawing.Size(161, 44);
            this.ServiseDeleteBut.TabIndex = 123;
            this.ServiseDeleteBut.Text = "Delete ydelse";
            this.ServiseDeleteBut.UseVisualStyleBackColor = false;
            this.ServiseDeleteBut.Click += new System.EventHandler(this.ServiseDeleteBut_Click);
            // 
            // NyYdButton
            // 
            this.NyYdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NyYdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyYdButton.Location = new System.Drawing.Point(1652, 676);
            this.NyYdButton.Name = "NyYdButton";
            this.NyYdButton.Size = new System.Drawing.Size(161, 44);
            this.NyYdButton.TabIndex = 122;
            this.NyYdButton.Text = "Ny ydelse";
            this.NyYdButton.UseVisualStyleBackColor = false;
            this.NyYdButton.Click += new System.EventHandler(this.NyYdButton_Click);
            // 
            // YUpdate
            // 
            this.YUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YUpdate.Location = new System.Drawing.Point(1652, 599);
            this.YUpdate.Name = "YUpdate";
            this.YUpdate.Size = new System.Drawing.Size(161, 44);
            this.YUpdate.TabIndex = 121;
            this.YUpdate.Text = "Opdatere ydelse";
            this.YUpdate.UseVisualStyleBackColor = true;
            this.YUpdate.Click += new System.EventHandler(this.ServiceUpdate_Click);
            // 
            // YCommentTxt
            // 
            this.YCommentTxt.Location = new System.Drawing.Point(1604, 422);
            this.YCommentTxt.Name = "YCommentTxt";
            this.YCommentTxt.Size = new System.Drawing.Size(209, 130);
            this.YCommentTxt.TabIndex = 120;
            this.YCommentTxt.Text = "";
            // 
            // YKmTxt
            // 
            this.YKmTxt.Location = new System.Drawing.Point(1192, 542);
            this.YKmTxt.Name = "YKmTxt";
            this.YKmTxt.Size = new System.Drawing.Size(209, 27);
            this.YKmTxt.TabIndex = 119;
            // 
            // YHouresTxt
            // 
            this.YHouresTxt.Location = new System.Drawing.Point(1192, 502);
            this.YHouresTxt.Name = "YHouresTxt";
            this.YHouresTxt.Size = new System.Drawing.Size(209, 27);
            this.YHouresTxt.TabIndex = 118;
            // 
            // YDateTimePicker1
            // 
            this.YDateTimePicker1.Location = new System.Drawing.Point(1192, 462);
            this.YDateTimePicker1.Name = "YDateTimePicker1";
            this.YDateTimePicker1.Size = new System.Drawing.Size(209, 27);
            this.YDateTimePicker1.TabIndex = 116;
            // 
            // YEmploeeCombox
            // 
            this.YEmploeeCombox.FormattingEnabled = true;
            this.YEmploeeCombox.Location = new System.Drawing.Point(1192, 421);
            this.YEmploeeCombox.Name = "YEmploeeCombox";
            this.YEmploeeCombox.Size = new System.Drawing.Size(209, 28);
            this.YEmploeeCombox.TabIndex = 115;
            this.YEmploeeCombox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YEmploeeCombox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1058, 546);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 20);
            this.label18.TabIndex = 114;
            this.label18.Text = "Km:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1058, 507);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 113;
            this.label17.Text = "Timer:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1470, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 112;
            this.label16.Text = "Ydelse:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1058, 468);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 111;
            this.label15.Text = "Dato:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1058, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 110;
            this.label14.Text = "Medarbejder:";
            // 
            // DeleteButt
            // 
            this.DeleteButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButt.Location = new System.Drawing.Point(725, 833);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(152, 44);
            this.DeleteButt.TabIndex = 109;
            this.DeleteButt.Text = "Delete sag";
            this.DeleteButt.UseVisualStyleBackColor = false;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteCaseButton_Click);
            // 
            // RespEmpCombo
            // 
            this.RespEmpCombo.FormattingEnabled = true;
            this.RespEmpCombo.Location = new System.Drawing.Point(655, 422);
            this.RespEmpCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RespEmpCombo.Name = "RespEmpCombo";
            this.RespEmpCombo.Size = new System.Drawing.Size(222, 28);
            this.RespEmpCombo.TabIndex = 108;
            this.RespEmpCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RespEmpCombo_KeyPress);
            // 
            // ClosedCaseBut
            // 
            this.ClosedCaseBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClosedCaseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosedCaseBut.Location = new System.Drawing.Point(527, 833);
            this.ClosedCaseBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClosedCaseBut.Name = "ClosedCaseBut";
            this.ClosedCaseBut.Size = new System.Drawing.Size(152, 44);
            this.ClosedCaseBut.TabIndex = 107;
            this.ClosedCaseBut.Text = "Afslut sag";
            this.ClosedCaseBut.UseVisualStyleBackColor = false;
            this.ClosedCaseBut.Click += new System.EventHandler(this.ClosedCaseBut_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(555, 620);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 105;
            this.label13.Text = "Slut Dato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 658);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 20);
            this.label12.TabIndex = 104;
            this.label12.Text = "Forvented tidsforbrug:";
            // 
            // HoursEsttxt
            // 
            this.HoursEsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursEsttxt.Location = new System.Drawing.Point(292, 654);
            this.HoursEsttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HoursEsttxt.Name = "HoursEsttxt";
            this.HoursEsttxt.ReadOnly = true;
            this.HoursEsttxt.Size = new System.Drawing.Size(231, 27);
            this.HoursEsttxt.TabIndex = 103;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1916, 936);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1916, 936);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(BusinessLogic.Case);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(724, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 125;
            this.button1.Text = "Beregn pris";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LawHouseCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 969);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LawHouseCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Law House Advokater";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CaseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CaseDataGrid;
        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.TextBox CaseIDtxb;
        private System.Windows.Forms.TextBox CaseNametxb;
        private System.Windows.Forms.TextBox Clienttxt;
        private System.Windows.Forms.TextBox Servicetxt;
        private System.Windows.Forms.TextBox StartDatetxt;
        private System.Windows.Forms.TextBox EndDatetxt;
        private System.Windows.Forms.TextBox NegPricetxt;
        private System.Windows.Forms.TextBox TotalPricetxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ClosedCaseBut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox HoursEsttxt;
        private System.Windows.Forms.ComboBox RespEmpCombo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resp_empl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.TextBox YKmTxt;
        private System.Windows.Forms.TextBox YHouresTxt;
        private System.Windows.Forms.DateTimePicker YDateTimePicker1;
        private System.Windows.Forms.ComboBox YEmploeeCombox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox YCommentTxt;
        private System.Windows.Forms.Button YUpdate;
        private System.Windows.Forms.Button NyYdButton;
        private System.Windows.Forms.Button ServiseDeleteBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km;
        private System.Windows.Forms.DateTimePicker EndCaseTimePictxt;
        private System.Windows.Forms.Button button1;
    }
}