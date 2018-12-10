using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace GUITest
{
    public partial class Form1 : Form
    {
        private CaseHandler _caseHandler;
        private ClientHandler _clientHandler;
        private EmployeeHandler _employeeHandler;
        private SubjectHandler _subjectHandler;
        private ProvidedServiceHandler _pServiceHandler;
        private int ClientId { get; set; }
       
       
        Empl_Unit_Spes em = new Empl_Unit_Spes();
        Ydelser lf = new Ydelser();
        public Form1()
        {
            InitializeComponent();
            _caseHandler = new CaseHandler();
            _clientHandler = new ClientHandler();
            _employeeHandler = new EmployeeHandler();
            _pServiceHandler = new ProvidedServiceHandler();
            _subjectHandler = new SubjectHandler();
            FillComboBoxes();
            GriderStart();


        }
        public void FillComboBoxes()
        {
            foreach (var l1 in _employeeHandler.GetEmplNames())
            {
                RespEmpCombo.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                CrCaseAdvokat.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
            }
            foreach (var s1 in _subjectHandler.GetSubjects())
            {
                CrCaseServiceCom.Items.Add($"{s1.Id} {s1.Name}");
            }
        }

        private void ClearTxtBoxs()
        {
            RespEmpCombo.Text = "";
            NegPricetxt.Clear();
            TotalPricetxt.Clear();
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

        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            RespEmpCombo.Text = respEmp;
            textBox1.Text = id.ToString();
            NegPricetxt.Text = negPrice.ToString();
            //_caseHandler.InitializeCase(id, negPrice, respEmp);

        }

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
           decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
          //  _caseHandler.InitializeCase(id, negPrice, respEmp);
            Services sv = new Services(id);
            sv.Show();
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
                // respEmp er ændret til int nu

                int i = _caseHandler.UpdateCase(id, negPrice, 1);
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
               // decimal price = _pServiceHandler.GetPrice(id);
             //   TotalPricetxt.Text = price.ToString();

            }
        }
        //Delete???
        private void CrCaseServiceCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in _subjectHandler.GetSubjects())
            {
                string[] getServoceId = CrCaseServiceCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string serviceId = getServoceId[0];

                if (s.Id.ToString() == serviceId)
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
            string[] getServoceId = CrCaseServiceCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int service = Convert.ToInt32(getServoceId[0]);
            DateTime startTime = Convert.ToDateTime(CrCasetimeP.Value.ToShortDateString());
            string[] getAdvoketId = CrCaseAdvokat.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int respEmpl = Convert.ToInt32(getAdvoketId[0]); 
            decimal negoPrice = Convert.ToInt32(CrCasePrice.Text);
            _caseHandler.NewCase(caseName, ClientId, service, startTime, respEmpl, negoPrice);
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
            _clientHandler.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        private void FormEmpl_Click(object sender, EventArgs e)
        {
            em.Show();
        }

        private void YdelserButt_Click(object sender, EventArgs e)
        {
            lf.Show();
        }
    }


}
