using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawHouseTabForm
{
    public partial class MainForm : Form
    {
        private OldCaseHandler _caseHandler;
        private LhouseHandler _hrHandler;
        private int CaseId { get; set; }
        public int EmpiId { get; set; }
        public int ServiceId { get; set; }


        public MainForm()
        {
            InitializeComponent();
            _caseHandler = new OldCaseHandler();
            _hrHandler = LhouseHandler.Instance;
            FillComboBoxes();
            GriderStart();
            EmplGridStart();
            GetServices();
        }

        #region Show All in Form

        public void FillComboBoxes()
        {
            foreach (var l1 in _caseHandler.GetLawyers())
            {
                RespEmpCombo.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                CrCaseAdvokat.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
            }

            foreach (var s1 in _hrHandler.GetSubject())
            {
                CrCaseServiceCom.Items.Add($"{s1.Id} {s1.Name}");
            }

            foreach (var m1 in _caseHandler.GetEmplNames())
            {
                YEmploeeCombox.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
            }

            foreach (var l1 in _caseHandler.GetLawyers())
            {

                SpecInsertCom.Items.Add($"{l1.Id}  {l1.FirstName} {l1.LastName}");

            }

            foreach (var s1 in _hrHandler.GetSubject())
            {
                LServInsertCom.Items.Add($"{s1.Id} {s1.Name}");
            }
        }

        private void ClearTxtBoxs()
        {
            RespEmpCombo.Text = "";
            NegPricetxt.Clear();
            TotalPricetxt.Clear();
        }

        private void ClearServiceTxtBox()
        {
            YEmploeeCombox.Text = "";
            YHouresTxt.Clear();
            YKmTxt.Clear();
            YCommentTxt.Clear();
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

        private void GriderStart()
        {
            foreach (var c1 in _caseHandler.GetCases())
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

        private void YGriderstart()
        {
            ServiceDataGrid.Rows.Clear();

            foreach (var service in _caseHandler.GetProvidedServices(CaseId))
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
            foreach (var c1 in _hrHandler.GetEmployees())
            {
                int n = EmlGridView.Rows.Add();
                EmlGridView.Rows[n].Cells[0].Value = c1.Id;
                EmlGridView.Rows[n].Cells[1].Value = c1.CprNo;
                EmlGridView.Rows[n].Cells[2].Value = c1.FirstName;
                EmlGridView.Rows[n].Cells[3].Value = c1.LastName;
                EmlGridView.Rows[n].Cells[4].Value = c1.Address;
                EmlGridView.Rows[n].Cells[5].Value = c1.PostNo;
                EmlGridView.Rows[n].Cells[6].Value = c1.Email;
                EmlGridView.Rows[n].Cells[7].Value = c1.TlfNo;
                EmlGridView.Rows[n].Cells[8].Value = c1.StartDate.ToShortDateString();
                EmlGridView.Rows[n].Cells[9].Value = c1.Position;
                EmlGridView.Rows[n].Cells[10].Value = c1.PayRatePrHour;
            }
        }

        private void GetServices()
        {
            foreach (var c1 in _hrHandler.GetSubject())
            {
                int n = ServiceGridView.Rows.Add();
                ServiceGridView.Rows[n].Cells[0].Value = c1.Id;
                ServiceGridView.Rows[n].Cells[1].Value = c1.Name;
                ServiceGridView.Rows[n].Cells[2].Value = c1.HoursEstimate;
                ServiceGridView.Rows[n].Cells[3].Value = c1.TimeEstimate;
                ServiceGridView.Rows[n].Cells[4].Value = c1.Price;
            }
        }

        private void ServiceDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            YEmploeeCombox.Text = ServiceDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            YDateTimePicker1.Text = ServiceDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            YCommentTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            YHouresTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            YKmTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void ServiceGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceId = Convert.ToInt32(ServiceGridView.SelectedRows[0].Cells[0].Value);
            MkServiceName.Text = ServiceGridView.SelectedRows[0].Cells[1].Value.ToString();
            MkServiceHours.Text = ServiceGridView.SelectedRows[0].Cells[2].Value.ToString();
            MkServiceTime.Text = ServiceGridView.SelectedRows[0].Cells[3].Value.ToString();
            MkServiceFixPr.Text = ServiceGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void YEmploeeCombox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        #endregion Show All in Form
        
        #region Tab1

        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            RespEmpCombo.Text = respEmp;
            NegPricetxt.Text = negPrice.ToString();
            _caseHandler.InitializeCase(id, negPrice, respEmp);
        }

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            _caseHandler.InitializeCase(id, negPrice, respEmp);
            string name = CaseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            CaseId = id;
            labelCaseName.Text = $"Nr.{id}, {name}";
            //_handler.InitializeCase(id, name, client, start, service, negPrice, total, respEmp);
            YGriderstart();
            tabControl1.SelectTab(tabPage2);

        }

        private void RespEmpCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void CrCaseServiceCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void CrCaseAdvokat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CaseDataGrid.RowCount; i++)
            {
                CaseDataGrid.Rows[i].Selected = false;
                for (int j = 0; j < CaseDataGrid.ColumnCount; j++)
                    if (CaseDataGrid.Rows[i].Cells[j].Value != null)
                        if (CaseDataGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            CaseDataGrid.Rows[i].Selected = true;
                            break;
                        }
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
                    GriderStart();
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
                string respEmpl = RespEmpCombo.Text;
                int i = _caseHandler.UpdateCaseE(id, negPrice, respEmpl);
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
                    GriderStart();
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

        private void CalculatePrice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag for prisberegningen");
            }
            else
            {
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[9].Value);
               
                decimal price = _caseHandler.GetPrice(id, negPrice);
                
            }
        }

        private void UdateClienButt_Click(object sender, EventArgs e)
        {
            string cpr = NewClientCprNo.Text;
            string fName = NewClientfName.Text;
            string lName = NewClientLName.Text;
            string address = NewClientAdress.Text;
            int postNo = Convert.ToInt32(NewClientPost.Text);
            string eMail = NewClientMail.Text;
            string tlf = NewClientTelef.Text;
            _caseHandler.UpdateClient(fName, lName, cpr, address, postNo, eMail, tlf);
        }

        private void NewClientButt_Click(object sender, EventArgs e)
        {
            string cpr = NewClientCprNo.Text;
            string fName = NewClientfName.Text;
            string lName = NewClientLName.Text;
            string address = NewClientAdress.Text;
            int postNo = Convert.ToInt32(NewClientPost.Text);
            string eMail = NewClientMail.Text;
            string tlf = NewClientTelef.Text;
            _caseHandler.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        private void NewCaseButt_Click(object sender, EventArgs e)
        {
            string caseName = CrCaseName.Text;
            string[] getServoceId =
                CrCaseServiceCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int service = Convert.ToInt32(getServoceId[0]);
            DateTime startTime = Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString());
            string[] getAdvoketId = CrCaseAdvokat.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int respEmpl = Convert.ToInt32(getAdvoketId[0]);
            decimal negoPrice = Convert.ToInt32(CrCasePrice.Text);
            _caseHandler.NewCase(caseName, CaseId, service, startTime, respEmpl, negoPrice);
        }

        private void CrCaseServiceCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _hrHandler.GetSubject())
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




        #endregion Tab1

        #region Tab2

        private void ServiseDeleteBut_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", "Sletter ydelsen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = _caseHandler.DeleteService(id);
                    MessageBox.Show(i.ToString());
                    ClearServiceTxtBox();
                    ServiceDataGrid.Rows.Clear();
                    YGriderstart();

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

        private void YUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int houres = Convert.ToInt32(YHouresTxt.Text);
                int km = Convert.ToInt32(YKmTxt.Text);
                string comment = YCommentTxt.Text;
                int i = _caseHandler.UpdateService(id, houres, km, date, comment);
                MessageBox.Show(i.ToString());
                ClearServiceTxtBox();
                ServiceDataGrid.Rows.Clear();
                YGriderstart();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg ydelse først");
            }
        }

        private void NyYdButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int hours = YHouresTxt.Text != null ? Convert.ToInt32(YHouresTxt.Text) : 0;
                int km = YKmTxt.Text != null ? Convert.ToInt32(YKmTxt.Text) : 0;
                string comment = YCommentTxt.Text;
                string[] names = YEmploeeCombox.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int respEmpl = Convert.ToInt32(names[0]);
                // string respEmpl = YEmploeeCombox.Text;
                int i = _caseHandler.NewService(CaseId, date, hours, km, comment, respEmpl);
                MessageBox.Show(i.ToString());
                ClearServiceTxtBox();
                ServiceDataGrid.Rows.Clear();
                YGriderstart();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg sage først");
            }
        }





        #endregion Tab2

        #region Tab3

        private void EmlGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmpiId = Convert.ToInt32(EmlGridView.SelectedRows[0].Cells[0].Value);
            NECprTxt.Text = EmlGridView.SelectedRows[0].Cells[1].Value.ToString();
            NEFnameTxt.Text = EmlGridView.SelectedRows[0].Cells[2].Value.ToString();
            NELnameTxt.Text = EmlGridView.SelectedRows[0].Cells[3].Value.ToString();
            NEAdressTxt.Text = EmlGridView.SelectedRows[0].Cells[4].Value.ToString();
            NEPostTxt.Text = EmlGridView.SelectedRows[0].Cells[5].Value.ToString();
            NEEmailTxt.Text = EmlGridView.SelectedRows[0].Cells[6].Value.ToString();
            NETlfTxt.Text = EmlGridView.SelectedRows[0].Cells[7].Value.ToString();
            NEmplStartDate.Value = Convert.ToDateTime(EmlGridView.SelectedRows[0].Cells[8].Value.ToString());
            NEmplPosition.Text = EmlGridView.SelectedRows[0].Cells[9].Value.ToString();
            NEmplMoney.Text = EmlGridView.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void NewEmplButt_Click(object sender, EventArgs e)
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
            _hrHandler.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
            ClearTxt();
            EmlGridView.Rows.Clear();
            EmplGridStart();
        }

        private void UpdateEmpl_Click(object sender, EventArgs e)
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
            _hrHandler.UpdateEmployee(EmpiId, fName, lName, address, postNo, eMail, tlf, position, money);
            ClearTxt();
            EmlGridView.Rows.Clear();
            EmplGridStart();
        }

        private void DeleteEmpl_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(EmlGridView.SelectedRows[0].Cells[0].Value);
            DialogResult dialogResult =
                MessageBox.Show("Er du sikker? ", $"Sletter Sagen {EmpiId}", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int i = _hrHandler.CloseEmployee(EmpiId);
                MessageBox.Show(i.ToString());
                ClearTxt();
                EmlGridView.Rows.Clear();
                EmplGridStart();
            }
            else
            {
                MessageBox.Show("Annulleret");
            }
        }

        private void SpecialButt_Click(object sender, EventArgs e)
        {
            string[] getAdvokatId = SpecInsertCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int id = Convert.ToInt32(getAdvokatId[0]);
            string[] getServiceId = LServInsertCom.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int sId = Convert.ToInt32(getServiceId[0]);

        }




        #endregion

        #region Tab4

        private void MakeNewServBut_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _hrHandler.NewSubject(name, hours, time, price);
        }

        private void UpdateServButt_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _hrHandler.UpdateSubjects(ServiceId, name, hours, time, price);
        }

        private void DeleteServButt_Click(object sender, EventArgs e)
        {
            _hrHandler.DeleteSubject(ServiceId);
        }


        #endregion

       
    }
}
