using BusinessLogic;
using DataAccess;
using System;
using System.Windows.Forms;

namespace LawHouseTabForm
{
    public partial class MainForm : Form , IUserInterface
    {

        private CaseHandler _caseHandler;
        private ClientHandler _clientHandler;
        private EmployeeHandler _employeeHandler;
        private SubjectHandler _subjectHandler;
        private ProvidedServiceHandler _pServiceHandler;

        private int CaseId { get; set; }
        public int EmployeeID { get; set; }
        public int SubjectId { get; set; }
        public int ClientId { get; set; }
        private bool IsActive { get; set; }

        public MainForm()
        {
            InitializeComponent();

            _caseHandler = new CaseHandler();
            _clientHandler = new ClientHandler();
            _employeeHandler = new EmployeeHandler();
            _pServiceHandler = new ProvidedServiceHandler();
            _subjectHandler = new SubjectHandler();

            FillComboBoxes();
            ActivateGetCasesGrid();
            EmplGridStart();
            GetServices();
        }

        #region Show All in Form
        
        #region FillComboTxt

        public void FillComboBoxes()
        {
            foreach (var l1 in _employeeHandler.GetEmployees())
            {
                if (l1.Position == "Advokat")
                {
                    RespEmpCombo.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                    CrCaseAdvokat.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                }
            }

            foreach (var s1 in _subjectHandler.GetSubjects())
            {
                CrCaseServiceCom.Items.Add($"{s1.Id} {s1.Name}");
            }

            foreach (var m1 in _employeeHandler.GetEmployees())
            {
                ServiceEmploeeCombox.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
                cmbBoxFindEmplID.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
            }


            foreach (var s1 in _subjectHandler.GetSubjects())
            {
                LServInsertCom.Items.Add($"{s1.Id} {s1.Name}");
            }
        }

        private void showSpecializationInListbox(int EmployeeID)
        {
            foreach (var subject in _subjectHandler.GetEmployeeSubjectsById(EmployeeID))
            {
                lstBoxShowEmpSpecialization.Items.Add($"{subject.Id} {subject.Name}").ToString();
            }
        }

        #endregion

        #region ReadOnly

        private void CrCaseServiceCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void RespEmpCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void CrCaseAdvokat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }


        #endregion

        #region ClearTxt

        private void ClearTxtBoxs()
        {
            RespEmpCombo.Text = "";
            NegPricetxt.Clear();
            TotalPricetxt.Clear();
        }

        private void ClearAddUpdateServiceBox()
        {
            ServiceEmploeeCombox.Text = "";
            ServiceDateTimePicker.Value = DateTime.Now;
            txtHoursService.Text = "0";
            txtServiceKm.Text = "0";
            txtServiceComment.Text = "";
            BtnDeleteExsService.Visible = false;
            BtnUpdateExsService.Visible = false;
        }

        private void ClearTxt()
        {
            NECprTxt.Clear();
            NEFnameTxt.Clear();
            NELnameTxt.Clear();
            NEAdressTxt.Clear();
            NEPostTxt.Clear();
            NEEmailTxt.Clear();
            NETlfTxt.Clear();
            NEmplStartDate.Text = DateTime.Now.ToShortDateString();
            NEmplPosition.Clear();
            NEmplMoney.Clear();
        }

        private void ClearNewClientTXT()
        {
            NewClientCprNo.Clear();
            NewClientfName.Clear();
            NewClientLName.Clear();
            NewClientAdress.Clear();
            NewClientPost.Clear();
            NewClientMail.Clear();
            NewClientTelef.Clear();
        }


        #endregion

        #region FillDataGrid

