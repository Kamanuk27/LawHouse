using BusinessLogic;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;



namespace LawHouseGUI
{
    public partial class LawHouseCRUD : Form
    {
        private LhController _handler;

        public LawHouseCRUD()
        {
            InitializeComponent();
            _handler = LhController.Instance;
            GriderStart();
            FillComboBoxes();

        }

        public void FillComboBoxes()
        {
            foreach (var l1 in _handler.GetLawyers())
            {
                RespEmpCombo.Items.Add(l1);
                CrCaseAdvokat.Items.Add(l1);
                SpecInsertCom.Items.Add(l1);

            }

            foreach (var s1 in _handler.GetLegalServices())
            {
                string name = s1.Name;
                CrCaseServiceCom.Items.Add(name);
                LServInsertCom.Items.Add(name);
            }

            foreach (var m1 in _handler.GetEmplNames())
            {
                YEmploeeCombox.Items.Add(m1);
            }
        }

        private void ClearServiceTxtBox()
        {
            YEmploeeCombox.Text = "";
            YHouresTxt.Clear();
            YKmTxt.Clear();
            YCommentTxt.Clear();
        }

        private void ClearTxtBoxs()
        {

            RespEmpCombo.Text = "";
            NegPricetxt.Clear();
            TotalPricetxt.Clear();

        }

        private void GriderStart()
        {
            foreach (var c1 in _handler.GetCases())
            {
                int n = CaseDataGrid.Rows.Add();
                CaseDataGrid.Rows[n].Cells[0].Value = c1.Id;
                CaseDataGrid.Rows[n].Cells[1].Value = c1.Name;
                CaseDataGrid.Rows[n].Cells[2].Value = c1.Client;
                CaseDataGrid.Rows[n].Cells[3].Value = c1.StartDate.ToShortDateString();
                CaseDataGrid.Rows[n].Cells[4].Value = c1.EndDate.ToShortDateString();
                CaseDataGrid.Rows[n].Cells[5].Value = c1.Service;
                CaseDataGrid.Rows[n].Cells[6].Value = c1.HoursEstimate;
                CaseDataGrid.Rows[n].Cells[7].Value = c1.NegPrice;
                CaseDataGrid.Rows[n].Cells[8].Value = c1.TotalPrice;
                CaseDataGrid.Rows[n].Cells[9].Value = c1.RespEmployee;

            }
        }

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            string name = CaseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string client = CaseDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            DateTime start = Convert.ToDateTime(CaseDataGrid.SelectedRows[0].Cells[3].Value).Date;
            string service = CaseDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            decimal total = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[8].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            labelCaseName.Text = $"Nr.{id}, {name}";
            _handler.InitializeCase(id, name, client, start, service, negPrice, total, respEmp);
            tabControl1.SelectTab(ServiceTab);


        }


        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            string name = CaseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string client = CaseDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            DateTime start = Convert.ToDateTime(CaseDataGrid.SelectedRows[0].Cells[3].Value).Date;
            string service = CaseDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            decimal total = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[8].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            RespEmpCombo.Text = respEmp;
            NegPricetxt.Text = negPrice.ToString();
            _handler.InitializeCase(id, name, client, start, service, negPrice, total, respEmp);
            YGriderstart();

        }

        private void YGriderstart()
        {
            ServiceDataGrid.Rows.Clear();
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            foreach (var service in _handler.GetProvidedServices(id))
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

        private void CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            YEmploeeCombox.Text = ServiceDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            YDateTimePicker1.Text = ServiceDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            YCommentTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            YHouresTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            YKmTxt.Text = ServiceDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }


        private void YEmploeeCombox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void RespEmpCombo_KeyPress(object sender, KeyPressEventArgs e)
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


        private void DeleteCaseButton_Click(object sender, EventArgs e)
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
                    int i = _handler.DeleteCase(id);
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

        private void UpdateCaseButton_Click(object sender, EventArgs e)
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
                int i = _handler.UpdateCase(id, negPrice, respEmpl);
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

        private void CloseCaseBut_Click(object sender, EventArgs e)
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
                    int i = _handler.CloseCase(id, totalPrice, endDate);
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

        private void GetPrice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag for prisberegningen");
            }
            else
            {
                int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                decimal price = _handler.GetPrice(id);
                TotalPricetxt.Text = price.ToString();

            }

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
            _handler.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }

        private void MakeNewServBut_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _handler.NewLegalService(name, hours, time, price);
        }

        private void CrCaseServiceCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _handler.GetLegalServices())
            {
                if (s.Name == CrCaseServiceCom.Text)
                {
                    CrCasePrice.Text = s.Price.ToString();
                    CrCaseTimeUsed.Text = s.HoursEstimate.ToString();
                    CrCaseEndDato.Text = TimeSpan.FromDays((s.TimeEstimate)).ToString();
                }
            }
        }

        private void NewCaseButt_Click(object sender, EventArgs e)
        {
            string caseName = CrCaseName.Text;
            string client = NewClientfName.Text;
            string service = CrCaseServiceCom.Text;
            DateTime startTime = Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString());
            string respEmpl = CrCaseAdvokat.Text;
            decimal negoPrice = Convert.ToInt32(CrCasePrice.Text);
            _handler.NewCase(caseName, client, service, startTime, respEmpl, negoPrice);
        }

        private void ServiseDeleteBut_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", "Sletter ydelsen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = _handler.DeleteService(id);
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

        private void NewClientButt_Click(object sender, EventArgs e)
        {
            string cpr = NewClientCprNo.Text;
            string fName = NewClientfName.Text;
            string lName = NewClientLName.Text;
            string address = NewClientAdress.Text;
            int postNo = Convert.ToInt32(NewClientPost.Text);
            string eMail = NewClientMail.Text;
            string tlf = NewClientTelef.Text;
            _handler.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        private void NyYdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int caseID = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int hours = YHouresTxt.Text != null ? Convert.ToInt32(YHouresTxt.Text) : 0;
                int km = YKmTxt.Text != null ? Convert.ToInt32(YKmTxt.Text) : 0;
                string comment = YCommentTxt.Text;
                string respEmpl = YEmploeeCombox.Text;
                int i = _handler.NewService(caseID, date, hours, km, comment, respEmpl);
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

        private void YUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int houres = Convert.ToInt32(YHouresTxt.Text);
                int km = Convert.ToInt32(YKmTxt.Text);
                string comment = YCommentTxt.Text;
                int i = _handler.UpdateService(id, houres, km, date, comment);
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

       
    }
}

