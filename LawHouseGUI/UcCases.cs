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
        private CaseHandler caseHandler;
        public UcCases()
        {
            InitializeComponent();
            caseHandler = CaseHandler.Instance;
            
        }

        private void UcCases_Load(object sender, EventArgs e)
        {
            var cases = caseHandler.GetCases();
            GridCases.DataSource = cases;
            GridCases.AutoGenerateColumns = true;
        }

        private void GridCases_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                int id = Convert.ToInt32(GridCases.SelectedRows[0].Cells[9].Value);
                string respEmp = GridCases.SelectedRows[0].Cells[7].Value.ToString();
                decimal negPrice = Convert.ToDecimal(GridCases.SelectedRows[0].Cells[4].Value);

                caseCrud1.FillTextBoxes(respEmp, negPrice, id);
        }


    }
}