        private void ActivateGetCasesGrid(bool IsActive = true)
        {
            foreach (var c1 in _caseHandler.GetCases(IsActive))
            {
                int n = CaseDataGrid.Rows.Add();
                CaseDataGrid.Rows[n].Cells[0].Value = c1.Id;
                CaseDataGrid.Rows[n].Cells[1].Value = c1.Name;
                CaseDataGrid.Rows[n].Cells[2].Value = c1.Client;
                CaseDataGrid.Rows[n].Cells[3].Value = c1.StartDate.ToShortDateString();
                CaseDataGrid.Rows[n].Cells[4].Value = c1.EndDate.ToShortDateString();
                CaseDataGrid.Rows[n].Cells[5].Value = c1.Subject;
                CaseDataGrid.Rows[n].Cells[6].Value = c1.HoursEstimate;
                CaseDataGrid.Rows[n].Cells[7].Value = c1.NegPrice;
                CaseDataGrid.Rows[n].Cells[8].Value = c1.TotalPrice;
                CaseDataGrid.Rows[n].Cells[9].Value = c1.RespEmployee;
            }
        }

        private void ShowProvidedServicesOnGrid()
        {
            ServiceDataGrid.Rows.Clear();

            foreach (var service in _pServiceHandler.GetProvidedServices(CaseId))
            {
                int n = ServiceDataGrid.Rows.Add();
                ServiceDataGrid.Rows[n].Cells[0].Value = service.Id;
                ServiceDataGrid.Rows[n].Cells[1].Value = service.EmployeeName;
                ServiceDataGrid.Rows[n].Cells[2].Value = service.Date.ToShortDateString();
                ServiceDataGrid.Rows[n].Cells[3].Value = service.Comment;
                ServiceDataGrid.Rows[n].Cells[4].Value = service.Hours;
                ServiceDataGrid.Rows[n].Cells[5].Value = service.Km;
            }
        }

        private void EmplGridStart()
        {
            foreach (var c1 in _employeeHandler.GetEmployees())
            {
                int n = EmplGridView.Rows.Add();
                EmplGridView.Rows[n].Cells[0].Value = c1.Id;
                EmplGridView.Rows[n].Cells[1].Value = c1.CprNo;
                EmplGridView.Rows[n].Cells[2].Value = c1.FirstName;
                EmplGridView.Rows[n].Cells[3].Value = c1.LastName;
                EmplGridView.Rows[n].Cells[4].Value = c1.Address;
                EmplGridView.Rows[n].Cells[5].Value = c1.PostNo;
                EmplGridView.Rows[n].Cells[6].Value = c1.Email;
                EmplGridView.Rows[n].Cells[7].Value = c1.TlfNo;
                EmplGridView.Rows[n].Cells[8].Value = c1.StartDate.ToShortDateString();
                EmplGridView.Rows[n].Cells[9].Value = c1.Position;
                EmplGridView.Rows[n].Cells[10].Value = c1.PayRatePrHour;
            }
        }

        private void GetServices()
        {
            foreach (var c1 in _subjectHandler.GetSubjects())
            {
                int n = ServiceGridView.Rows.Add();
                ServiceGridView.Rows[n].Cells[0].Value = c1.Id;
                ServiceGridView.Rows[n].Cells[1].Value = c1.Name;
                ServiceGridView.Rows[n].Cells[2].Value = c1.HoursEstimate;
                ServiceGridView.Rows[n].Cells[3].Value = c1.TimeEstimate;
                ServiceGridView.Rows[n].Cells[4].Value = c1.Price;
            }
        }

        #endregion

