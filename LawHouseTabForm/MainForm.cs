using BusinessLogic;
using DataAccess;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LawHouseTabForm
{
    public partial class MainForm : Form, IUserInterface
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
            ActivateGetClientsGrid();
            EmplGridStart();
            GetServices();

            clientsDataGrid.Font = new System.Drawing.Font("Verdana", 10f);
            CaseDataGrid.Font = new System.Drawing.Font("Verdana", 10f);
            ServiceDataGrid.Font = new System.Drawing.Font("Verdana", 10f);
            ServiceGridView.Font = new System.Drawing.Font("Verdana", 10f);
            GridEmployeeServicesP.Font = new System.Drawing.Font("Verdana", 10f);
            EmplGridView.Font = new System.Drawing.Font("Verdana", 10f);
        }

        #region Show All in Form

        #region FillComboTxt

        private void FillComboBoxes()
        {
            FillAdvokatEmployeeComBox();
            FillCrCaseServiceCom();
            FillEmployeeComBox();
            FillLServInsertCom();
        }

        private void FillAdvokatEmployeeComBox()
        {
            RespEmpCombo.Items.Clear();
            CrCaseAdvokat.Items.Clear();
            foreach (var l1 in _employeeHandler.GetEmployees())
            {
                if (l1.Position == "Advokat")
                {
                    RespEmpCombo.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                    CrCaseAdvokat.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                }
            }
        }

        private void FillEmployeeComBox()
        {
            ServiceEmploeeCombox.Items.Clear();
            cmbBoxFindEmplID.Items.Clear();
            foreach (var m1 in _employeeHandler.GetEmployees())
            {
                ServiceEmploeeCombox.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
                cmbBoxFindEmplID.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
            }
        }

        private void FillCrCaseServiceCom()
        {
            CrCaseServiceCom.Items.Clear();
            foreach (var s1 in _subjectHandler.GetSubjects())
            {
                CrCaseServiceCom.Items.Add($"{s1.Id} {s1.Name}");
            }
        }

        public void FillLServInsertCom()
        {
            LServInsertCom.Items.Clear();
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

        #region TxtBoks Check

        private void NegPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == (char) Keys.Oemcomma)
                e.Handled = true;
        }

        private void TotalPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == (char) Keys.Oemcomma)
                e.Handled = true;
        }

        private void txtHoursService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void txtServiceKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void txtAddViewSubjectHoursEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void TxtAddViewSubjectTimeEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void txtAddViewSubjectFixPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == (char) Keys.Oemcomma)
                e.Handled = true;
        }

        private void NECprTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void NEPostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void NETlfTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void NEmplMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void NewClientCprNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
        private void NewClientPost_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
        private void NewClientTelef_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
        private void CrCasePrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == (char) Keys.Oemcomma)
                e.Handled = true;
        }
      
        #endregion

        #region ReadOnly
        private void cmbBoxFindEmplID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
        private void ServiceEmploeeCombox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void LServInsertCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void CrCaseServiceCom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void RespEmpCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void CrCaseAdvokat_KeyPress_1(object sender, KeyPressEventArgs e)
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
            txtClientID.Clear();
        }

        private void ClearNewCaseTxt()
        {
            txtShowNewClientIdHere.Clear();
            CrCaseName.Clear();
            CrCaseServiceCom.Text = "";
            CrCaseAdvokat.Text = "";
            CrCasePrice.Clear();
            CrCaseTimeUsed.Clear();
            CrCaseEndDato.Clear();
        }
        private void clearAllBoxesInpnlCreateUpdClient()
        {
            txtClientID.Clear();
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
            CaseDataGrid.Rows.Clear();
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

        private void ActivateGetClientsGrid(bool active = true)
        {
            foreach (var cl in _clientHandler.GetClients(active))
            {
                int n = clientsDataGrid.Rows.Add();
                clientsDataGrid.Rows[n].Cells[0].Value = cl.Id;
                clientsDataGrid.Rows[n].Cells[1].Value = cl.CprNo;
                clientsDataGrid.Rows[n].Cells[2].Value = cl.FirstName;
                clientsDataGrid.Rows[n].Cells[3].Value = cl.LastName;
                clientsDataGrid.Rows[n].Cells[4].Value = cl.Address;
                clientsDataGrid.Rows[n].Cells[5].Value = cl.PostNo;
                clientsDataGrid.Rows[n].Cells[6].Value = cl.Email;
                clientsDataGrid.Rows[n].Cells[7].Value = cl.TlfNo;
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
            ServiceGridView.Rows.Clear();
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
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = TabControl.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)
            {
                if (selectedTab.Name == tabProvServices.Name || selectedTab.Name == tabCases.Name
                    || selectedTab.Name == tabClients.Name || selectedTab.Name == tabEmployees.Name)
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

                    pnlUpdateEditServices.Visible = false;
                    ServiceDataGrid.Rows.Clear();
                    ClearAddUpdateServiceBox();
                    pnlActivateServiceBoxes.Visible = false;
                    pnlCreateNewCase.Visible = false;
                    pnlAddUpdateEmplFields.Visible = false;
                    pnlAddSubjectToEmp.Visible = false;
                    NewEmplButt.Visible = false;
                    UpdateEmpl.Visible = false;
                    DeleteEmpl.Visible = false;
                    btnEditEmpCancel.Visible = false;
                    EmplGridView.Visible = true;
                    btnActivateUpdEmpFields.Visible = true;
                    btnActivateAddEmpFields.Visible = true;
                    txtClientSearch.Visible = true;
                    btnClientSearch.Visible = true;
                    pnlCreateUpdateClient.Visible = false;
                    clientsDataGrid.Visible = true;
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
        
        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientsDataGrid.RowCount; i++)
            {
                clientsDataGrid.Rows[i].Selected = false;
                for (int j = 0; j < clientsDataGrid.ColumnCount; j++)
                {
                    if (clientsDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (clientsDataGrid.Rows[i].Cells[j].Value.ToString().Contains(txtClientSearch.Text))
                        {
                            clientsDataGrid.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void cmbBoxFindEmplID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _employeeHandler.GetEmployees())
            {
                string[] getEmployeeId =
                    cmbBoxFindEmplID.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                this.EmployeeID = Convert.ToInt32(getEmployeeId[0]);
            }
        }
        private void CrCaseServiceCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _subjectHandler.GetSubjects())
            {
                string[] getServoceId =
                    CrCaseServiceCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string serviceId = getServoceId[0];
                if (s.Id.ToString() == serviceId)
                {
                    CrCasePrice.Text = s.Price.ToString();
                    CrCaseTimeUsed.Text = s.HoursEstimate.ToString();
                    CrCaseEndDato.Text = (Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString()) +
                                          TimeSpan.FromDays(s.TimeEstimate)).ToShortDateString();
                }
            }
        }
        
        #endregion Show All in Form

        #region Sager

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
                _pServiceHandler.NewProvidedService(this.CaseId, date, hours, km, comment, respEmpl);
                MessageBox.Show("Ydelsen er tilføjet til sagen");
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
                MessageBox.Show($"Ydelse {id} er blevet opdateret");
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
                    MessageBox.Show($"Ydelse {id} er blevet slettet");
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
                    _caseHandler.DeleteCase(id);
                    MessageBox.Show($"Sage {id} er blevet slettet");
                    ClearTxtBoxs();
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
                string[] getRespEmpId = RespEmpCombo.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int respEmpId = Convert.ToInt32(getRespEmpId[0]);
                int i = _caseHandler.UpdateCase(id, negPrice, respEmpId);
                ActivateGetCasesGrid();
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
                MessageBox.Show(exception.Message);
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
                    MessageBox.Show($"Sage {id} er lukket");
                    ClearTxtBoxs();
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
            BtnAddNewService.Visible = false;
            ServiceDataGrid.Rows.Clear();
            ClearAddUpdateServiceBox();
            pnlActivateServiceBoxes.Visible = false;
        }
        private void btnShowClosedCases_Click(object sender, EventArgs e)
        {

            CaseDataGrid.Rows.Clear();
            ActivateGetCasesGrid(false);
            btnShowClosedCases.Visible = false;
            btnReturnToShowOpenCases.Visible = true;
            lblAllActiveCases.Visible = false;
            lblAllCLosedCases.Visible = true;

        }

        private void btnReturnToShowOpenCases_Click(object sender, EventArgs e)
        {

            CaseDataGrid.Rows.Clear();
            ActivateGetCasesGrid(true);
            btnShowClosedCases.Visible = true;
            btnReturnToShowOpenCases.Visible = false;
            lblAllActiveCases.Visible = true;
            lblAllCLosedCases.Visible = false;
        }

        private void btnGetCasesbyClient_Click(object sender, EventArgs e)
        {
            string phoneNbr = tlfTxtForCases.Text;
            var client = _clientHandler.GetClient(phoneNbr);
            int id = client.Id;
            if (client.Id == 0)
            {
                MessageBox.Show("Klienten eksisterer ikke i vores database");
                tlfTxtForCases.Text = string.Empty;
            }
            else
            {
                try
                {
                    CaseDataGrid.Rows.Clear();
                    foreach (var c1 in _caseHandler.GetCasesByClientId(id))
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
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnCreateNewCase_Click(object sender, EventArgs e)
        {
            try
            {
                string caseName = CrCaseName.Text;
                string[] getServiceId =
                    CrCaseServiceCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int serviceId = Convert.ToInt32(getServiceId[0]);
                DateTime startTime = Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString());
                string[] getAdvoketId =
                    CrCaseAdvokat.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int empId = Convert.ToInt32(getAdvoketId[0]);
                int clientId = Convert.ToInt32(txtShowNewClientIdHere.Text);
                if (CrCasePrice.Text == String.Empty)
                {
                    CrCasePrice.Text = 0.ToString();
                }
                decimal negoPrice = Convert.ToInt32(CrCasePrice.Text);
                _caseHandler.NewCase(caseName, startTime, negoPrice, serviceId, empId, clientId);
                ClearNewCaseTxt();
                ActivateGetCasesGrid();
                btnCancelCreateNewCase_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnCancelCreateNewCase_Click(object sender, EventArgs e)
        {
            pnlUpdateEditServices.Visible = false;
            ServiceDataGrid.Rows.Clear();
            ClearAddUpdateServiceBox();
            pnlUpdateEditServices.Visible = false;
            pnlAllOpenCases.Visible = true;
            pnlCreateNewCase.Visible = false;
        }

        private void btnActivateCreateNewCase_Click(object sender, EventArgs e)
        {
            pnlCreateNewCase.Visible = true;
            pnlUpdateEditServices.Visible = true;
            btnNewCase.Visible = true;
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
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Tjenesteydelser/efteruddannelse

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
                MessageBox.Show(exception.Message);
            }
        }

        private void btnActivatAddSubjects_Click(object sender, EventArgs e)
        {
            btnMakeNewSubj.Visible = true;
            pnlAddViewSubjects.Visible = true;
            btnCnclSubjectEdit.Visible = true;
            lblAddSubject.Visible = true; 
        }

        private void btnMakeNewSubj_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddViewSubjectName.Text;
                int hours = Convert.ToInt32(txtAddViewSubjectHoursEst.Text);
                int time = Convert.ToInt32(TxtAddViewSubjectTimeEst.Text);
                if (txtAddViewSubjectFixPrc.Text == string.Empty)
                {
                    txtAddViewSubjectFixPrc.Text = 0.ToString();
                }
                decimal price = Convert.ToDecimal(txtAddViewSubjectFixPrc.Text);
                _subjectHandler.NewSubject(name, hours, time, price);
                MessageBox.Show("Tjenesteydelser/Efteruddannelse er tilføjret");
                GetServices();
                FillLServInsertCom();
                FillCrCaseServiceCom();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
                MessageBox.Show($"Tjenesteydelser {name} er opdateret");
                ServiceGridView.Rows.Clear();
                GetServices();
                FillLServInsertCom();
                FillCrCaseServiceCom();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDeleteSubj_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubjectId == 0)
                {
                    MessageBox.Show("Vælg en tjenesteydelse først");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Er du sikker?", $"Sletter tjenesteydelse {SubjectId}", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _subjectHandler.DeleteSubject(SubjectId);
                        MessageBox.Show($"Tjenesteydelse {SubjectId} er slettet");
                        GetServices();
                        FillLServInsertCom();
                        FillCrCaseServiceCom();
                    }
                    else
                    {
                        MessageBox.Show("Annulleret");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            lblAddSubject.Visible = false;
            btnCnclSubjectEdit.Visible = false;
        }
        #endregion

        #region Medarbejdere

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
                FillEmployeeComBox();
                FillAdvokatEmployeeComBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
                string position = NEmplPosition.Text;
                decimal money = Convert.ToDecimal(NEmplMoney.Text);
                _employeeHandler.UpdateEmployee(EmployeeID, fName, lName, address, postNo, eMail, tlf, position, money);
                MessageBox.Show($"Medarbejder {fName} {lName} er opdateret");
                ClearTxt();
                EmplGridView.Rows.Clear();
                EmplGridStart();
                showUpdtEmployeeBoxes();
                btnEditEmpCancel_Click(sender, e);
                FillEmployeeComBox();
                FillAdvokatEmployeeComBox();
            }
            //exception
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
            lblOpdaterMedInfo.Visible = true;
            EmplGridView.Visible = false;
            btnDelSubjFromEmp.Visible = true;
        }
        
        private void DeleteEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", $"Sletter Sagen {EmployeeID}", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string fName = NEFnameTxt.Text;
                    string lName = NELnameTxt.Text;
                    _employeeHandler.CloseEmployee(EmployeeID);
                    MessageBox.Show($"Medarbejder {fName} {lName} er slettet");
                    ClearTxt();
                    EmplGridView.Rows.Clear();
                    EmplGridStart();
                    btnEditEmpCancel_Click(sender, e);
                    FillEmployeeComBox();
                    FillAdvokatEmployeeComBox();
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
        {
            try
            {
                EmployeeID = Convert.ToInt32(EmplGridView.SelectedRows[0].Cells[0].Value);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
               MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Klienter
        private void btnActivateUpdateClient_Click(object sender, EventArgs e)
        {
            txtClientSearch.Visible = false;
            btnClientSearch.Visible = false;
            pnlCreateUpdateClient.Visible = true;
            btnUpdateClient.Visible = true;
            NewClientBtn.Visible = false;
            lblUpdateClient.Visible = true;
            lblCreateNewClient.Visible = false;
            clientsDataGrid.Visible = false;
            pnlClientsButtons.Visible = false;
            lblSeeAllActiveClients.Visible = false;
            lblSeeAllDeactivatedClients.Visible = false;
            txtClientID.Visible = true;
            lblClientID.Visible = true;
            txtClientSearch.Visible = false;
            btnClientSearch.Visible = false;             

            if (String.IsNullOrEmpty(clientsDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en klient, der skal opdateres");
            }
            else
            {
                txtClientID.Text = clientsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                NewClientCprNo.Text = clientsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                NewClientfName.Text = clientsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                NewClientLName.Text = clientsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                NewClientAdress.Text = clientsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                NewClientPost.Text = clientsDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                NewClientMail.Text = clientsDataGrid.SelectedRows[0].Cells[6].Value.ToString();
                NewClientTelef.Text = clientsDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnActivateCreateNewClient_Click(object sender, EventArgs e)
        {
            txtClientSearch.Visible = false;
            btnClientSearch.Visible = false;
            pnlCreateUpdateClient.Visible = true;
            btnUpdateClient.Visible = false;
            NewClientBtn.Visible = true;
            lblCreateNewClient.Visible = true;
            lblUpdateClient.Visible = false;
            pnlClientsButtons.Visible = false;
            clientsDataGrid.Visible = false;
            lblSeeAllActiveClients.Visible = false;
            lblSeeAllDeactivatedClients.Visible = false;
            txtClientID.Visible = false;
            lblClientID.Visible = false; 
            txtClientSearch.Visible = false;
            btnClientSearch.Visible = false;
        }

        private void btnCloseAddUpdateClientPnl_Click(object sender, EventArgs e)
        {
            txtClientSearch.Visible = true;
            btnClientSearch.Visible = true;
            pnlCreateUpdateClient.Visible = false;
            clientsDataGrid.Rows.Clear();
            ActivateGetClientsGrid(true);
            lblSeeAllActiveClients.Visible = true;
            clientsDataGrid.Visible = true;
            pnlClientsButtons.Visible = true;
            btnShowAllActiveClients.Visible = false;
            btnShowDeactivatedClients.Visible = true; 
            clearAllBoxesInpnlCreateUpdClient();
            txtClientSearch.Visible = true;
            btnClientSearch.Visible = true;
        }

        private void btnShowDeactivatedClients_Click(object sender, EventArgs e)
        {
            clientsDataGrid.Rows.Clear();
            ActivateGetClientsGrid(false);
            btnShowDeactivatedClients.Visible = false;
            btnShowAllActiveClients.Visible = true;
            lblSeeAllActiveClients.Visible = false;
            lblSeeAllDeactivatedClients.Visible = true;
        }

        private void btnShowAllActiveClients_Click(object sender, EventArgs e)
        {
            clientsDataGrid.Rows.Clear();
            ActivateGetClientsGrid(true);
            btnShowDeactivatedClients.Visible = true;
            btnShowAllActiveClients.Visible = false;
            lblSeeAllActiveClients.Visible = true;
            lblSeeAllDeactivatedClients.Visible = false;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int ClientId = Convert.ToInt32(txtClientID.Text);
                string cpr = NewClientCprNo.Text;
                string fName = NewClientfName.Text;
                string lName = NewClientLName.Text;
                string address = NewClientAdress.Text;
                int postNo = Convert.ToInt32(NewClientPost.Text);
                string eMail = NewClientMail.Text;
                string tlf = NewClientTelef.Text;
                _clientHandler.UpdateClient(ClientId, fName, lName, cpr, address, postNo, eMail, tlf);
                MessageBox.Show($"Klient {fName} {lName} er opdateret");
                clientsDataGrid.Rows.Clear();
                ActivateGetClientsGrid();
                pnlCreateUpdateClient.Visible = false;
                clientsDataGrid.Visible = true;
                pnlClientsButtons.Visible = true;
                clearAllBoxesInpnlCreateUpdClient();
                btnShowDeactivatedClients.Visible = true;
                btnShowAllActiveClients.Visible = false;
                txtClientSearch.Visible = true;
                btnClientSearch.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Klienten er ikke blevet opdateret");
            }
        }

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
                MessageBox.Show($"Klient {fName}{lName} er oprettet");
                ClearNewClientTXT();
                clientsDataGrid.Rows.Clear();
                ActivateGetClientsGrid();
                pnlCreateUpdateClient.Visible = false;
                clientsDataGrid.Visible = true;
                pnlClientsButtons.Visible = true;
                clearAllBoxesInpnlCreateUpdClient();
                txtClientSearch.Visible = true;
                btnClientSearch.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                btnNewCase.Visible = false;
            }
        }
        
        private void btnDeleteClientInfo_Click(object sender, EventArgs e)
        {
         
            try
            {
                int ClientId = Convert.ToInt32(clientsDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker på at du vil deaktivere klient id " + ClientId + "? ", "Deaktiverer klienten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _clientHandler.CloseClient(ClientId);
                    MessageBox.Show("Klienten kan nu findes inde under 'ikke aktive klienter'");
                    clientsDataGrid.Rows.Clear();
                    ActivateGetClientsGrid(true);
                    btnShowAllActiveClients.Visible = false;
                    btnShowDeactivatedClients.Visible = true; 
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg klient først");
            }
        }

        private void lLblHelpViewAllCasesTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            ProcessStartInfo startInfo = new ProcessStartInfo(@"Manuals\ManualSager.pdf");
            Process.Start(startInfo);

        }

        private void lLblHelpAddClientCaseTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"Manuals\ManualKlienter.pdf");
            Process.Start(startInfo);
        }

        private void lLblHelpEmployeeServicesTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"Manuals\ManualYdelserUdført.pdf");
            Process.Start(startInfo);
        }

        private void lLblHelpEmployeesTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"Manuals\ManualMedarbejdere.pdf");
            Process.Start(startInfo);
        }

        private void lLblHelpSubjectsTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"Manuals\ManualTjenesteydelserEfteruddannelser.pdf");
            Process.Start(startInfo);
        }

        #endregion


    }
}
