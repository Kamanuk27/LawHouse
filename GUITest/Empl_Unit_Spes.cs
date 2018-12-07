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
    public partial class Empl_Unit_Spes : Form
    {
        private OldCaseHandler _caseHandler;
        private LhouseHandler _hrHandler;
        public int EmpiId { get; set; }

        public Empl_Unit_Spes()
        {
            InitializeComponent();
            _caseHandler = OldCaseHandler.Instance;
            _hrHandler = LhouseHandler.Instance;
            FillComboBoxes();
            EmplGridStart();
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

        public void FillComboBoxes()
        {
            foreach (var l1 in _caseHandler.GetLawyers())
            {

                SpecInsertCom.Items.Add($"{l1.Id}  {l1.FirstName} {l1.LastName}");

            }

            foreach (var s1 in _hrHandler.GetSubject())
            {
                LServInsertCom.Items.Add($"{s1.Id} {s1.Name}");
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
            //int cpr = Convert.ToInt32(NECprTxt.Text);
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
            if (String.IsNullOrEmpty(EmlGridView.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vælg en sag, der skal slettes");
            }
            else
            {
                int id = Convert.ToInt32(EmlGridView.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", $"Sletter Sagen {id}", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int i = _hrHandler.CloseEmployee(id);
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
        }


        private void EmlGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void SpecialButt_Click(object sender, EventArgs e)
        {

            string[] getAdvokatId = SpecInsertCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int id = Convert.ToInt32(getAdvokatId[0]);
            string[] getServiceId = LServInsertCom.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sId = Convert.ToInt32(getServiceId[0]);
           // _hrHandler.GetEmployeeFields(id);

        }
    }
}
