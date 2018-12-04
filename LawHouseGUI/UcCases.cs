using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;


namespace LawHouseGUI
{
    public partial class UcCases : UserControl
    {
        CaseHandler caseHandler;
        public UcCases()
        {
            InitializeComponent();
            caseHandler = CaseHandler.Instance;
          
        }

        public int SelectedCase
        {
            get
            {
                return Convert.ToInt32(CasesGrid.SelectedRows[0].Cells[0]);
            }

        }

        private void UcCases_Load(object sender, EventArgs e)
        {
            var cases = caseHandler.GetCases();
            CasesGrid.DataSource = cases;
            CasesGrid.AutoGenerateColumns = true;

        }
    }
}
