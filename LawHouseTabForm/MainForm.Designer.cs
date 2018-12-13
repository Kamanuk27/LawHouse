namespace LawHouseTabForm
{
    partial class MainForm
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
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabCases = new System.Windows.Forms.TabPage();
            this.pnlAllOpenCases = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCasesbyClient = new System.Windows.Forms.Button();
            this.tlfTxtForCases = new System.Windows.Forms.TextBox();
            this.lblAllCLosedCases = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateButt = new System.Windows.Forms.Button();
            this.CalculatePrice = new System.Windows.Forms.Button();
            this.EndCaseTimePictxt = new System.Windows.Forms.DateTimePicker();
            this.RespEmpCombo = new System.Windows.Forms.ComboBox();
            this.ClosedCaseBut = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.NegPricetxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnReturnToShowOpenCases = new System.Windows.Forms.Button();
            this.btnShowClosedCases = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lLblHelpViewAllCasesTab = new System.Windows.Forms.LinkLabel();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.CaseDataGrid = new System.Windows.Forms.DataGridView();
            this.Case_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegotiatedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resp_empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllActiveCases = new System.Windows.Forms.Label();
            this.TotalPricetxt = new System.Windows.Forms.TextBox();
            this.pnlUpdateEditServices = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lLblHelpCaseServices2Tab = new System.Windows.Forms.LinkLabel();
            this.btnReturnToCasesPnl = new System.Windows.Forms.Button();
            this.btnActivateAddServiceBoxes = new System.Windows.Forms.Button();
            this.lblCaseName = new System.Windows.Forms.Label();
            this.lblHeaderServices = new System.Windows.Forms.Label();
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.Service_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeleteExsService = new System.Windows.Forms.Button();
            this.BtnAddNewService = new System.Windows.Forms.Button();
            this.BtnUpdateExsService = new System.Windows.Forms.Button();
            this.pnlActivateServiceBoxes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursUsed = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtServiceComment = new System.Windows.Forms.RichTextBox();
            this.txtServiceKm = new System.Windows.Forms.TextBox();
            this.txtHoursService = new System.Windows.Forms.TextBox();
            this.ServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ServiceEmploeeCombox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lLblHelpEmployeesTab = new System.Windows.Forms.LinkLabel();
            this.pnlAddSubjectToEmp = new System.Windows.Forms.Panel();
            this.btnDelSubjFromEmp = new System.Windows.Forms.Button();
            this.lstBoxShowEmpSpecialization = new System.Windows.Forms.ListBox();
            this.SpecialBtn = new System.Windows.Forms.Button();
            this.LServInsertCom = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.btnEditEmpCancel = new System.Windows.Forms.Button();
            this.lblOpdaterMedInfo = new System.Windows.Forms.Label();
            this.btnActivateUpdEmpFields = new System.Windows.Forms.Button();
            this.btnActivateAddEmpFields = new System.Windows.Forms.Button();
            this.pnlAddUpdateEmplFields = new System.Windows.Forms.Panel();
            this.NEmplPosition = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.NEmplMoney = new System.Windows.Forms.TextBox();
            this.NEmplStartDate = new System.Windows.Forms.DateTimePicker();
            this.label44 = new System.Windows.Forms.Label();
            this.NETlfTxt = new System.Windows.Forms.TextBox();
            this.NEEmailTxt = new System.Windows.Forms.TextBox();
            this.NEPostTxt = new System.Windows.Forms.TextBox();
            this.NEAdressTxt = new System.Windows.Forms.TextBox();
            this.NELnameTxt = new System.Windows.Forms.TextBox();
            this.NEFnameTxt = new System.Windows.Forms.TextBox();
            this.NECprTxt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.NewEmplButt = new System.Windows.Forms.Button();
            this.lblTilfNyMeda = new System.Windows.Forms.Label();
            this.lblAnsatte = new System.Windows.Forms.Label();
            this.DeleteEmpl = new System.Windows.Forms.Button();
            this.UpdateEmpl = new System.Windows.Forms.Button();
            this.EmplGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CprNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlfNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindExistingClient = new System.Windows.Forms.Button();
            this.btnCancelCreateNewCase = new System.Windows.Forms.Button();
            this.txtShowNewClientIdHere = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lLblHelpAddClientCaseTab = new System.Windows.Forms.LinkLabel();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.CrCaseServiceCom = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnNewCase = new System.Windows.Forms.Button();
            this.CrCasetimeP = new System.Windows.Forms.DateTimePicker();
            this.CrCaseAdvokat = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CrCaseTimeUsed = new System.Windows.Forms.TextBox();
            this.CrCasePrice = new System.Windows.Forms.TextBox();
            this.CrCaseEndDato = new System.Windows.Forms.TextBox();
            this.CrCaseName = new System.Windows.Forms.TextBox();
            this.NewClientBtn = new System.Windows.Forms.Button();
            this.NewClientTelef = new System.Windows.Forms.TextBox();
            this.NewClientMail = new System.Windows.Forms.TextBox();
            this.NewClientPost = new System.Windows.Forms.TextBox();
            this.NewClientAdress = new System.Windows.Forms.TextBox();
            this.NewClientLName = new System.Windows.Forms.TextBox();
            this.NewClientfName = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.NewClientCprNo = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabShowAllProServ = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateToo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblChooseEmployee = new System.Windows.Forms.Label();
            this.lLblHelpEmployeeServicesTab = new System.Windows.Forms.LinkLabel();
            this.totalKmDrivenInPeriod = new System.Windows.Forms.Label();
            this.totalHoursUseForPeriod = new System.Windows.Forms.Label();
            this.lblTotalKmDriven = new System.Windows.Forms.Label();
            this.lblTotalHoursUsed = new System.Windows.Forms.Label();
            this.btnShowPrServices = new System.Windows.Forms.Button();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxFindEmplID = new System.Windows.Forms.ComboBox();
            this.GridEmployeeServicesP = new System.Windows.Forms.DataGridView();
            this.CaseProvidedServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PServiceHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PServiceKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PServiceComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProvServices = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lLblHelpSubjectsTab = new System.Windows.Forms.LinkLabel();
            this.btnCnclSubjectEdit = new System.Windows.Forms.Button();
            this.pnlAddViewSubjects = new System.Windows.Forms.Panel();
            this.txtAddViewSubjectFixPrc = new System.Windows.Forms.TextBox();
            this.TxtAddViewSubjectTimeEst = new System.Windows.Forms.TextBox();
            this.txtAddViewSubjectHoursEst = new System.Windows.Forms.TextBox();
            this.txtAddViewSubjectName = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btnActivatAddSubjects = new System.Windows.Forms.Button();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSubj = new System.Windows.Forms.Button();
            this.btnUpdateSubj = new System.Windows.Forms.Button();
            this.btnMakeNewSubj = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabCases.SuspendLayout();
            this.pnlAllOpenCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDataGrid)).BeginInit();
            this.pnlUpdateEditServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.pnlActivateServiceBoxes.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlAddSubjectToEmp.SuspendLayout();
            this.pnlAddUpdateEmplFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmplGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabShowAllProServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeServicesP)).BeginInit();
            this.tabProvServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlAddViewSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Verdana", 9F);
            label22.Location = new System.Drawing.Point(543, 233);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(89, 14);
            label22.TabIndex = 335;
            label22.Text = "Start Dato: *";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Verdana", 9F);
            label24.Location = new System.Drawing.Point(543, 204);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(130, 14);
            label24.TabIndex = 334;
            label24.Text = "Vælg Servicetype: *";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Verdana", 9F);
            label25.Location = new System.Drawing.Point(543, 349);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(129, 14);
            label25.TabIndex = 330;
            label25.Text = "Forventet slutdato:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Verdana", 9F);
            label26.Location = new System.Drawing.Point(543, 262);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(124, 14);
            label26.TabIndex = 333;
            label26.Text = "Ansvarlig Advokat:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Verdana", 9F);
            label28.Location = new System.Drawing.Point(543, 291);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(101, 14);
            label28.TabIndex = 332;
            label28.Text = "Aftalt/fast pris:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new System.Drawing.Font("Verdana", 9F);
            label29.Location = new System.Drawing.Point(543, 175);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(136, 14);
            label29.TabIndex = 331;
            label29.Text = "Indtast Sagsnavn: *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Verdana", 9F);
            label11.Location = new System.Drawing.Point(654, 518);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 14);
            label11.TabIndex = 288;
            label11.Text = "Slut Pris";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Verdana", 9F);
            label8.Location = new System.Drawing.Point(339, 485);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 14);
            label8.TabIndex = 287;
            label8.Text = "Advokat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Verdana", 9F);
            label7.Location = new System.Drawing.Point(339, 518);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(101, 14);
            label7.TabIndex = 286;
            label7.Text = "Aftalt/fast pris:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Verdana", 9F);
            label5.Location = new System.Drawing.Point(543, 148);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 14);
            label5.TabIndex = 351;
            label5.Text = "Client ID: **";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabCases);
            this.TabControl.Controls.Add(this.tabEmployees);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabShowAllProServ);
            this.TabControl.Controls.Add(this.tabProvServices);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1206, 670);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabCases
            // 
            this.tabCases.Controls.Add(this.pnlUpdateEditServices);
            this.tabCases.Controls.Add(this.pnlAllOpenCases);
            this.tabCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCases.Location = new System.Drawing.Point(4, 27);
            this.tabCases.Margin = new System.Windows.Forms.Padding(2);
            this.tabCases.Name = "tabCases";
            this.tabCases.Padding = new System.Windows.Forms.Padding(2);
            this.tabCases.Size = new System.Drawing.Size(1198, 639);
            this.tabCases.TabIndex = 0;
            this.tabCases.Text = "Sager";
            this.tabCases.UseVisualStyleBackColor = true;
            // 
            // pnlAllOpenCases
            // 
            this.pnlAllOpenCases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAllOpenCases.Controls.Add(this.label10);
            this.pnlAllOpenCases.Controls.Add(this.label1);
            this.pnlAllOpenCases.Controls.Add(this.btnGetCasesbyClient);
            this.pnlAllOpenCases.Controls.Add(this.tlfTxtForCases);
            this.pnlAllOpenCases.Controls.Add(this.lblAllCLosedCases);
            this.pnlAllOpenCases.Controls.Add(this.label6);
            this.pnlAllOpenCases.Controls.Add(this.UpdateButt);
            this.pnlAllOpenCases.Controls.Add(this.CalculatePrice);
            this.pnlAllOpenCases.Controls.Add(this.EndCaseTimePictxt);
            this.pnlAllOpenCases.Controls.Add(this.RespEmpCombo);
            this.pnlAllOpenCases.Controls.Add(this.ClosedCaseBut);
            this.pnlAllOpenCases.Controls.Add(this.label13);
            this.pnlAllOpenCases.Controls.Add(this.NegPricetxt);
            this.pnlAllOpenCases.Controls.Add(label11);
            this.pnlAllOpenCases.Controls.Add(label8);
            this.pnlAllOpenCases.Controls.Add(label7);
            this.pnlAllOpenCases.Controls.Add(this.pictureBox4);
            this.pnlAllOpenCases.Controls.Add(this.btnReturnToShowOpenCases);
            this.pnlAllOpenCases.Controls.Add(this.btnShowClosedCases);
            this.pnlAllOpenCases.Controls.Add(this.search_button);
            this.pnlAllOpenCases.Controls.Add(this.searchBox);
            this.pnlAllOpenCases.Controls.Add(this.lLblHelpViewAllCasesTab);
            this.pnlAllOpenCases.Controls.Add(this.DeleteButt);
            this.pnlAllOpenCases.Controls.Add(this.CaseDataGrid);
            this.pnlAllOpenCases.Controls.Add(this.lblAllActiveCases);
            this.pnlAllOpenCases.Controls.Add(this.TotalPricetxt);
            this.pnlAllOpenCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllOpenCases.Location = new System.Drawing.Point(2, 2);
            this.pnlAllOpenCases.Name = "pnlAllOpenCases";
            this.pnlAllOpenCases.Size = new System.Drawing.Size(1194, 635);
            this.pnlAllOpenCases.TabIndex = 282;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 14);
            this.label1.TabIndex = 343;
            this.label1.Text = "Find alle sager for klient:";
            // 
            // btnGetCasesbyClient
            // 
            this.btnGetCasesbyClient.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnGetCasesbyClient.Location = new System.Drawing.Point(651, 118);
            this.btnGetCasesbyClient.Name = "btnGetCasesbyClient";
            this.btnGetCasesbyClient.Size = new System.Drawing.Size(71, 24);
            this.btnGetCasesbyClient.TabIndex = 342;
            this.btnGetCasesbyClient.Text = "Vis";
            this.btnGetCasesbyClient.UseVisualStyleBackColor = true;
            this.btnGetCasesbyClient.Click += new System.EventHandler(this.btnGetCasesbyClient_Click);
            // 
            // tlfTxtForCases
            // 
            this.tlfTxtForCases.Font = new System.Drawing.Font("Verdana", 9F);
            this.tlfTxtForCases.Location = new System.Drawing.Point(496, 118);
            this.tlfTxtForCases.Name = "tlfTxtForCases";
            this.tlfTxtForCases.Size = new System.Drawing.Size(149, 22);
            this.tlfTxtForCases.TabIndex = 341;
            // 
            // lblAllCLosedCases
            // 
            this.lblAllCLosedCases.AutoSize = true;
            this.lblAllCLosedCases.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblAllCLosedCases.Location = new System.Drawing.Point(16, 60);
            this.lblAllCLosedCases.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllCLosedCases.Name = "lblAllCLosedCases";
            this.lblAllCLosedCases.Size = new System.Drawing.Size(188, 18);
            this.lblAllCLosedCases.TabIndex = 340;
            this.lblAllCLosedCases.Text = "Alle afsluttede sager";
            this.lblAllCLosedCases.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 18);
            this.label6.TabIndex = 339;
            this.label6.Text = "Opdater/Afslut sag";
            // 
            // UpdateButt
            // 
            this.UpdateButt.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButt.Font = new System.Drawing.Font("Verdana", 9F);
            this.UpdateButt.Location = new System.Drawing.Point(445, 541);
            this.UpdateButt.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.Size = new System.Drawing.Size(114, 45);
            this.UpdateButt.TabIndex = 285;
            this.UpdateButt.Text = "Opdater";
            this.UpdateButt.UseVisualStyleBackColor = false;
            this.UpdateButt.Click += new System.EventHandler(this.UpdateButt_Click);
            // 
            // CalculatePrice
            // 
            this.CalculatePrice.Font = new System.Drawing.Font("Verdana", 9F);
            this.CalculatePrice.Location = new System.Drawing.Point(727, 541);
            this.CalculatePrice.Margin = new System.Windows.Forms.Padding(2);
            this.CalculatePrice.Name = "CalculatePrice";
            this.CalculatePrice.Size = new System.Drawing.Size(99, 45);
            this.CalculatePrice.TabIndex = 296;
            this.CalculatePrice.Text = "Beregn pris";
            this.CalculatePrice.UseVisualStyleBackColor = true;
            this.CalculatePrice.Click += new System.EventHandler(this.CalculatePrice_Click);
            // 
            // EndCaseTimePictxt
            // 
            this.EndCaseTimePictxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.EndCaseTimePictxt.Location = new System.Drawing.Point(729, 479);
            this.EndCaseTimePictxt.Margin = new System.Windows.Forms.Padding(2);
            this.EndCaseTimePictxt.Name = "EndCaseTimePictxt";
            this.EndCaseTimePictxt.Size = new System.Drawing.Size(167, 22);
            this.EndCaseTimePictxt.TabIndex = 295;
            // 
            // RespEmpCombo
            // 
            this.RespEmpCombo.Font = new System.Drawing.Font("Verdana", 9F);
            this.RespEmpCombo.FormattingEnabled = true;
            this.RespEmpCombo.Location = new System.Drawing.Point(445, 482);
            this.RespEmpCombo.Margin = new System.Windows.Forms.Padding(2);
            this.RespEmpCombo.Name = "RespEmpCombo";
            this.RespEmpCombo.Size = new System.Drawing.Size(168, 22);
            this.RespEmpCombo.TabIndex = 293;
            this.RespEmpCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RespEmpCombo_KeyPress);
            // 
            // ClosedCaseBut
            // 
            this.ClosedCaseBut.BackColor = System.Drawing.Color.Transparent;
            this.ClosedCaseBut.Font = new System.Drawing.Font("Verdana", 9F);
            this.ClosedCaseBut.Location = new System.Drawing.Point(830, 541);
            this.ClosedCaseBut.Margin = new System.Windows.Forms.Padding(2);
            this.ClosedCaseBut.Name = "ClosedCaseBut";
            this.ClosedCaseBut.Size = new System.Drawing.Size(66, 45);
            this.ClosedCaseBut.TabIndex = 292;
            this.ClosedCaseBut.Text = "Luk sag";
            this.ClosedCaseBut.UseVisualStyleBackColor = false;
            this.ClosedCaseBut.Visible = false;
            this.ClosedCaseBut.Click += new System.EventHandler(this.ClosedCaseBut_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F);
            this.label13.Location = new System.Drawing.Point(652, 485);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 14);
            this.label13.TabIndex = 291;
            this.label13.Text = "Slut Dato:";
            // 
            // NegPricetxt
            // 
            this.NegPricetxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.NegPricetxt.Location = new System.Drawing.Point(445, 515);
            this.NegPricetxt.Margin = new System.Windows.Forms.Padding(2);
            this.NegPricetxt.Name = "NegPricetxt";
            this.NegPricetxt.Size = new System.Drawing.Size(168, 22);
            this.NegPricetxt.TabIndex = 289;
            this.NegPricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NegPricetxt_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox4.Location = new System.Drawing.Point(877, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 100);
            this.pictureBox4.TabIndex = 338;
            this.pictureBox4.TabStop = false;
            // 
            // btnReturnToShowOpenCases
            // 
            this.btnReturnToShowOpenCases.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnReturnToShowOpenCases.Location = new System.Drawing.Point(19, 414);
            this.btnReturnToShowOpenCases.Name = "btnReturnToShowOpenCases";
            this.btnReturnToShowOpenCases.Size = new System.Drawing.Size(114, 45);
            this.btnReturnToShowOpenCases.TabIndex = 337;
            this.btnReturnToShowOpenCases.Text = "Vis åbne sager";
            this.btnReturnToShowOpenCases.UseVisualStyleBackColor = true;
            this.btnReturnToShowOpenCases.Visible = false;
            this.btnReturnToShowOpenCases.Click += new System.EventHandler(this.btnReturnToShowOpenCases_Click);
            // 
            // btnShowClosedCases
            // 
            this.btnShowClosedCases.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnShowClosedCases.Location = new System.Drawing.Point(19, 414);
            this.btnShowClosedCases.Name = "btnShowClosedCases";
            this.btnShowClosedCases.Size = new System.Drawing.Size(114, 45);
            this.btnShowClosedCases.TabIndex = 336;
            this.btnShowClosedCases.Text = "Vis lukkede sager";
            this.btnShowClosedCases.UseVisualStyleBackColor = true;
            this.btnShowClosedCases.Click += new System.EventHandler(this.btnShowClosedCases_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Verdana", 9F);
            this.search_button.Location = new System.Drawing.Point(1092, 119);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(89, 24);
            this.search_button.TabIndex = 334;
            this.search_button.Text = "Søg";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.searchBox.Location = new System.Drawing.Point(886, 121);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(202, 22);
            this.searchBox.TabIndex = 335;
            // 
            // lLblHelpViewAllCasesTab
            // 
            this.lLblHelpViewAllCasesTab.AutoSize = true;
            this.lLblHelpViewAllCasesTab.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lLblHelpViewAllCasesTab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpViewAllCasesTab.Name = "lLblHelpViewAllCasesTab";
            this.lLblHelpViewAllCasesTab.Size = new System.Drawing.Size(171, 18);
            this.lLblHelpViewAllCasesTab.TabIndex = 331;
            this.lLblHelpViewAllCasesTab.TabStop = true;
            this.lLblHelpViewAllCasesTab.Text = "Hjælp (View all cases)";
            // 
            // DeleteButt
            // 
            this.DeleteButt.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButt.Font = new System.Drawing.Font("Verdana", 9F);
            this.DeleteButt.Location = new System.Drawing.Point(138, 414);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(114, 45);
            this.DeleteButt.TabIndex = 294;
            this.DeleteButt.Text = "Slet sag";
            this.DeleteButt.UseVisualStyleBackColor = false;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // CaseDataGrid
            // 
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.CaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CaseDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.CaseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Case_ID,
            this.CaseName,
            this.Client,
            this.StartDate,
            this.EndDate,
            this.ServiceName,
            this.HoursEstimate,
            this.NegotiatedPrice,
            this.TotalPrice,
            this.Resp_empl});
            this.CaseDataGrid.Location = new System.Drawing.Point(19, 147);
            this.CaseDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CaseDataGrid.Name = "CaseDataGrid";
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.CaseDataGrid.RowTemplate.Height = 30;
            this.CaseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CaseDataGrid.Size = new System.Drawing.Size(1163, 262);
            this.CaseDataGrid.TabIndex = 284;
            this.CaseDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CaseDataGrid_CellMouseClick);
            this.CaseDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CaseDataGrid_CellMouseDoubleClick);
            // 
            // Case_ID
            // 
            this.Case_ID.FillWeight = 30F;
            this.Case_ID.HeaderText = "ID";
            this.Case_ID.Name = "Case_ID";
            this.Case_ID.ReadOnly = true;
            this.Case_ID.Width = 30;
            // 
            // CaseName
            // 
            this.CaseName.FillWeight = 170F;
            this.CaseName.HeaderText = "Sagsnavn";
            this.CaseName.Name = "CaseName";
            this.CaseName.ReadOnly = true;
            this.CaseName.Width = 170;
            // 
            // Client
            // 
            this.Client.FillWeight = 170F;
            this.Client.HeaderText = "Klient";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 170;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Startdato";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Slutdato";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.FillWeight = 150F;
            this.ServiceName.HeaderText = "Servicetype";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 150;
            // 
            // HoursEstimate
            // 
            this.HoursEstimate.FillWeight = 70F;
            this.HoursEstimate.HeaderText = "Timer";
            this.HoursEstimate.Name = "HoursEstimate";
            this.HoursEstimate.ReadOnly = true;
            this.HoursEstimate.Width = 70;
            // 
            // NegotiatedPrice
            // 
            this.NegotiatedPrice.FillWeight = 90F;
            this.NegotiatedPrice.HeaderText = "Aftalt pris";
            this.NegotiatedPrice.Name = "NegotiatedPrice";
            this.NegotiatedPrice.ReadOnly = true;
            this.NegotiatedPrice.Width = 90;
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 90F;
            this.TotalPrice.HeaderText = "Total pris";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 90;
            // 
            // Resp_empl
            // 
            this.Resp_empl.FillWeight = 150F;
            this.Resp_empl.HeaderText = "Advokat";
            this.Resp_empl.Name = "Resp_empl";
            this.Resp_empl.ReadOnly = true;
            this.Resp_empl.Width = 150;
            // 
            // lblAllActiveCases
            // 
            this.lblAllActiveCases.AutoSize = true;
            this.lblAllActiveCases.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblAllActiveCases.Location = new System.Drawing.Point(16, 60);
            this.lblAllActiveCases.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllActiveCases.Name = "lblAllActiveCases";
            this.lblAllActiveCases.Size = new System.Drawing.Size(152, 18);
            this.lblAllActiveCases.TabIndex = 282;
            this.lblAllActiveCases.Text = "Alle aktive sager";
            // 
            // TotalPricetxt
            // 
            this.TotalPricetxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.TotalPricetxt.Location = new System.Drawing.Point(727, 515);
            this.TotalPricetxt.Margin = new System.Windows.Forms.Padding(2);
            this.TotalPricetxt.Name = "TotalPricetxt";
            this.TotalPricetxt.Size = new System.Drawing.Size(168, 22);
            this.TotalPricetxt.TabIndex = 290;
            this.TotalPricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalPricetxt_KeyPress);
            // 
            // pnlUpdateEditServices
            // 
            this.pnlUpdateEditServices.Controls.Add(this.pictureBox3);
            this.pnlUpdateEditServices.Controls.Add(this.lLblHelpCaseServices2Tab);
            this.pnlUpdateEditServices.Controls.Add(this.btnReturnToCasesPnl);
            this.pnlUpdateEditServices.Controls.Add(this.btnActivateAddServiceBoxes);
            this.pnlUpdateEditServices.Controls.Add(this.lblCaseName);
            this.pnlUpdateEditServices.Controls.Add(this.lblHeaderServices);
            this.pnlUpdateEditServices.Controls.Add(this.ServiceDataGrid);
            this.pnlUpdateEditServices.Controls.Add(this.BtnDeleteExsService);
            this.pnlUpdateEditServices.Controls.Add(this.BtnAddNewService);
            this.pnlUpdateEditServices.Controls.Add(this.BtnUpdateExsService);
            this.pnlUpdateEditServices.Controls.Add(this.pnlActivateServiceBoxes);
            this.pnlUpdateEditServices.Location = new System.Drawing.Point(2, 2);
            this.pnlUpdateEditServices.Name = "pnlUpdateEditServices";
            this.pnlUpdateEditServices.Size = new System.Drawing.Size(1193, 641);
            this.pnlUpdateEditServices.TabIndex = 281;
            this.pnlUpdateEditServices.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(877, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 100);
            this.pictureBox3.TabIndex = 330;
            this.pictureBox3.TabStop = false;
            // 
            // lLblHelpCaseServices2Tab
            // 
            this.lLblHelpCaseServices2Tab.AutoSize = true;
            this.lLblHelpCaseServices2Tab.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lLblHelpCaseServices2Tab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpCaseServices2Tab.Name = "lLblHelpCaseServices2Tab";
            this.lLblHelpCaseServices2Tab.Size = new System.Drawing.Size(50, 18);
            this.lLblHelpCaseServices2Tab.TabIndex = 329;
            this.lLblHelpCaseServices2Tab.TabStop = true;
            this.lLblHelpCaseServices2Tab.Text = "Hjælp";
            // 
            // btnReturnToCasesPnl
            // 
            this.btnReturnToCasesPnl.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnReturnToCasesPnl.Location = new System.Drawing.Point(92, 464);
            this.btnReturnToCasesPnl.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnToCasesPnl.Name = "btnReturnToCasesPnl";
            this.btnReturnToCasesPnl.Size = new System.Drawing.Size(97, 45);
            this.btnReturnToCasesPnl.TabIndex = 328;
            this.btnReturnToCasesPnl.Text = "Retur";
            this.btnReturnToCasesPnl.UseVisualStyleBackColor = true;
            this.btnReturnToCasesPnl.Click += new System.EventHandler(this.btnReturnToCasesPnl_Click);
            // 
            // btnActivateAddServiceBoxes
            // 
            this.btnActivateAddServiceBoxes.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnActivateAddServiceBoxes.Location = new System.Drawing.Point(92, 414);
            this.btnActivateAddServiceBoxes.Name = "btnActivateAddServiceBoxes";
            this.btnActivateAddServiceBoxes.Size = new System.Drawing.Size(97, 45);
            this.btnActivateAddServiceBoxes.TabIndex = 182;
            this.btnActivateAddServiceBoxes.Text = "Tilføj ny ydelse";
            this.btnActivateAddServiceBoxes.UseVisualStyleBackColor = true;
            this.btnActivateAddServiceBoxes.Click += new System.EventHandler(this.btnActivateAddServiceBoxes_Click);
            // 
            // lblCaseName
            // 
            this.lblCaseName.AutoSize = true;
            this.lblCaseName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCaseName.Location = new System.Drawing.Point(228, 42);
            this.lblCaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaseName.Name = "lblCaseName";
            this.lblCaseName.Size = new System.Drawing.Size(60, 18);
            this.lblCaseName.TabIndex = 180;
            this.lblCaseName.Text = "label3";
            // 
            // lblHeaderServices
            // 
            this.lblHeaderServices.AutoSize = true;
            this.lblHeaderServices.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeaderServices.Location = new System.Drawing.Point(89, 42);
            this.lblHeaderServices.Name = "lblHeaderServices";
            this.lblHeaderServices.Size = new System.Drawing.Size(143, 18);
            this.lblHeaderServices.TabIndex = 175;
            this.lblHeaderServices.Text = "Ydelser på sag:";
            // 
            // ServiceDataGrid
            // 
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service_Id,
            this.Empl_id,
            this.Date,
            this.Comments,
            this.Hours,
            this.Km});
            this.ServiceDataGrid.Location = new System.Drawing.Point(92, 106);
            this.ServiceDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle58;
            this.ServiceDataGrid.RowTemplate.Height = 37;
            this.ServiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDataGrid.Size = new System.Drawing.Size(649, 288);
            this.ServiceDataGrid.TabIndex = 176;
            this.ServiceDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceDataGrid_CellMouseDoubleClick);
            // 
            // Service_Id
            // 
            this.Service_Id.FillWeight = 50F;
            this.Service_Id.HeaderText = "ID";
            this.Service_Id.Name = "Service_Id";
            this.Service_Id.ReadOnly = true;
            this.Service_Id.Visible = false;
            this.Service_Id.Width = 30;
            // 
            // Empl_id
            // 
            this.Empl_id.FillWeight = 170F;
            this.Empl_id.HeaderText = "Advokat";
            this.Empl_id.Name = "Empl_id";
            this.Empl_id.ReadOnly = true;
            this.Empl_id.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Dato";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.FillWeight = 225F;
            this.Comments.HeaderText = "Ydelsestype";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 225;
            // 
            // Hours
            // 
            this.Hours.FillWeight = 60F;
            this.Hours.HeaderText = "Timer";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 60;
            // 
            // Km
            // 
            this.Km.FillWeight = 65F;
            this.Km.HeaderText = "Km";
            this.Km.Name = "Km";
            this.Km.ReadOnly = true;
            this.Km.Width = 65;
            // 
            // BtnDeleteExsService
            // 
            this.BtnDeleteExsService.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteExsService.Font = new System.Drawing.Font("Verdana", 9F);
            this.BtnDeleteExsService.Location = new System.Drawing.Point(621, 569);
            this.BtnDeleteExsService.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteExsService.Name = "BtnDeleteExsService";
            this.BtnDeleteExsService.Size = new System.Drawing.Size(121, 36);
            this.BtnDeleteExsService.TabIndex = 179;
            this.BtnDeleteExsService.Text = "Slet";
            this.BtnDeleteExsService.UseVisualStyleBackColor = false;
            this.BtnDeleteExsService.Visible = false;
            this.BtnDeleteExsService.Click += new System.EventHandler(this.BtnDeleteExsService_Click);
            // 
            // BtnAddNewService
            // 
            this.BtnAddNewService.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddNewService.Font = new System.Drawing.Font("Verdana", 9F);
            this.BtnAddNewService.Location = new System.Drawing.Point(371, 569);
            this.BtnAddNewService.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddNewService.Name = "BtnAddNewService";
            this.BtnAddNewService.Size = new System.Drawing.Size(121, 36);
            this.BtnAddNewService.TabIndex = 178;
            this.BtnAddNewService.Text = "Tilføj ydelse";
            this.BtnAddNewService.UseVisualStyleBackColor = false;
            this.BtnAddNewService.Visible = false;
            this.BtnAddNewService.Click += new System.EventHandler(this.BtnAddNewService_Click);
            // 
            // BtnUpdateExsService
            // 
            this.BtnUpdateExsService.Font = new System.Drawing.Font("Verdana", 9F);
            this.BtnUpdateExsService.Location = new System.Drawing.Point(496, 569);
            this.BtnUpdateExsService.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateExsService.Name = "BtnUpdateExsService";
            this.BtnUpdateExsService.Size = new System.Drawing.Size(121, 36);
            this.BtnUpdateExsService.TabIndex = 177;
            this.BtnUpdateExsService.Text = "Opdater";
            this.BtnUpdateExsService.UseVisualStyleBackColor = true;
            this.BtnUpdateExsService.Visible = false;
            this.BtnUpdateExsService.Click += new System.EventHandler(this.BtnUpdateExsService_Click);
            // 
            // pnlActivateServiceBoxes
            // 
            this.pnlActivateServiceBoxes.Controls.Add(this.label2);
            this.pnlActivateServiceBoxes.Controls.Add(this.lblHoursUsed);
            this.pnlActivateServiceBoxes.Controls.Add(this.lblKm);
            this.pnlActivateServiceBoxes.Controls.Add(this.txtServiceComment);
            this.pnlActivateServiceBoxes.Controls.Add(this.txtServiceKm);
            this.pnlActivateServiceBoxes.Controls.Add(this.txtHoursService);
            this.pnlActivateServiceBoxes.Controls.Add(this.ServiceDateTimePicker);
            this.pnlActivateServiceBoxes.Controls.Add(this.ServiceEmploeeCombox);
            this.pnlActivateServiceBoxes.Controls.Add(this.label18);
            this.pnlActivateServiceBoxes.Controls.Add(this.label17);
            this.pnlActivateServiceBoxes.Controls.Add(this.label16);
            this.pnlActivateServiceBoxes.Controls.Add(this.label15);
            this.pnlActivateServiceBoxes.Controls.Add(this.label14);
            this.pnlActivateServiceBoxes.Location = new System.Drawing.Point(277, 399);
            this.pnlActivateServiceBoxes.Name = "pnlActivateServiceBoxes";
            this.pnlActivateServiceBoxes.Size = new System.Drawing.Size(478, 165);
            this.pnlActivateServiceBoxes.TabIndex = 181;
            this.pnlActivateServiceBoxes.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 14);
            this.label2.TabIndex = 181;
            this.label2.Text = "Indtast info om ydelse:";
            // 
            // lblHoursUsed
            // 
            this.lblHoursUsed.AutoSize = true;
            this.lblHoursUsed.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblHoursUsed.Location = new System.Drawing.Point(4, 97);
            this.lblHoursUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursUsed.Name = "lblHoursUsed";
            this.lblHoursUsed.Size = new System.Drawing.Size(85, 14);
            this.lblHoursUsed.TabIndex = 180;
            this.lblHoursUsed.Text = "timeforbrug:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblKm.Location = new System.Drawing.Point(4, 123);
            this.lblKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(59, 14);
            this.lblKm.TabIndex = 179;
            this.lblKm.Text = "km kørt:";
            // 
            // txtServiceComment
            // 
            this.txtServiceComment.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtServiceComment.Location = new System.Drawing.Point(306, 42);
            this.txtServiceComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceComment.Name = "txtServiceComment";
            this.txtServiceComment.Size = new System.Drawing.Size(158, 106);
            this.txtServiceComment.TabIndex = 178;
            this.txtServiceComment.Text = "";
            // 
            // txtServiceKm
            // 
            this.txtServiceKm.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtServiceKm.Location = new System.Drawing.Point(93, 120);
            this.txtServiceKm.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceKm.Name = "txtServiceKm";
            this.txtServiceKm.Size = new System.Drawing.Size(158, 22);
            this.txtServiceKm.TabIndex = 177;
            this.txtServiceKm.Text = "0";
            this.txtServiceKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceKm_KeyPress);
            // 
            // txtHoursService
            // 
            this.txtHoursService.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtHoursService.Location = new System.Drawing.Point(93, 94);
            this.txtHoursService.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoursService.Name = "txtHoursService";
            this.txtHoursService.Size = new System.Drawing.Size(158, 22);
            this.txtHoursService.TabIndex = 176;
            this.txtHoursService.Text = "0";
            this.txtHoursService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoursService_KeyPress);
            // 
            // ServiceDateTimePicker
            // 
            this.ServiceDateTimePicker.Font = new System.Drawing.Font("Verdana", 9F);
            this.ServiceDateTimePicker.Location = new System.Drawing.Point(93, 68);
            this.ServiceDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceDateTimePicker.Name = "ServiceDateTimePicker";
            this.ServiceDateTimePicker.Size = new System.Drawing.Size(158, 22);
            this.ServiceDateTimePicker.TabIndex = 175;
            // 
            // ServiceEmploeeCombox
            // 
            this.ServiceEmploeeCombox.Font = new System.Drawing.Font("Verdana", 9F);
            this.ServiceEmploeeCombox.FormattingEnabled = true;
            this.ServiceEmploeeCombox.Location = new System.Drawing.Point(93, 42);
            this.ServiceEmploeeCombox.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceEmploeeCombox.Name = "ServiceEmploeeCombox";
            this.ServiceEmploeeCombox.Size = new System.Drawing.Size(158, 22);
            this.ServiceEmploeeCombox.TabIndex = 174;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F);
            this.label18.Location = new System.Drawing.Point(-92, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 14);
            this.label18.TabIndex = 173;
            this.label18.Text = "Km:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9F);
            this.label17.Location = new System.Drawing.Point(-92, 123);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 14);
            this.label17.TabIndex = 172;
            this.label17.Text = "Timer:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F);
            this.label16.Location = new System.Drawing.Point(303, 20);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 14);
            this.label16.TabIndex = 171;
            this.label16.Text = "Kommentar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F);
            this.label15.Location = new System.Drawing.Point(-92, 100);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 170;
            this.label15.Text = "Dato:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F);
            this.label14.Location = new System.Drawing.Point(-92, 72);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 14);
            this.label14.TabIndex = 169;
            this.label14.Text = "Medarbejder:";
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.pictureBox5);
            this.tabEmployees.Controls.Add(this.lLblHelpEmployeesTab);
            this.tabEmployees.Controls.Add(this.pnlAddSubjectToEmp);
            this.tabEmployees.Controls.Add(this.btnEditEmpCancel);
            this.tabEmployees.Controls.Add(this.lblOpdaterMedInfo);
            this.tabEmployees.Controls.Add(this.btnActivateUpdEmpFields);
            this.tabEmployees.Controls.Add(this.btnActivateAddEmpFields);
            this.tabEmployees.Controls.Add(this.pnlAddUpdateEmplFields);
            this.tabEmployees.Controls.Add(this.NewEmplButt);
            this.tabEmployees.Controls.Add(this.lblTilfNyMeda);
            this.tabEmployees.Controls.Add(this.lblAnsatte);
            this.tabEmployees.Controls.Add(this.DeleteEmpl);
            this.tabEmployees.Controls.Add(this.UpdateEmpl);
            this.tabEmployees.Controls.Add(this.EmplGridView);
            this.tabEmployees.Location = new System.Drawing.Point(4, 27);
            this.tabEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmployees.Size = new System.Drawing.Size(1198, 639);
            this.tabEmployees.TabIndex = 2;
            this.tabEmployees.Text = "Ansatte";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox5.Location = new System.Drawing.Point(877, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 100);
            this.pictureBox5.TabIndex = 330;
            this.pictureBox5.TabStop = false;
            // 
            // lLblHelpEmployeesTab
            // 
            this.lLblHelpEmployeesTab.AutoSize = true;
            this.lLblHelpEmployeesTab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpEmployeesTab.Name = "lLblHelpEmployeesTab";
            this.lLblHelpEmployeesTab.Size = new System.Drawing.Size(50, 18);
            this.lLblHelpEmployeesTab.TabIndex = 329;
            this.lLblHelpEmployeesTab.TabStop = true;
            this.lLblHelpEmployeesTab.Text = "Hjælp";
            // 
            // pnlAddSubjectToEmp
            // 
            this.pnlAddSubjectToEmp.Controls.Add(this.btnDelSubjFromEmp);
            this.pnlAddSubjectToEmp.Controls.Add(this.lstBoxShowEmpSpecialization);
            this.pnlAddSubjectToEmp.Controls.Add(this.SpecialBtn);
            this.pnlAddSubjectToEmp.Controls.Add(this.LServInsertCom);
            this.pnlAddSubjectToEmp.Controls.Add(this.label61);
            this.pnlAddSubjectToEmp.Controls.Add(this.label60);
            this.pnlAddSubjectToEmp.Controls.Add(this.label59);
            this.pnlAddSubjectToEmp.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddSubjectToEmp.Location = new System.Drawing.Point(481, 136);
            this.pnlAddSubjectToEmp.Name = "pnlAddSubjectToEmp";
            this.pnlAddSubjectToEmp.Size = new System.Drawing.Size(340, 282);
            this.pnlAddSubjectToEmp.TabIndex = 328;
            this.pnlAddSubjectToEmp.Visible = false;
            // 
            // btnDelSubjFromEmp
            // 
            this.btnDelSubjFromEmp.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnDelSubjFromEmp.Location = new System.Drawing.Point(191, 211);
            this.btnDelSubjFromEmp.Name = "btnDelSubjFromEmp";
            this.btnDelSubjFromEmp.Size = new System.Drawing.Size(134, 45);
            this.btnDelSubjFromEmp.TabIndex = 308;
            this.btnDelSubjFromEmp.Text = "Slet speciale fra medarbejder";
            this.btnDelSubjFromEmp.Click += new System.EventHandler(this.btnDelSubjFromEmp_Click);
            // 
            // lstBoxShowEmpSpecialization
            // 
            this.lstBoxShowEmpSpecialization.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxShowEmpSpecialization.Location = new System.Drawing.Point(116, 13);
            this.lstBoxShowEmpSpecialization.Name = "lstBoxShowEmpSpecialization";
            this.lstBoxShowEmpSpecialization.Size = new System.Drawing.Size(209, 82);
            this.lstBoxShowEmpSpecialization.TabIndex = 0;
            // 
            // SpecialBtn
            // 
            this.SpecialBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.SpecialBtn.Location = new System.Drawing.Point(117, 210);
            this.SpecialBtn.Name = "SpecialBtn";
            this.SpecialBtn.Size = new System.Drawing.Size(68, 45);
            this.SpecialBtn.TabIndex = 307;
            this.SpecialBtn.Text = "Tilføj";
            this.SpecialBtn.Click += new System.EventHandler(this.AddSubjectToEmplBtn_Click);
            // 
            // LServInsertCom
            // 
            this.LServInsertCom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LServInsertCom.FormattingEnabled = true;
            this.LServInsertCom.Location = new System.Drawing.Point(117, 179);
            this.LServInsertCom.Margin = new System.Windows.Forms.Padding(2);
            this.LServInsertCom.Name = "LServInsertCom";
            this.LServInsertCom.Size = new System.Drawing.Size(208, 21);
            this.LServInsertCom.TabIndex = 303;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(12, 182);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(91, 13);
            this.label61.TabIndex = 301;
            this.label61.Text = "Specialisering:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(12, 16);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(92, 13);
            this.label60.TabIndex = 300;
            this.label60.Text = "Specialiseret i:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(12, 149);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(147, 16);
            this.label59.TabIndex = 299;
            this.label59.Text = "Tilføj specialisering";
            // 
            // btnEditEmpCancel
            // 
            this.btnEditEmpCancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnEditEmpCancel.Location = new System.Drawing.Point(294, 472);
            this.btnEditEmpCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditEmpCancel.Name = "btnEditEmpCancel";
            this.btnEditEmpCancel.Size = new System.Drawing.Size(97, 45);
            this.btnEditEmpCancel.TabIndex = 327;
            this.btnEditEmpCancel.Text = "Fortryd";
            this.btnEditEmpCancel.UseVisualStyleBackColor = true;
            this.btnEditEmpCancel.Visible = false;
            this.btnEditEmpCancel.Click += new System.EventHandler(this.btnEditEmpCancel_Click);
            // 
            // lblOpdaterMedInfo
            // 
            this.lblOpdaterMedInfo.AutoSize = true;
            this.lblOpdaterMedInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblOpdaterMedInfo.Location = new System.Drawing.Point(13, 93);
            this.lblOpdaterMedInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpdaterMedInfo.Name = "lblOpdaterMedInfo";
            this.lblOpdaterMedInfo.Size = new System.Drawing.Size(239, 18);
            this.lblOpdaterMedInfo.TabIndex = 326;
            this.lblOpdaterMedInfo.Text = "Opdater medarbejder info";
            this.lblOpdaterMedInfo.Visible = false;
            // 
            // btnActivateUpdEmpFields
            // 
            this.btnActivateUpdEmpFields.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnActivateUpdEmpFields.Location = new System.Drawing.Point(114, 505);
            this.btnActivateUpdEmpFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivateUpdEmpFields.Name = "btnActivateUpdEmpFields";
            this.btnActivateUpdEmpFields.Size = new System.Drawing.Size(97, 45);
            this.btnActivateUpdEmpFields.TabIndex = 325;
            this.btnActivateUpdEmpFields.Text = "Opdater medarbejderinfo";
            this.btnActivateUpdEmpFields.UseVisualStyleBackColor = true;
            this.btnActivateUpdEmpFields.Click += new System.EventHandler(this.btnActivateUpdEmpFields_Click);
            // 
            // btnActivateAddEmpFields
            // 
            this.btnActivateAddEmpFields.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnActivateAddEmpFields.Location = new System.Drawing.Point(13, 505);
            this.btnActivateAddEmpFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivateAddEmpFields.Name = "btnActivateAddEmpFields";
            this.btnActivateAddEmpFields.Size = new System.Drawing.Size(97, 45);
            this.btnActivateAddEmpFields.TabIndex = 324;
            this.btnActivateAddEmpFields.Text = "Tilføj ny medarbejder";
            this.btnActivateAddEmpFields.UseVisualStyleBackColor = true;
            this.btnActivateAddEmpFields.Click += new System.EventHandler(this.btnActivateAddEmpFields_Click);
            // 
            // pnlAddUpdateEmplFields
            // 
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEmplPosition);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label45);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEmplMoney);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEmplStartDate);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label44);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NETlfTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEEmailTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEPostTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEAdressTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NELnameTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NEFnameTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.NECprTxt);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label34);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label37);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label38);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label39);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label40);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label41);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label42);
            this.pnlAddUpdateEmplFields.Controls.Add(this.label43);
            this.pnlAddUpdateEmplFields.Location = new System.Drawing.Point(84, 136);
            this.pnlAddUpdateEmplFields.Name = "pnlAddUpdateEmplFields";
            this.pnlAddUpdateEmplFields.Size = new System.Drawing.Size(332, 282);
            this.pnlAddUpdateEmplFields.TabIndex = 304;
            this.pnlAddUpdateEmplFields.Visible = false;
            // 
            // NEmplPosition
            // 
            this.NEmplPosition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEmplPosition.Location = new System.Drawing.Point(107, 224);
            this.NEmplPosition.Margin = new System.Windows.Forms.Padding(2);
            this.NEmplPosition.Name = "NEmplPosition";
            this.NEmplPosition.Size = new System.Drawing.Size(200, 21);
            this.NEmplPosition.TabIndex = 324;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(17, 253);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(88, 13);
            this.label45.TabIndex = 321;
            this.label45.Text = "Aftalt timeløn:";
            // 
            // NEmplMoney
            // 
            this.NEmplMoney.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEmplMoney.Location = new System.Drawing.Point(107, 250);
            this.NEmplMoney.Margin = new System.Windows.Forms.Padding(2);
            this.NEmplMoney.Name = "NEmplMoney";
            this.NEmplMoney.Size = new System.Drawing.Size(200, 21);
            this.NEmplMoney.TabIndex = 320;
            this.NEmplMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NEmplMoney_KeyPress);
            // 
            // NEmplStartDate
            // 
            this.NEmplStartDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEmplStartDate.Location = new System.Drawing.Point(109, 198);
            this.NEmplStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.NEmplStartDate.Name = "NEmplStartDate";
            this.NEmplStartDate.Size = new System.Drawing.Size(198, 21);
            this.NEmplStartDate.TabIndex = 319;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(18, 224);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 13);
            this.label44.TabIndex = 318;
            this.label44.Text = "Stilling:";
            // 
            // NETlfTxt
            // 
            this.NETlfTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NETlfTxt.Location = new System.Drawing.Point(108, 172);
            this.NETlfTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NETlfTxt.Name = "NETlfTxt";
            this.NETlfTxt.Size = new System.Drawing.Size(198, 21);
            this.NETlfTxt.TabIndex = 317;
            this.NETlfTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NETlfTxt_KeyPress);
            // 
            // NEEmailTxt
            // 
            this.NEEmailTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEEmailTxt.Location = new System.Drawing.Point(107, 146);
            this.NEEmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NEEmailTxt.Name = "NEEmailTxt";
            this.NEEmailTxt.Size = new System.Drawing.Size(199, 21);
            this.NEEmailTxt.TabIndex = 316;
            // 
            // NEPostTxt
            // 
            this.NEPostTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEPostTxt.Location = new System.Drawing.Point(108, 120);
            this.NEPostTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NEPostTxt.Name = "NEPostTxt";
            this.NEPostTxt.Size = new System.Drawing.Size(198, 21);
            this.NEPostTxt.TabIndex = 315;
            this.NEPostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NEPostTxt_KeyPress);
            // 
            // NEAdressTxt
            // 
            this.NEAdressTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEAdressTxt.Location = new System.Drawing.Point(107, 94);
            this.NEAdressTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NEAdressTxt.Name = "NEAdressTxt";
            this.NEAdressTxt.Size = new System.Drawing.Size(198, 21);
            this.NEAdressTxt.TabIndex = 314;
            // 
            // NELnameTxt
            // 
            this.NELnameTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NELnameTxt.Location = new System.Drawing.Point(107, 68);
            this.NELnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NELnameTxt.Name = "NELnameTxt";
            this.NELnameTxt.Size = new System.Drawing.Size(198, 21);
            this.NELnameTxt.TabIndex = 313;
            // 
            // NEFnameTxt
            // 
            this.NEFnameTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEFnameTxt.Location = new System.Drawing.Point(107, 42);
            this.NEFnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NEFnameTxt.Name = "NEFnameTxt";
            this.NEFnameTxt.Size = new System.Drawing.Size(198, 21);
            this.NEFnameTxt.TabIndex = 312;
            // 
            // NECprTxt
            // 
            this.NECprTxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NECprTxt.Location = new System.Drawing.Point(107, 16);
            this.NECprTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NECprTxt.Name = "NECprTxt";
            this.NECprTxt.Size = new System.Drawing.Size(198, 21);
            this.NECprTxt.TabIndex = 311;
            this.NECprTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NECprTxt_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(17, 201);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 13);
            this.label34.TabIndex = 310;
            this.label34.Text = "Start Dato:";
            this.label34.Visible = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(17, 175);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 13);
            this.label37.TabIndex = 309;
            this.label37.Text = "Tlf nr:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(17, 149);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(43, 13);
            this.label38.TabIndex = 308;
            this.label38.Text = "Email:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(17, 123);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(48, 13);
            this.label39.TabIndex = 307;
            this.label39.Text = "Postnr:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(17, 97);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 13);
            this.label40.TabIndex = 306;
            this.label40.Text = "Adresse:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(17, 71);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(67, 13);
            this.label41.TabIndex = 305;
            this.label41.Text = "Efternavn:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(17, 45);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 13);
            this.label42.TabIndex = 304;
            this.label42.Text = "Fornavn:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(17, 19);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(49, 13);
            this.label43.TabIndex = 303;
            this.label43.Text = "Cpr nr:";
            // 
            // NewEmplButt
            // 
            this.NewEmplButt.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewEmplButt.Location = new System.Drawing.Point(191, 472);
            this.NewEmplButt.Margin = new System.Windows.Forms.Padding(2);
            this.NewEmplButt.Name = "NewEmplButt";
            this.NewEmplButt.Size = new System.Drawing.Size(97, 45);
            this.NewEmplButt.TabIndex = 322;
            this.NewEmplButt.Text = "Gem";
            this.NewEmplButt.UseVisualStyleBackColor = true;
            this.NewEmplButt.Visible = false;
            this.NewEmplButt.Click += new System.EventHandler(this.NewEmplButt_Click);
            // 
            // lblTilfNyMeda
            // 
            this.lblTilfNyMeda.AutoSize = true;
            this.lblTilfNyMeda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilfNyMeda.Location = new System.Drawing.Point(13, 93);
            this.lblTilfNyMeda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTilfNyMeda.Name = "lblTilfNyMeda";
            this.lblTilfNyMeda.Size = new System.Drawing.Size(184, 18);
            this.lblTilfNyMeda.TabIndex = 323;
            this.lblTilfNyMeda.Text = "Tilføj ny medarbejder";
            this.lblTilfNyMeda.Visible = false;
            // 
            // lblAnsatte
            // 
            this.lblAnsatte.AutoSize = true;
            this.lblAnsatte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsatte.Location = new System.Drawing.Point(13, 93);
            this.lblAnsatte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnsatte.Name = "lblAnsatte";
            this.lblAnsatte.Size = new System.Drawing.Size(73, 18);
            this.lblAnsatte.TabIndex = 303;
            this.lblAnsatte.Text = "Ansatte";
            // 
            // DeleteEmpl
            // 
            this.DeleteEmpl.Font = new System.Drawing.Font("Verdana", 9F);
            this.DeleteEmpl.Location = new System.Drawing.Point(294, 423);
            this.DeleteEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmpl.Name = "DeleteEmpl";
            this.DeleteEmpl.Size = new System.Drawing.Size(97, 45);
            this.DeleteEmpl.TabIndex = 301;
            this.DeleteEmpl.Text = "Slet medarbejder";
            this.DeleteEmpl.UseVisualStyleBackColor = true;
            this.DeleteEmpl.Visible = false;
            this.DeleteEmpl.Click += new System.EventHandler(this.DeleteEmpl_Click);
            // 
            // UpdateEmpl
            // 
            this.UpdateEmpl.Font = new System.Drawing.Font("Verdana", 9F);
            this.UpdateEmpl.Location = new System.Drawing.Point(121, 423);
            this.UpdateEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateEmpl.Name = "UpdateEmpl";
            this.UpdateEmpl.Size = new System.Drawing.Size(93, 45);
            this.UpdateEmpl.TabIndex = 300;
            this.UpdateEmpl.Text = "Opdater ";
            this.UpdateEmpl.UseVisualStyleBackColor = true;
            this.UpdateEmpl.Visible = false;
            this.UpdateEmpl.Click += new System.EventHandler(this.UpdateEmpl_Click);
            // 
            // EmplGridView
            // 
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.EmplGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle59;
            this.EmplGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmplGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CprNo,
            this.FName,
            this.LName,
            this.Address,
            this.PostNr,
            this.Email,
            this.TlfNo,
            this.dataGridViewTextBoxColumn1,
            this.Position,
            this.Money});
            this.EmplGridView.Location = new System.Drawing.Point(13, 136);
            this.EmplGridView.Margin = new System.Windows.Forms.Padding(2);
            this.EmplGridView.Name = "EmplGridView";
            this.EmplGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmplGridView.RowTemplate.Height = 24;
            this.EmplGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmplGridView.Size = new System.Drawing.Size(1113, 365);
            this.EmplGridView.TabIndex = 299;
            this.EmplGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmlGridView_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // CprNo
            // 
            this.CprNo.FillWeight = 80F;
            this.CprNo.HeaderText = "Cpr Nr";
            this.CprNo.Name = "CprNo";
            this.CprNo.ReadOnly = true;
            this.CprNo.Width = 80;
            // 
            // FName
            // 
            this.FName.HeaderText = "First name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.FillWeight = 140F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 140;
            // 
            // PostNr
            // 
            this.PostNr.FillWeight = 60F;
            this.PostNr.HeaderText = "Post nr";
            this.PostNr.Name = "PostNr";
            this.PostNr.ReadOnly = true;
            this.PostNr.Width = 60;
            // 
            // Email
            // 
            this.Email.FillWeight = 180F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 180;
            // 
            // TlfNo
            // 
            this.TlfNo.FillWeight = 80F;
            this.TlfNo.HeaderText = "Tlf nr";
            this.TlfNo.Name = "TlfNo";
            this.TlfNo.ReadOnly = true;
            this.TlfNo.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Start dato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.FillWeight = 60F;
            this.Money.HeaderText = "Pay rate ";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            this.Money.Width = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnFindExistingClient);
            this.tabPage1.Controls.Add(this.btnCancelCreateNewCase);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(this.txtShowNewClientIdHere);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.lLblHelpAddClientCaseTab);
            this.tabPage1.Controls.Add(this.btnUpdateClient);
            this.tabPage1.Controls.Add(this.CrCaseServiceCom);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.btnNewCase);
            this.tabPage1.Controls.Add(this.CrCasetimeP);
            this.tabPage1.Controls.Add(this.CrCaseAdvokat);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.CrCaseTimeUsed);
            this.tabPage1.Controls.Add(this.CrCasePrice);
            this.tabPage1.Controls.Add(this.CrCaseEndDato);
            this.tabPage1.Controls.Add(this.CrCaseName);
            this.tabPage1.Controls.Add(label22);
            this.tabPage1.Controls.Add(label24);
            this.tabPage1.Controls.Add(label25);
            this.tabPage1.Controls.Add(label26);
            this.tabPage1.Controls.Add(label28);
            this.tabPage1.Controls.Add(label29);
            this.tabPage1.Controls.Add(this.NewClientBtn);
            this.tabPage1.Controls.Add(this.NewClientTelef);
            this.tabPage1.Controls.Add(this.NewClientMail);
            this.tabPage1.Controls.Add(this.NewClientPost);
            this.tabPage1.Controls.Add(this.NewClientAdress);
            this.tabPage1.Controls.Add(this.NewClientLName);
            this.tabPage1.Controls.Add(this.NewClientfName);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.NewClientCprNo);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1198, 639);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Opret klient og sag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 26);
            this.label3.TabIndex = 354;
            this.label3.Text = "**Du kan ikke oprette sag uden klient ID,\r\n   søg på tlf nr eller opret ny klient" +
    "";
            // 
            // btnFindExistingClient
            // 
            this.btnFindExistingClient.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnFindExistingClient.Location = new System.Drawing.Point(313, 312);
            this.btnFindExistingClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindExistingClient.Name = "btnFindExistingClient";
            this.btnFindExistingClient.Size = new System.Drawing.Size(90, 22);
            this.btnFindExistingClient.TabIndex = 353;
            this.btnFindExistingClient.Text = "Søg på tlf";
            this.btnFindExistingClient.UseVisualStyleBackColor = true;
            this.btnFindExistingClient.Click += new System.EventHandler(this.btnFindExistingClient_Click);
            // 
            // btnCancelCreateNewCase
            // 
            this.btnCancelCreateNewCase.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnCancelCreateNewCase.Location = new System.Drawing.Point(792, 383);
            this.btnCancelCreateNewCase.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCreateNewCase.Name = "btnCancelCreateNewCase";
            this.btnCancelCreateNewCase.Size = new System.Drawing.Size(90, 45);
            this.btnCancelCreateNewCase.TabIndex = 352;
            this.btnCancelCreateNewCase.Text = "Fortryd";
            this.btnCancelCreateNewCase.UseVisualStyleBackColor = true;
            this.btnCancelCreateNewCase.Visible = false;
            this.btnCancelCreateNewCase.Click += new System.EventHandler(this.btnCancelCreateNewCase_Click);
            // 
            // txtShowNewClientIdHere
            // 
            this.txtShowNewClientIdHere.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtShowNewClientIdHere.Location = new System.Drawing.Point(698, 145);
            this.txtShowNewClientIdHere.Margin = new System.Windows.Forms.Padding(2);
            this.txtShowNewClientIdHere.Name = "txtShowNewClientIdHere";
            this.txtShowNewClientIdHere.Size = new System.Drawing.Size(192, 22);
            this.txtShowNewClientIdHere.TabIndex = 350;
            this.txtShowNewClientIdHere.Text = "Find/Opret klient";
            this.txtShowNewClientIdHere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShowNewClientIdHere_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(877, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 86);
            this.pictureBox2.TabIndex = 349;
            this.pictureBox2.TabStop = false;
            // 
            // lLblHelpAddClientCaseTab
            // 
            this.lLblHelpAddClientCaseTab.AutoSize = true;
            this.lLblHelpAddClientCaseTab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpAddClientCaseTab.Name = "lLblHelpAddClientCaseTab";
            this.lLblHelpAddClientCaseTab.Size = new System.Drawing.Size(50, 18);
            this.lLblHelpAddClientCaseTab.TabIndex = 348;
            this.lLblHelpAddClientCaseTab.TabStop = true;
            this.lLblHelpAddClientCaseTab.Text = "Hjælp";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnUpdateClient.Location = new System.Drawing.Point(257, 350);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(90, 45);
            this.btnUpdateClient.TabIndex = 346;
            this.btnUpdateClient.Text = "Opdater klient";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Visible = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // CrCaseServiceCom
            // 
            this.CrCaseServiceCom.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCaseServiceCom.FormattingEnabled = true;
            this.CrCaseServiceCom.Location = new System.Drawing.Point(698, 199);
            this.CrCaseServiceCom.Margin = new System.Windows.Forms.Padding(2);
            this.CrCaseServiceCom.Name = "CrCaseServiceCom";
            this.CrCaseServiceCom.Size = new System.Drawing.Size(192, 22);
            this.CrCaseServiceCom.TabIndex = 345;
            this.CrCaseServiceCom.SelectedIndexChanged += new System.EventHandler(this.CrCaseServiceCom_SelectedIndexChanged);
            this.CrCaseServiceCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CrCaseServiceCom_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(537, 98);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(114, 18);
            this.label35.TabIndex = 344;
            this.label35.Text = "Opret ny sag";
            // 
            // btnNewCase
            // 
            this.btnNewCase.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnNewCase.Location = new System.Drawing.Point(698, 383);
            this.btnNewCase.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCase.Name = "btnNewCase";
            this.btnNewCase.Size = new System.Drawing.Size(90, 45);
            this.btnNewCase.TabIndex = 343;
            this.btnNewCase.Text = "Tilføj sag";
            this.btnNewCase.UseVisualStyleBackColor = true;
            this.btnNewCase.Visible = false;
            this.btnNewCase.Click += new System.EventHandler(this.NewCaseButt_Click);
            // 
            // CrCasetimeP
            // 
            this.CrCasetimeP.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCasetimeP.Location = new System.Drawing.Point(698, 229);
            this.CrCasetimeP.Margin = new System.Windows.Forms.Padding(2);
            this.CrCasetimeP.Name = "CrCasetimeP";
            this.CrCasetimeP.Size = new System.Drawing.Size(192, 22);
            this.CrCasetimeP.TabIndex = 342;
            // 
            // CrCaseAdvokat
            // 
            this.CrCaseAdvokat.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCaseAdvokat.FormattingEnabled = true;
            this.CrCaseAdvokat.Location = new System.Drawing.Point(698, 259);
            this.CrCaseAdvokat.Margin = new System.Windows.Forms.Padding(2);
            this.CrCaseAdvokat.Name = "CrCaseAdvokat";
            this.CrCaseAdvokat.Size = new System.Drawing.Size(192, 22);
            this.CrCaseAdvokat.TabIndex = 341;
            this.CrCaseAdvokat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CrCaseAdvokat_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9F);
            this.label20.Location = new System.Drawing.Point(543, 320);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 14);
            this.label20.TabIndex = 340;
            this.label20.Text = "Forventet tidsforbrug:";
            // 
            // CrCaseTimeUsed
            // 
            this.CrCaseTimeUsed.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCaseTimeUsed.Location = new System.Drawing.Point(698, 317);
            this.CrCaseTimeUsed.Margin = new System.Windows.Forms.Padding(2);
            this.CrCaseTimeUsed.Name = "CrCaseTimeUsed";
            this.CrCaseTimeUsed.ReadOnly = true;
            this.CrCaseTimeUsed.Size = new System.Drawing.Size(131, 22);
            this.CrCaseTimeUsed.TabIndex = 339;
            // 
            // CrCasePrice
            // 
            this.CrCasePrice.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCasePrice.Location = new System.Drawing.Point(698, 289);
            this.CrCasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.CrCasePrice.Name = "CrCasePrice";
            this.CrCasePrice.Size = new System.Drawing.Size(131, 22);
            this.CrCasePrice.TabIndex = 338;
            this.CrCasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CrCasePrice_KeyPress);
            // 
            // CrCaseEndDato
            // 
            this.CrCaseEndDato.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCaseEndDato.Location = new System.Drawing.Point(698, 345);
            this.CrCaseEndDato.Margin = new System.Windows.Forms.Padding(2);
            this.CrCaseEndDato.Name = "CrCaseEndDato";
            this.CrCaseEndDato.ReadOnly = true;
            this.CrCaseEndDato.Size = new System.Drawing.Size(131, 22);
            this.CrCaseEndDato.TabIndex = 337;
            // 
            // CrCaseName
            // 
            this.CrCaseName.Font = new System.Drawing.Font("Verdana", 9F);
            this.CrCaseName.Location = new System.Drawing.Point(698, 171);
            this.CrCaseName.Margin = new System.Windows.Forms.Padding(2);
            this.CrCaseName.Name = "CrCaseName";
            this.CrCaseName.Size = new System.Drawing.Size(192, 22);
            this.CrCaseName.TabIndex = 336;
            // 
            // NewClientBtn
            // 
            this.NewClientBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientBtn.Location = new System.Drawing.Point(163, 350);
            this.NewClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientBtn.Name = "NewClientBtn";
            this.NewClientBtn.Size = new System.Drawing.Size(90, 45);
            this.NewClientBtn.TabIndex = 329;
            this.NewClientBtn.Text = "Tilføj ny klient";
            this.NewClientBtn.UseVisualStyleBackColor = true;
            this.NewClientBtn.Click += new System.EventHandler(this.NewClientBtn_Click);
            // 
            // NewClientTelef
            // 
            this.NewClientTelef.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientTelef.Location = new System.Drawing.Point(163, 312);
            this.NewClientTelef.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientTelef.Name = "NewClientTelef";
            this.NewClientTelef.Size = new System.Drawing.Size(146, 22);
            this.NewClientTelef.TabIndex = 328;
            this.NewClientTelef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewClientTelef_KeyPress);
            // 
            // NewClientMail
            // 
            this.NewClientMail.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientMail.Location = new System.Drawing.Point(163, 283);
            this.NewClientMail.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientMail.Name = "NewClientMail";
            this.NewClientMail.Size = new System.Drawing.Size(198, 22);
            this.NewClientMail.TabIndex = 327;
            // 
            // NewClientPost
            // 
            this.NewClientPost.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientPost.Location = new System.Drawing.Point(163, 254);
            this.NewClientPost.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientPost.Name = "NewClientPost";
            this.NewClientPost.Size = new System.Drawing.Size(124, 22);
            this.NewClientPost.TabIndex = 326;
            this.NewClientPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewClientPost_KeyPress);
            // 
            // NewClientAdress
            // 
            this.NewClientAdress.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientAdress.Location = new System.Drawing.Point(163, 225);
            this.NewClientAdress.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientAdress.Name = "NewClientAdress";
            this.NewClientAdress.Size = new System.Drawing.Size(200, 22);
            this.NewClientAdress.TabIndex = 325;
            // 
            // NewClientLName
            // 
            this.NewClientLName.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientLName.Location = new System.Drawing.Point(163, 196);
            this.NewClientLName.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientLName.Name = "NewClientLName";
            this.NewClientLName.Size = new System.Drawing.Size(183, 22);
            this.NewClientLName.TabIndex = 324;
            // 
            // NewClientfName
            // 
            this.NewClientfName.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientfName.Location = new System.Drawing.Point(163, 167);
            this.NewClientfName.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientfName.Name = "NewClientfName";
            this.NewClientfName.Size = new System.Drawing.Size(177, 22);
            this.NewClientfName.TabIndex = 323;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(64, 94);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(276, 18);
            this.label36.TabIndex = 322;
            this.label36.Text = "Find/Opdater eller tilføj ny klient";
            // 
            // NewClientCprNo
            // 
            this.NewClientCprNo.Font = new System.Drawing.Font("Verdana", 9F);
            this.NewClientCprNo.Location = new System.Drawing.Point(163, 138);
            this.NewClientCprNo.Margin = new System.Windows.Forms.Padding(2);
            this.NewClientCprNo.Name = "NewClientCprNo";
            this.NewClientCprNo.Size = new System.Drawing.Size(133, 22);
            this.NewClientCprNo.TabIndex = 321;
            this.NewClientCprNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewClientCprNo_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 9F);
            this.label33.Location = new System.Drawing.Point(67, 319);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 14);
            this.label33.TabIndex = 320;
            this.label33.Text = "TlfNo: *";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Verdana", 9F);
            this.label32.Location = new System.Drawing.Point(67, 289);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 14);
            this.label32.TabIndex = 319;
            this.label32.Text = "Email: *";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Verdana", 9F);
            this.label31.Location = new System.Drawing.Point(67, 259);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 14);
            this.label31.TabIndex = 318;
            this.label31.Text = "PostNo: *";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Verdana", 9F);
            this.label30.Location = new System.Drawing.Point(67, 229);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 14);
            this.label30.TabIndex = 317;
            this.label30.Text = "Address: *";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 9F);
            this.label27.Location = new System.Drawing.Point(67, 199);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 14);
            this.label27.TabIndex = 316;
            this.label27.Text = "LastName: *";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9F);
            this.label21.Location = new System.Drawing.Point(67, 169);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 14);
            this.label21.TabIndex = 315;
            this.label21.Text = "FirstName: *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9F);
            this.label19.Location = new System.Drawing.Point(67, 139);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 14);
            this.label19.TabIndex = 314;
            this.label19.Text = "CprNo: *";
            // 
            // tabShowAllProServ
            // 
            this.tabShowAllProServ.Controls.Add(this.label9);
            this.tabShowAllProServ.Controls.Add(this.pictureBox1);
            this.tabShowAllProServ.Controls.Add(this.label4);
            this.tabShowAllProServ.Controls.Add(this.lblDateToo);
            this.tabShowAllProServ.Controls.Add(this.lblDateFrom);
            this.tabShowAllProServ.Controls.Add(this.lblChooseEmployee);
            this.tabShowAllProServ.Controls.Add(this.lLblHelpEmployeeServicesTab);
            this.tabShowAllProServ.Controls.Add(this.totalKmDrivenInPeriod);
            this.tabShowAllProServ.Controls.Add(this.totalHoursUseForPeriod);
            this.tabShowAllProServ.Controls.Add(this.lblTotalKmDriven);
            this.tabShowAllProServ.Controls.Add(this.lblTotalHoursUsed);
            this.tabShowAllProServ.Controls.Add(this.btnShowPrServices);
            this.tabShowAllProServ.Controls.Add(this.dateTimeTo);
            this.tabShowAllProServ.Controls.Add(this.dateTimeFrom);
            this.tabShowAllProServ.Controls.Add(this.cmbBoxFindEmplID);
            this.tabShowAllProServ.Controls.Add(this.GridEmployeeServicesP);
            this.tabShowAllProServ.Location = new System.Drawing.Point(4, 27);
            this.tabShowAllProServ.Name = "tabShowAllProServ";
            this.tabShowAllProServ.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowAllProServ.Size = new System.Drawing.Size(1198, 639);
            this.tabShowAllProServ.TabIndex = 5;
            this.tabShowAllProServ.Text = "Ydelser udført";
            this.tabShowAllProServ.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(341, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Se ydelser udført for en given periode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(877, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 86);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Indtast periode";
            // 
            // lblDateToo
            // 
            this.lblDateToo.AutoSize = true;
            this.lblDateToo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDateToo.Location = new System.Drawing.Point(218, 186);
            this.lblDateToo.Name = "lblDateToo";
            this.lblDateToo.Size = new System.Drawing.Size(57, 14);
            this.lblDateToo.TabIndex = 12;
            this.lblDateToo.Text = "Dato til:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDateFrom.Location = new System.Drawing.Point(57, 186);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(63, 14);
            this.lblDateFrom.TabIndex = 11;
            this.lblDateFrom.Text = "Dato fra:";
            // 
            // lblChooseEmployee
            // 
            this.lblChooseEmployee.AutoSize = true;
            this.lblChooseEmployee.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseEmployee.Location = new System.Drawing.Point(52, 99);
            this.lblChooseEmployee.Name = "lblChooseEmployee";
            this.lblChooseEmployee.Size = new System.Drawing.Size(143, 16);
            this.lblChooseEmployee.TabIndex = 10;
            this.lblChooseEmployee.Text = "Vælg medarbejder";
            // 
            // lLblHelpEmployeeServicesTab
            // 
            this.lLblHelpEmployeeServicesTab.AutoSize = true;
            this.lLblHelpEmployeeServicesTab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpEmployeeServicesTab.Name = "lLblHelpEmployeeServicesTab";
            this.lLblHelpEmployeeServicesTab.Size = new System.Drawing.Size(50, 18);
            this.lLblHelpEmployeeServicesTab.TabIndex = 9;
            this.lLblHelpEmployeeServicesTab.TabStop = true;
            this.lLblHelpEmployeeServicesTab.Text = "Hjælp";
            // 
            // totalKmDrivenInPeriod
            // 
            this.totalKmDrivenInPeriod.AutoSize = true;
            this.totalKmDrivenInPeriod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKmDrivenInPeriod.Location = new System.Drawing.Point(846, 212);
            this.totalKmDrivenInPeriod.Name = "totalKmDrivenInPeriod";
            this.totalKmDrivenInPeriod.Size = new System.Drawing.Size(17, 16);
            this.totalKmDrivenInPeriod.TabIndex = 8;
            this.totalKmDrivenInPeriod.Text = "0";
            // 
            // totalHoursUseForPeriod
            // 
            this.totalHoursUseForPeriod.AutoSize = true;
            this.totalHoursUseForPeriod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursUseForPeriod.Location = new System.Drawing.Point(684, 212);
            this.totalHoursUseForPeriod.Name = "totalHoursUseForPeriod";
            this.totalHoursUseForPeriod.Size = new System.Drawing.Size(17, 16);
            this.totalHoursUseForPeriod.TabIndex = 7;
            this.totalHoursUseForPeriod.Text = "0";
            // 
            // lblTotalKmDriven
            // 
            this.lblTotalKmDriven.AutoSize = true;
            this.lblTotalKmDriven.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKmDriven.Location = new System.Drawing.Point(735, 212);
            this.lblTotalKmDriven.Name = "lblTotalKmDriven";
            this.lblTotalKmDriven.Size = new System.Drawing.Size(108, 16);
            this.lblTotalKmDriven.TabIndex = 6;
            this.lblTotalKmDriven.Text = "Total km kørt:";
            // 
            // lblTotalHoursUsed
            // 
            this.lblTotalHoursUsed.AutoSize = true;
            this.lblTotalHoursUsed.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoursUsed.Location = new System.Drawing.Point(542, 212);
            this.lblTotalHoursUsed.Name = "lblTotalHoursUsed";
            this.lblTotalHoursUsed.Size = new System.Drawing.Size(139, 16);
            this.lblTotalHoursUsed.TabIndex = 5;
            this.lblTotalHoursUsed.Text = "Total timeforbrug:";
            // 
            // btnShowPrServices
            // 
            this.btnShowPrServices.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnShowPrServices.Location = new System.Drawing.Point(382, 205);
            this.btnShowPrServices.Name = "btnShowPrServices";
            this.btnShowPrServices.Size = new System.Drawing.Size(101, 23);
            this.btnShowPrServices.TabIndex = 4;
            this.btnShowPrServices.Text = "Søg";
            this.btnShowPrServices.UseVisualStyleBackColor = true;
            this.btnShowPrServices.Click += new System.EventHandler(this.btnShowPrServices_Click);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateTimeTo.Location = new System.Drawing.Point(221, 205);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(155, 22);
            this.dateTimeTo.TabIndex = 3;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateTimeFrom.Location = new System.Drawing.Point(60, 205);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(155, 22);
            this.dateTimeFrom.TabIndex = 2;
            // 
            // cmbBoxFindEmplID
            // 
            this.cmbBoxFindEmplID.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmbBoxFindEmplID.FormattingEnabled = true;
            this.cmbBoxFindEmplID.Location = new System.Drawing.Point(55, 118);
            this.cmbBoxFindEmplID.Name = "cmbBoxFindEmplID";
            this.cmbBoxFindEmplID.Size = new System.Drawing.Size(182, 22);
            this.cmbBoxFindEmplID.TabIndex = 1;
            this.cmbBoxFindEmplID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFindEmplID_SelectedIndexChanged);
            // 
            // GridEmployeeServicesP
            // 
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEmployeeServicesP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle60;
            this.GridEmployeeServicesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployeeServicesP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseProvidedServiceId,
            this.PServiceDate,
            this.PServiceHours,
            this.PServiceKm,
            this.PServiceComment});
            this.GridEmployeeServicesP.Location = new System.Drawing.Point(55, 246);
            this.GridEmployeeServicesP.Name = "GridEmployeeServicesP";
            this.GridEmployeeServicesP.Size = new System.Drawing.Size(814, 330);
            this.GridEmployeeServicesP.TabIndex = 0;
            // 
            // CaseProvidedServiceId
            // 
            this.CaseProvidedServiceId.FillWeight = 80F;
            this.CaseProvidedServiceId.HeaderText = "Sags-ID";
            this.CaseProvidedServiceId.Name = "CaseProvidedServiceId";
            this.CaseProvidedServiceId.ReadOnly = true;
            this.CaseProvidedServiceId.Width = 80;
            // 
            // PServiceDate
            // 
            this.PServiceDate.FillWeight = 110F;
            this.PServiceDate.HeaderText = "Dato";
            this.PServiceDate.Name = "PServiceDate";
            this.PServiceDate.ReadOnly = true;
            this.PServiceDate.Width = 110;
            // 
            // PServiceHours
            // 
            this.PServiceHours.HeaderText = "Timer brugt";
            this.PServiceHours.Name = "PServiceHours";
            this.PServiceHours.ReadOnly = true;
            // 
            // PServiceKm
            // 
            this.PServiceKm.FillWeight = 80F;
            this.PServiceKm.HeaderText = "Km kørt";
            this.PServiceKm.Name = "PServiceKm";
            this.PServiceKm.ReadOnly = true;
            this.PServiceKm.Width = 80;
            // 
            // PServiceComment
            // 
            this.PServiceComment.FillWeight = 400F;
            this.PServiceComment.HeaderText = "Kommentar";
            this.PServiceComment.Name = "PServiceComment";
            this.PServiceComment.ReadOnly = true;
            this.PServiceComment.Width = 400;
            // 
            // tabProvServices
            // 
            this.tabProvServices.Controls.Add(this.pictureBox6);
            this.tabProvServices.Controls.Add(this.lLblHelpSubjectsTab);
            this.tabProvServices.Controls.Add(this.btnCnclSubjectEdit);
            this.tabProvServices.Controls.Add(this.pnlAddViewSubjects);
            this.tabProvServices.Controls.Add(this.btnActivatAddSubjects);
            this.tabProvServices.Controls.Add(this.ServiceGridView);
            this.tabProvServices.Controls.Add(this.btnDeleteSubj);
            this.tabProvServices.Controls.Add(this.btnUpdateSubj);
            this.tabProvServices.Controls.Add(this.btnMakeNewSubj);
            this.tabProvServices.Controls.Add(this.label48);
            this.tabProvServices.Location = new System.Drawing.Point(4, 27);
            this.tabProvServices.Margin = new System.Windows.Forms.Padding(2);
            this.tabProvServices.Name = "tabProvServices";
            this.tabProvServices.Padding = new System.Windows.Forms.Padding(2);
            this.tabProvServices.Size = new System.Drawing.Size(1198, 639);
            this.tabProvServices.TabIndex = 3;
            this.tabProvServices.Text = "Tjenesteydelser og efteruddannelse";
            this.tabProvServices.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LawHouseTabForm.Properties.Resources.LawHouse_Logo;
            this.pictureBox6.Location = new System.Drawing.Point(877, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(141, 100);
            this.pictureBox6.TabIndex = 303;
            this.pictureBox6.TabStop = false;
            // 
            // lLblHelpSubjectsTab
            // 
            this.lLblHelpSubjectsTab.AutoSize = true;
            this.lLblHelpSubjectsTab.Location = new System.Drawing.Point(1076, 572);
            this.lLblHelpSubjectsTab.Name = "lLblHelpSubjectsTab";
            this.lLblHelpSubjectsTab.Size = new System.Drawing.Size(50, 18);
            this.lLblHelpSubjectsTab.TabIndex = 302;
            this.lLblHelpSubjectsTab.TabStop = true;
            this.lLblHelpSubjectsTab.Text = "Hjælp";
            // 
            // btnCnclSubjectEdit
            // 
            this.btnCnclSubjectEdit.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnCnclSubjectEdit.Location = new System.Drawing.Point(551, 450);
            this.btnCnclSubjectEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCnclSubjectEdit.Name = "btnCnclSubjectEdit";
            this.btnCnclSubjectEdit.Size = new System.Drawing.Size(71, 45);
            this.btnCnclSubjectEdit.TabIndex = 301;
            this.btnCnclSubjectEdit.Text = "Fortryd";
            this.btnCnclSubjectEdit.UseVisualStyleBackColor = true;
            this.btnCnclSubjectEdit.Visible = false;
            this.btnCnclSubjectEdit.Click += new System.EventHandler(this.btnCnclSubjectEdit_Click);
            // 
            // pnlAddViewSubjects
            // 
            this.pnlAddViewSubjects.Controls.Add(this.txtAddViewSubjectFixPrc);
            this.pnlAddViewSubjects.Controls.Add(this.TxtAddViewSubjectTimeEst);
            this.pnlAddViewSubjects.Controls.Add(this.txtAddViewSubjectHoursEst);
            this.pnlAddViewSubjects.Controls.Add(this.txtAddViewSubjectName);
            this.pnlAddViewSubjects.Controls.Add(this.label53);
            this.pnlAddViewSubjects.Controls.Add(this.label50);
            this.pnlAddViewSubjects.Controls.Add(this.label49);
            this.pnlAddViewSubjects.Controls.Add(this.label47);
            this.pnlAddViewSubjects.Location = new System.Drawing.Point(651, 245);
            this.pnlAddViewSubjects.Name = "pnlAddViewSubjects";
            this.pnlAddViewSubjects.Size = new System.Drawing.Size(280, 146);
            this.pnlAddViewSubjects.TabIndex = 300;
            this.pnlAddViewSubjects.Visible = false;
            // 
            // txtAddViewSubjectFixPrc
            // 
            this.txtAddViewSubjectFixPrc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddViewSubjectFixPrc.Location = new System.Drawing.Point(102, 103);
            this.txtAddViewSubjectFixPrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddViewSubjectFixPrc.Name = "txtAddViewSubjectFixPrc";
            this.txtAddViewSubjectFixPrc.Size = new System.Drawing.Size(162, 21);
            this.txtAddViewSubjectFixPrc.TabIndex = 296;
            this.txtAddViewSubjectFixPrc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddViewSubjectFixPrc_KeyPress);
            // 
            // TxtAddViewSubjectTimeEst
            // 
            this.TxtAddViewSubjectTimeEst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddViewSubjectTimeEst.Location = new System.Drawing.Point(102, 71);
            this.TxtAddViewSubjectTimeEst.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAddViewSubjectTimeEst.Name = "TxtAddViewSubjectTimeEst";
            this.TxtAddViewSubjectTimeEst.Size = new System.Drawing.Size(162, 21);
            this.TxtAddViewSubjectTimeEst.TabIndex = 295;
            this.TxtAddViewSubjectTimeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddViewSubjectTimeEst_KeyPress);
            // 
            // txtAddViewSubjectHoursEst
            // 
            this.txtAddViewSubjectHoursEst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddViewSubjectHoursEst.Location = new System.Drawing.Point(102, 39);
            this.txtAddViewSubjectHoursEst.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddViewSubjectHoursEst.Name = "txtAddViewSubjectHoursEst";
            this.txtAddViewSubjectHoursEst.Size = new System.Drawing.Size(162, 21);
            this.txtAddViewSubjectHoursEst.TabIndex = 294;
            this.txtAddViewSubjectHoursEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddViewSubjectHoursEst_KeyPress);
            // 
            // txtAddViewSubjectName
            // 
            this.txtAddViewSubjectName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddViewSubjectName.Location = new System.Drawing.Point(102, 7);
            this.txtAddViewSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddViewSubjectName.Name = "txtAddViewSubjectName";
            this.txtAddViewSubjectName.Size = new System.Drawing.Size(162, 21);
            this.txtAddViewSubjectName.TabIndex = 293;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(11, 74);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(82, 13);
            this.label53.TabIndex = 292;
            this.label53.Text = "Tids-estimat:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(11, 106);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 13);
            this.label50.TabIndex = 291;
            this.label50.Text = "Fast pris:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(11, 10);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(39, 13);
            this.label49.TabIndex = 290;
            this.label49.Text = "Type:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(11, 42);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(87, 13);
            this.label47.TabIndex = 289;
            this.label47.Text = "Time-estimat:";
            // 
            // btnActivatAddSubjects
            // 
            this.btnActivatAddSubjects.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnActivatAddSubjects.Location = new System.Drawing.Point(77, 450);
            this.btnActivatAddSubjects.Name = "btnActivatAddSubjects";
            this.btnActivatAddSubjects.Size = new System.Drawing.Size(120, 45);
            this.btnActivatAddSubjects.TabIndex = 299;
            this.btnActivatAddSubjects.Text = "Tilføj efteruddannelse";
            this.btnActivatAddSubjects.UseVisualStyleBackColor = true;
            this.btnActivatAddSubjects.Click += new System.EventHandler(this.btnActivatAddSubjects_Click);
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Time,
            this.Price});
            this.ServiceGridView.Location = new System.Drawing.Point(77, 109);
            this.ServiceGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowTemplate.Height = 24;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(545, 322);
            this.ServiceGridView.TabIndex = 298;
            this.ServiceGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SubjectGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Service name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hours Estimate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // btnDeleteSubj
            // 
            this.btnDeleteSubj.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnDeleteSubj.Location = new System.Drawing.Point(844, 394);
            this.btnDeleteSubj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSubj.Name = "btnDeleteSubj";
            this.btnDeleteSubj.Size = new System.Drawing.Size(71, 45);
            this.btnDeleteSubj.TabIndex = 297;
            this.btnDeleteSubj.Text = "Slet";
            this.btnDeleteSubj.UseVisualStyleBackColor = true;
            this.btnDeleteSubj.Visible = false;
            this.btnDeleteSubj.Click += new System.EventHandler(this.btnDeleteSubj_Click);
            // 
            // btnUpdateSubj
            // 
            this.btnUpdateSubj.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnUpdateSubj.Location = new System.Drawing.Point(766, 394);
            this.btnUpdateSubj.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSubj.Name = "btnUpdateSubj";
            this.btnUpdateSubj.Size = new System.Drawing.Size(71, 45);
            this.btnUpdateSubj.TabIndex = 296;
            this.btnUpdateSubj.Text = "Opdater";
            this.btnUpdateSubj.UseVisualStyleBackColor = true;
            this.btnUpdateSubj.Visible = false;
            this.btnUpdateSubj.Click += new System.EventHandler(this.btnUpdateSubj_Click);
            // 
            // btnMakeNewSubj
            // 
            this.btnMakeNewSubj.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnMakeNewSubj.Location = new System.Drawing.Point(766, 394);
            this.btnMakeNewSubj.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeNewSubj.Name = "btnMakeNewSubj";
            this.btnMakeNewSubj.Size = new System.Drawing.Size(71, 45);
            this.btnMakeNewSubj.TabIndex = 289;
            this.btnMakeNewSubj.Text = "Tilføj";
            this.btnMakeNewSubj.UseVisualStyleBackColor = true;
            this.btnMakeNewSubj.Visible = false;
            this.btnMakeNewSubj.Click += new System.EventHandler(this.btnMakeNewSubj_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label48.Location = new System.Drawing.Point(74, 71);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(335, 18);
            this.label48.TabIndex = 281;
            this.label48.Text = "Tjenesteydelser og efteruddannelser";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(399, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 14);
            this.label10.TabIndex = 344;
            this.label10.Text = "Indtast tlf nr.:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 670);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "LawHouse";
            this.TabControl.ResumeLayout(false);
            this.tabCases.ResumeLayout(false);
            this.pnlAllOpenCases.ResumeLayout(false);
            this.pnlAllOpenCases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDataGrid)).EndInit();
            this.pnlUpdateEditServices.ResumeLayout(false);
            this.pnlUpdateEditServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.pnlActivateServiceBoxes.ResumeLayout(false);
            this.pnlActivateServiceBoxes.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlAddSubjectToEmp.ResumeLayout(false);
            this.pnlAddSubjectToEmp.PerformLayout();
            this.pnlAddUpdateEmplFields.ResumeLayout(false);
            this.pnlAddUpdateEmplFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmplGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabShowAllProServ.ResumeLayout(false);
            this.tabShowAllProServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeServicesP)).EndInit();
            this.tabProvServices.ResumeLayout(false);
            this.tabProvServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlAddViewSubjects.ResumeLayout(false);
            this.pnlAddViewSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabCases;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabProvServices;
        private System.Windows.Forms.Button DeleteEmpl;
        private System.Windows.Forms.Button UpdateEmpl;
        private System.Windows.Forms.DataGridView EmplGridView;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.Button btnDeleteSubj;
        private System.Windows.Forms.Button btnUpdateSubj;
        private System.Windows.Forms.Button btnMakeNewSubj;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.ComboBox CrCaseServiceCom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnNewCase;
        private System.Windows.Forms.DateTimePicker CrCasetimeP;
        private System.Windows.Forms.ComboBox CrCaseAdvokat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox CrCaseTimeUsed;
        private System.Windows.Forms.TextBox CrCasePrice;
        private System.Windows.Forms.TextBox CrCaseEndDato;
        private System.Windows.Forms.TextBox CrCaseName;
        private System.Windows.Forms.Button NewClientBtn;
        private System.Windows.Forms.TextBox NewClientTelef;
        private System.Windows.Forms.TextBox NewClientMail;
        private System.Windows.Forms.TextBox NewClientPost;
        private System.Windows.Forms.TextBox NewClientAdress;
        private System.Windows.Forms.TextBox NewClientLName;
        private System.Windows.Forms.TextBox NewClientfName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox NewClientCprNo;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAnsatte;
        private System.Windows.Forms.Button btnActivateAddEmpFields;
        private System.Windows.Forms.Panel pnlAddUpdateEmplFields;
        private System.Windows.Forms.TextBox NEmplPosition;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox NEmplMoney;
        private System.Windows.Forms.DateTimePicker NEmplStartDate;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox NETlfTxt;
        private System.Windows.Forms.TextBox NEEmailTxt;
        private System.Windows.Forms.TextBox NEPostTxt;
        private System.Windows.Forms.TextBox NEAdressTxt;
        private System.Windows.Forms.TextBox NELnameTxt;
        private System.Windows.Forms.TextBox NEFnameTxt;
        private System.Windows.Forms.TextBox NECprTxt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button NewEmplButt;
        private System.Windows.Forms.Label lblTilfNyMeda;
        private System.Windows.Forms.Button btnActivateUpdEmpFields;
        private System.Windows.Forms.Label lblOpdaterMedInfo;
        private System.Windows.Forms.Button btnEditEmpCancel;
        private System.Windows.Forms.Panel pnlAddSubjectToEmp;
        private System.Windows.Forms.Button SpecialBtn;
        private System.Windows.Forms.ComboBox LServInsertCom;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ListBox lstBoxShowEmpSpecialization;
        private System.Windows.Forms.Button btnDelSubjFromEmp;
        private System.Windows.Forms.TabPage tabShowAllProServ;
        private System.Windows.Forms.DataGridView GridEmployeeServicesP;
        private System.Windows.Forms.Button btnShowPrServices;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.ComboBox cmbBoxFindEmplID;
        private System.Windows.Forms.Panel pnlUpdateEditServices;
        private System.Windows.Forms.Button btnActivateAddServiceBoxes;
        private System.Windows.Forms.Panel pnlActivateServiceBoxes;
        private System.Windows.Forms.RichTextBox txtServiceComment;
        private System.Windows.Forms.TextBox txtServiceKm;
        private System.Windows.Forms.TextBox txtHoursService;
        private System.Windows.Forms.DateTimePicker ServiceDateTimePicker;
        private System.Windows.Forms.ComboBox ServiceEmploeeCombox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCaseName;
        private System.Windows.Forms.Button BtnDeleteExsService;
        private System.Windows.Forms.Button BtnAddNewService;
        private System.Windows.Forms.Button BtnUpdateExsService;
        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km;
        private System.Windows.Forms.Label lblHeaderServices;
        private System.Windows.Forms.Panel pnlAllOpenCases;
        private System.Windows.Forms.Button CalculatePrice;
        private System.Windows.Forms.DateTimePicker EndCaseTimePictxt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.ComboBox RespEmpCombo;
        private System.Windows.Forms.Button ClosedCaseBut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView CaseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegotiatedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resp_empl;
        private System.Windows.Forms.TextBox TotalPricetxt;
        private System.Windows.Forms.Label lblAllActiveCases;
        private System.Windows.Forms.TextBox NegPricetxt;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.Button btnReturnToCasesPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursUsed;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Button btnActivatAddSubjects;
        private System.Windows.Forms.Panel pnlAddViewSubjects;
        private System.Windows.Forms.TextBox txtAddViewSubjectFixPrc;
        private System.Windows.Forms.TextBox TxtAddViewSubjectTimeEst;
        private System.Windows.Forms.TextBox txtAddViewSubjectHoursEst;
        private System.Windows.Forms.TextBox txtAddViewSubjectName;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button btnCnclSubjectEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblTotalKmDriven;
        private System.Windows.Forms.Label lblTotalHoursUsed;
        private System.Windows.Forms.Label totalKmDrivenInPeriod;
        private System.Windows.Forms.Label totalHoursUseForPeriod;
        private System.Windows.Forms.LinkLabel lLblHelpCaseServices2Tab;
        private System.Windows.Forms.LinkLabel lLblHelpSubjectsTab;
        private System.Windows.Forms.LinkLabel lLblHelpEmployeesTab;
        private System.Windows.Forms.LinkLabel lLblHelpAddClientCaseTab;
        private System.Windows.Forms.LinkLabel lLblHelpEmployeeServicesTab;
        private System.Windows.Forms.LinkLabel lLblHelpViewAllCasesTab;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnShowClosedCases;
        private System.Windows.Forms.Button btnReturnToShowOpenCases;
        private System.Windows.Forms.Label lblDateToo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblChooseEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CprNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TlfNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseProvidedServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PServiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PServiceHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn PServiceKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PServiceComment;
        private System.Windows.Forms.TextBox txtShowNewClientIdHere;
        private System.Windows.Forms.Button btnCancelCreateNewCase;
        private System.Windows.Forms.Button btnFindExistingClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAllCLosedCases;
        private System.Windows.Forms.Button btnGetCasesbyClient;
        private System.Windows.Forms.TextBox tlfTxtForCases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}