        private void search_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CaseDataGrid.RowCount; i++)
            {
                CaseDataGrid.Rows[i].Selected = false;
                for (int j = 0; j < CaseDataGrid.ColumnCount; j++)
                {
                    if (CaseDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (CaseDataGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            CaseDataGrid.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        //Ansatte
        private void cmbBoxFindEmplID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _employeeHandler.GetEmployees())
            {
                string[] getEmployeeId =
                    cmbBoxFindEmplID.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                this.EmployeeID = Convert.ToInt32(getEmployeeId[0]);
            }
        }

        #endregion Show All in Form

        #region Abne sager

        private void btnActivateAddServiceBoxes_Click(object sender, EventArgs e)
        {
            ClearAddUpdateServiceBox();

            BtnDeleteExsService.Visible = false;
            BtnUpdateExsService.Visible = false;
            pnlActivateServiceBoxes.Visible = true;
            BtnAddNewService.Visible = true;
        }

        private void BtnAddNewService_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(ServiceDateTimePicker.Value.ToShortDateString());
                int hours = txtHoursService.Text != null ? Convert.ToInt32(txtHoursService.Text) : 0;
                int km = txtServiceKm.Text != null ? Convert.ToInt32(txtServiceKm.Text) : 0;
                string comment = txtServiceComment.Text;
                string[] names =
                    ServiceEmploeeCombox.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int respEmpl = Convert.ToInt32(names[0]);
                int i = _pServiceHandler.NewProvidedService(this.CaseId, date, hours, km, comment, respEmpl);
                MessageBox.Show("Ydelses id: " + i.ToString() + " er tilføjet til sagen");
                ClearAddUpdateServiceBox();
                ServiceDataGrid.Rows.Clear();
                ShowProvidedServicesOnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl - Ny service ikke tilføjet");
            }
        }

        private void BtnUpdateExsService_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DateTime date = Convert.ToDateTime(ServiceDateTimePicker.Value.ToShortDateString());
                int houres = Convert.ToInt32(txtHoursService.Text);
                int km = Convert.ToInt32(txtServiceKm.Text);
                string comment = txtServiceComment.Text;
                int i = _pServiceHandler.UpdateProvidedService(id, houres, km, date, comment);
                MessageBox.Show(i.ToString());
                ClearAddUpdateServiceBox();
                ServiceDataGrid.Rows.Clear();
                ShowProvidedServicesOnGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg ydelse først");
            }
        }

        private void BtnDeleteExsService_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", "Sletter ydelsen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = _pServiceHandler.DeleteProvidedService(id);
                    MessageBox.Show(i.ToString());
                    ClearAddUpdateServiceBox();
                    ServiceDataGrid.Rows.Clear();
                    ShowProvidedServicesOnGrid();
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg ydelse først");
            }

        }

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            CaseId = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            string name = CaseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            lblCaseName.Text = $"Nr.{CaseId}, {name}";
            ShowProvidedServicesOnGrid();
            pnlUpdateEditServices.Visible = true;
            }
            catch (Exception exception)
            {
            }
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag, der skal slettes");
            }
            else
            {
                
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Sletter Sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = _caseHandler.DeleteCase(id);
                    MessageBox.Show(i.ToString());
                    ClearTxtBoxs();
                    CaseDataGrid.Rows.Clear();
                    ActivateGetCasesGrid();
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }
        }

        private void UpdateButt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag, der skal opdateres");
            }
            else
            {
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                decimal negPrice = Convert.ToDecimal(NegPricetxt.Text);
                //string respEmpl = RespEmpCombo.Text;
                string[] getRespEmpId = RespEmpCombo.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int respEmpId = Convert.ToInt32(getRespEmpId[0]);
                int i = _caseHandler.UpdateCase(id, negPrice, respEmpId);
                if (i == 1)
                {
                    MessageBox.Show($"Sagen nr. {id} er blevet opdateret");
                }
                else
                {
                    MessageBox.Show("Sagen kunne ikke opdateres. Prøv igen");
                }

            }

        }

        private void CalculatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(CaseDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag for prisberegningen");
            }
            else
            {
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);

                decimal price = _pServiceHandler.GetPrice(id, negPrice);
                ClosedCaseBut.Visible = true;
                TotalPricetxt.Text = price.ToString();
            }

            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("Vælg en sag først");
            }
           
        }

        private void ClosedCaseBut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", "Afslutter sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                    decimal totalPrice = Convert.ToDecimal(TotalPricetxt.Text);
                    DateTime endDate = Convert.ToDateTime(EndCaseTimePictxt.Value.ToShortDateString());
                    int i = _caseHandler.CloseCase(id, totalPrice, endDate);
                    MessageBox.Show(i.ToString());
                    ClearTxtBoxs();
                    CaseDataGrid.Rows.Clear();
                    ActivateGetCasesGrid();
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg en sag først");

            }
        }

        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
                string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                RespEmpCombo.Text = respEmp;
                NegPricetxt.Text = negPrice.ToString();
            }
            catch (Exception exception)
            {
            }
        }

        private void btnReturnToCasesPnl_Click(object sender, EventArgs e)
        {
            pnlUpdateEditServices.Visible = false;
            ServiceDataGrid.Rows.Clear();
            ClearAddUpdateServiceBox();
            pnlActivateServiceBoxes.Visible = false;
        }

        #endregion

        #region Tjenesteydelser og efteruddannelse

        private void ServiceDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ClearAddUpdateServiceBox();
                ServiceEmploeeCombox.Text = ServiceDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                ServiceDateTimePicker.Text = ServiceDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                txtServiceComment.Text = ServiceDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                txtHoursService.Text = ServiceDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                txtServiceKm.Text = ServiceDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                pnlActivateServiceBoxes.Visible = true;
                BtnDeleteExsService.Visible = true;
                BtnUpdateExsService.Visible = true;
            }
            catch (Exception exception)
            {
            }
        }


        private void SubjectGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SubjectId = Convert.ToInt32(ServiceGridView.SelectedRows[0].Cells[0].Value);
                txtAddViewSubjectName.Text = ServiceGridView.SelectedRows[0].Cells[1].Value.ToString();
                txtAddViewSubjectHoursEst.Text = ServiceGridView.SelectedRows[0].Cells[2].Value.ToString();
                TxtAddViewSubjectTimeEst.Text = ServiceGridView.SelectedRows[0].Cells[3].Value.ToString();
                txtAddViewSubjectFixPrc.Text = ServiceGridView.SelectedRows[0].Cells[4].Value.ToString();

                pnlAddViewSubjects.Visible = true;
                btnUpdateSubj.Visible = true;
                btnDeleteSubj.Visible = true;
                btnMakeNewSubj.Visible = false;
                btnActivatAddSubjects.Visible = false;
                btnCnclSubjectEdit.Visible = true;
            }
            catch (Exception exception)
            {
            }
        }

        #endregion

        #region TabAnsatte

        //ansatte
        private void EmlGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SendUpdateEmployeeFieldsInfo();
                AddEmpBoxes(false);
                DeleteEmpl.Visible = true;
                UpdateEmpl.Visible = true;
            }
            catch (Exception exception)
            {
            }
        }

        //ID 
        private void NewEmplButt_Click(object sender, EventArgs e)
        {
            showAllEmployeeGrid();
            try
            {
                string cpr = NECprTxt.Text;
                string fName = NEFnameTxt.Text;
                string lName = NELnameTxt.Text;
                string address = NEAdressTxt.Text;
                int postNo = Convert.ToInt32(NEPostTxt.Text);
                string eMail = NEEmailTxt.Text;
                string tlf = NETlfTxt.Text;
                DateTime start = Convert.ToDateTime(NEmplStartDate.Value.ToShortDateString());
                string position = NEmplPosition.Text;
                decimal money = Convert.ToDecimal(NEmplMoney.Text);
                this.EmployeeID =
                    _employeeHandler.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position,
                        money);
                ClearTxt();
                EmplGridView.Rows.Clear();
                EmplGridStart();
            }
            catch (Exception exception)
            {
                MessageBox.Show("");
            }
        }

        private void showAllEmployeeGrid()
        {
            EmplGridView.Visible = true;
            lblAnsatte.Visible = true;

            btnActivateUpdEmpFields.Visible = true;
            btnActivateAddEmpFields.Visible = true;
            btnEditEmpCancel.Visible = false;
            NewEmplButt.Visible = false;
            UpdateEmpl.Visible = false;

            pnlAddUpdateEmplFields.Visible = false;
            pnlAddSubjectToEmp.Visible = false;
            btnDelSubjFromEmp.Visible = true;
        }

        private void UpdateEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = NEFnameTxt.Text;
                string lName = NELnameTxt.Text;
                string address = NEAdressTxt.Text;
                int postNo = Convert.ToInt32(NEPostTxt.Text);
                string eMail = NEEmailTxt.Text;
                string tlf = NETlfTxt.Text;
                DateTime start = Convert.ToDateTime(NEmplStartDate.Value.ToShortDateString());
                string position = NEmplPosition.Text;
                decimal money = Convert.ToDecimal(NEmplMoney.Text);
                _employeeHandler.UpdateEmployee(EmployeeID, fName, lName, address, postNo, eMail, tlf, position, money);
                ClearTxt();
                EmplGridView.Rows.Clear();
                EmplGridStart();

                showUpdtEmployeeBoxes();
                btnEditEmpCancel_Click(sender, e);
            }
            //exception
            catch (Exception exception)
            {
                MessageBox.Show("");
            }
        }

        private void showUpdtEmployeeBoxes()
        {

            NewEmplButt.Visible = false;
            UpdateEmpl.Visible = true;
            btnActivateAddEmpFields.Visible = true;
            btnActivateUpdEmpFields.Visible = true;
            pnlAddSubjectToEmp.Visible = false;
            btnEditEmpCancel.Visible = false;
           // lblAnsatte.Visible = true;
            lblOpdaterMedInfo.Visible = true;
            EmplGridView.Visible = false;
            btnDelSubjFromEmp.Visible = true;
        }


        private void DeleteEmpl_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(EmlGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", $"Sletter Sagen {EmployeeID}", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = _employeeHandler.CloseEmployee(EmployeeID);
                    MessageBox.Show(i.ToString());
                    ClearTxt();
                    EmplGridView.Rows.Clear();
                    EmplGridStart();
                    btnEditEmpCancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vælg en sag først");
            }

        }

        private void btnActivateAddEmpFields_Click(object sender, EventArgs e)
        {
            ClearTxt();
            AddEmpBoxes(true);
        }

        private void AddEmpBoxes(bool IsNewEmployee)
        {
            EmplGridView.Visible = false;
            lblAnsatte.Visible = false;
            btnEditEmpCancel.Visible = true;            
            btnActivateAddEmpFields.Visible = false;            
            btnActivateUpdEmpFields.Visible = false;
            pnlAddUpdateEmplFields.Visible = true;
            pnlAddSubjectToEmp.Visible = true;

            if (IsNewEmployee)
            {
                lblTilfNyMeda.Visible = true;  
                lblOpdaterMedInfo.Visible = false;
                NewEmplButt.Visible = true;
            }
            else
            {
                lblTilfNyMeda.Visible = false;                
                lblOpdaterMedInfo.Visible = true;
                UpdateEmpl.Visible = true;
                DeleteEmpl.Visible = true;
            }
        }

        private void btnActivateUpdEmpFields_Click(object sender, EventArgs e)
        {
            SendUpdateEmployeeFieldsInfo();
            AddEmpBoxes(false);
        }

        private void SendUpdateEmployeeFieldsInfo()
        {//try
            this.EmployeeID = Convert.ToInt32(EmplGridView.SelectedRows[0].Cells[0].Value);
            NECprTxt.Text = EmplGridView.SelectedRows[0].Cells[1].Value.ToString();
            NEFnameTxt.Text = EmplGridView.SelectedRows[0].Cells[2].Value.ToString();
            NELnameTxt.Text = EmplGridView.SelectedRows[0].Cells[3].Value.ToString();
            NEAdressTxt.Text = EmplGridView.SelectedRows[0].Cells[4].Value.ToString();
            NEPostTxt.Text = EmplGridView.SelectedRows[0].Cells[5].Value.ToString();
            NEEmailTxt.Text = EmplGridView.SelectedRows[0].Cells[6].Value.ToString();
            NETlfTxt.Text = EmplGridView.SelectedRows[0].Cells[7].Value.ToString();
            NEmplStartDate.Value = Convert.ToDateTime(EmplGridView.SelectedRows[0].Cells[8].Value.ToString());
            NEmplPosition.Text = EmplGridView.SelectedRows[0].Cells[9].Value.ToString();
            NEmplMoney.Text = EmplGridView.SelectedRows[0].Cells[10].Value.ToString();

            showSpecializationInListbox(EmployeeID);
        }

        private void btnEditEmpCancel_Click(object sender, EventArgs e)
        {
            EmplGridView.Visible = true;
            lblAnsatte.Visible = true;

            lblOpdaterMedInfo.Visible = false;
            lblTilfNyMeda.Visible = false;
            
            btnActivateUpdEmpFields.Visible = true;
            btnActivateAddEmpFields.Visible = true;
            NewEmplButt.Visible = false;
            UpdateEmpl.Visible = false;

            btnEditEmpCancel.Visible = false;
            pnlAddUpdateEmplFields.Visible = false;
            pnlAddSubjectToEmp.Visible = false;
            pnlAddUpdateEmplFields.Visible = false;
            pnlAddSubjectToEmp.Visible = false;
            DeleteEmpl.Visible = false;
            lstBoxShowEmpSpecialization.Items.Clear();

        }

        private void btnDelSubjFromEmp_Click(object sender, EventArgs e)
        {
            try
            {
            string getItem = lstBoxShowEmpSpecialization.SelectedItem.ToString();
            string[] getSubjectId = getItem.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int id = Convert.ToInt32(getSubjectId[0]);
            _employeeHandler.DeleteSubjectFromEmployee(EmployeeID, id);
            lstBoxShowEmpSpecialization.Items.Clear();
            showSpecializationInListbox(EmployeeID);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vælg en ydelse først");
            }
           
        }

        private void AddSubjectToEmplBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] getServiceId =
                    LServInsertCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int subjectId = Convert.ToInt32(getServiceId[0]);
                _employeeHandler.AddSubjectToEmployee(EmployeeID, subjectId);
                lstBoxShowEmpSpecialization.Items.Clear();
                showSpecializationInListbox(EmployeeID);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vælg en ydelse/ansatte først");

            }

        }


        #endregion

        #region Tilføj klient og sag

        private void NewClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cpr = NewClientCprNo.Text;
                string fName = NewClientfName.Text;
                string lName = NewClientLName.Text;
                string address = NewClientAdress.Text;
                int postNo = Convert.ToInt32(NewClientPost.Text);
                string eMail = NewClientMail.Text;
                string tlf = NewClientTelef.Text;
                this.ClientId = _clientHandler.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
                MessageBox.Show("Klient med id nummer: " + ClientId.ToString() + " er oprettet");
                ClearNewClientTXT();

                txtShowNewClientIdHere.Text = ClientId.ToString();
                btnNewCase.Visible = true;

            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("");

            }

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                string cpr = NewClientCprNo.Text;
                string fName = NewClientfName.Text;
                string lName = NewClientLName.Text;
                string address = NewClientAdress.Text;
                int postNo = Convert.ToInt32(NewClientPost.Text);
                string eMail = NewClientMail.Text;
                string tlf = NewClientTelef.Text;

                //HUSK SØGEFUNKTION DER SENDER CLIENTID TIL THIS.ClientId 
                _clientHandler.UpdateClient(this.ClientId, fName, lName, cpr, address, postNo, eMail, tlf);
                txtShowNewClientIdHere.Text = ClientId.ToString();
                btnNewCase.Visible = true;
            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("");
            }

            // her i Update mangler vi int id. Jeg sætter bare 1-tal i parenteser for at fjerne fejl.
            // skal lave en metode der henter id via tlf nummer.. Andrey kigger på det. 
            //TRY CATCH FOR SIKKERHEDS SKYLD
        }

        private void btnFindExistingClient_Click(object sender, EventArgs e)
        {
            string phoneNbr = NewClientTelef.Text;
            var client = _clientHandler.GetClient(phoneNbr);

            if (client.TlfNo == string.Empty)
            {
                MessageBox.Show("Klienten eksisterer ikke i vores database - opret ny klient");


            }
            else
            {
                NewClientCprNo.Text = client.CprNo;
                NewClientfName.Text = client.FirstName;
                NewClientLName.Text = client.LastName;
                NewClientAdress.Text = client.Address;
                NewClientPost.Text = client.PostNo.ToString();
                NewClientMail.Text = client.Email;
                NewClientTelef.Text = client.TlfNo;
                this.ClientId = client.Id;

                txtShowNewClientIdHere.Text = ClientId.ToString();
                btnNewCase.Visible = true;


                btnFindExistingClient.Visible = false;
                btnUpdateClient.Visible = true;
            }
        }

            private void NewCaseButt_Click(object sender, EventArgs e)
        {
            try
            {                
                string caseName = CrCaseName.Text;
                string[] getServoceId =
                    CrCaseServiceCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int serviceId = Convert.ToInt32(getServoceId[0]);
                DateTime startTime = Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString());
                string[] getAdvoketId =
                    CrCaseAdvokat.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int respEmplId = Convert.ToInt32(getAdvoketId[0]);
                decimal negoPrice = Convert.ToInt32(CrCasePrice.Text);
                _caseHandler.NewCase(caseName, this.ClientId, serviceId, startTime, respEmplId, negoPrice);
            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("");
            }
        }

        private void CrCaseServiceCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _subjectHandler.GetSubjects())
            {
                string[] getServoceId =
                    CrCaseServiceCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string serviceId = getServoceId[0];

                if (s.Id.ToString() == serviceId)
                {
                    CrCasePrice.Text = s.Price.ToString();
                    CrCaseTimeUsed.Text = s.HoursEstimate.ToString();
                    CrCaseEndDato.Text = TimeSpan.FromDays((s.TimeEstimate)).ToString();
                }
            }
        }

        #endregion

        #region Alle ydelser på ansat

        private void btnShowPrServices_Click(object sender, EventArgs e)
        {
            getPrServicesByEmployee();
            showTotalKmAndHours();
        }

        private void showTotalKmAndHours()
        {
            int[] total = _pServiceHandler.GetworkDone();
            totalHoursUseForPeriod.Text = total[1].ToString();
            totalKmDrivenInPeriod.Text = total[0].ToString();
        }

        private void getPrServicesByEmployee()
        {
            try
            {
                GridEmployeeServicesP.Rows.Clear();
                DateTime startDate = Convert.ToDateTime(dateTimeFrom.Value.ToShortDateString());
                DateTime endDate = Convert.ToDateTime(dateTimeTo.Value.ToShortDateString());
                foreach (var ps in _pServiceHandler.GetProvidedServicesByEmplId(this.EmployeeID, startDate, endDate))
                {
                    int n = GridEmployeeServicesP.Rows.Add();
                    GridEmployeeServicesP.Rows[n].Cells[0].Value = ps.CaseID;
                    GridEmployeeServicesP.Rows[n].Cells[1].Value = ps.Date.ToShortDateString();
                    GridEmployeeServicesP.Rows[n].Cells[2].Value = ps.Hours;
                    GridEmployeeServicesP.Rows[n].Cells[3].Value = ps.Km;
                    GridEmployeeServicesP.Rows[n].Cells[4].Value = ps.Comment;
                }

            }
            catch (Exception e)
            {
                //exception
                MessageBox.Show("");
            }

        }

        #endregion


        private void btnActivatAddSubjects_Click(object sender, EventArgs e)
        {
            btnMakeNewSubj.Visible = true;
            pnlAddViewSubjects.Visible = true;
            btnCnclSubjectEdit.Visible = true;
        }

        private void btnMakeNewSubj_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddViewSubjectName.Text;
                int hours = Convert.ToInt32(txtAddViewSubjectHoursEst.Text);
                int time = Convert.ToInt32(TxtAddViewSubjectTimeEst.Text);
                decimal price = Convert.ToDecimal(txtAddViewSubjectFixPrc.Text);
                _subjectHandler.NewSubject(name, hours, time, price);
            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("");
            }

        }

        private void btnUpdateSubj_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddViewSubjectName.Text;
                int hours = Convert.ToInt32(txtAddViewSubjectHoursEst.Text);
                int time = Convert.ToInt32(TxtAddViewSubjectTimeEst.Text);
                decimal price = Convert.ToDecimal(txtAddViewSubjectFixPrc.Text);
                _subjectHandler.UpdateSubject(SubjectId, name, hours, time, price);
                ServiceGridView.Rows.Clear();
                GetServices();
            }
            catch (Exception exception)
            {
                //exception
                MessageBox.Show("");
            }

        }

        private void btnDeleteSubj_Click(object sender, EventArgs e)
        {
            //try
            //{
             _subjectHandler.DeleteSubject(SubjectId);
            //}
            //catch (Exception exception)
            //{
            //    //exception
            //    MessageBox.Show("");
            //}
            
        }

        private void btnCnclSubjectEdit_Click(object sender, EventArgs e)
        {
            pnlAddViewSubjects.Visible = false;
            btnDeleteSubj.Visible = false;
            btnActivatAddSubjects.Visible = true;
            btnMakeNewSubj.Visible = false;
            btnUpdateSubj.Visible = false;
            txtAddViewSubjectFixPrc.Clear();
            txtAddViewSubjectHoursEst.Clear();
            txtAddViewSubjectName.Clear();
            TxtAddViewSubjectTimeEst.Clear();

            
        }

        private void btnShowClosedCases_Click(object sender, EventArgs e)
        {
            
            CaseDataGrid.Rows.Clear();
            ActivateGetCasesGrid(false);
            btnShowClosedCases.Visible = false;
            btnReturnToShowOpenCases.Visible = true;
            
        }

        private void btnReturnToShowOpenCases_Click(object sender, EventArgs e)
        {
            
            CaseDataGrid.Rows.Clear();
            ActivateGetCasesGrid(true);
            btnShowClosedCases.Visible = true;
            btnReturnToShowOpenCases.Visible = false;
        }

        ///// <summary>
        ///// Tjekker tekstbokse for indtastningsfejl
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
        //        e.Handled = true;
        //}

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = TabControl.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)
            {
                if (selectedTab.Name == tabProvServices.Name || selectedTab.Name == tabCases.Name
                                                             || selectedTab.Name == tabEmployees.Name)
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = string.Empty;
                    }

                    if (ctrl is ComboBox)
                    {
                        (ctrl as ComboBox).Text = string.Empty;
                    }
                    if (ctrl is DateTimePicker)
                    {
                        (ctrl as DateTimePicker).Value = DateTime.Now;
                    }
                }
                else
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = string.Empty;
                    }

                    if (ctrl is Label)
                    {
                        totalHoursUseForPeriod.Text = string.Empty;
                        totalKmDrivenInPeriod.Text = string.Empty;
                        lblCaseName.Text = string.Empty;
                    }

                    if (ctrl is ComboBox)
                    {
                        (ctrl as ComboBox).Text = string.Empty;
                    }
                    if (ctrl is DateTimePicker)
                    {
                        (ctrl as DateTimePicker).Value = DateTime.Now;
                    }
                    if (ctrl is DataGridView)
                    {
                        (ctrl as DataGridView).Rows.Clear();
                    }
                }
            }
        }

    }
}
