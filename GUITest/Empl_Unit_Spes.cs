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
        private CaseHandler _caseHandler;
        private HrHandler _hrHandler;
        public Empl_Unit_Spes()
        {
            InitializeComponent();
            _caseHandler = CaseHandler.Instance;
            _hrHandler = HrHandler.Instance;
            FillComboBoxes();
        }
        public void FillComboBoxes()
        {
            foreach (var l1 in _caseHandler.GetLawyers())
            {
               
                SpecInsertCom.Items.Add(l1);

            }
            foreach (var s1 in _hrHandler.GetLegalServices())
            {
                LServInsertCom.Items.Add(s1.Name);
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
            _hrHandler.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }

        private void MakeNewServBut_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _hrHandler.NewLegalService(name, hours, time, price);
        }
    }
}
