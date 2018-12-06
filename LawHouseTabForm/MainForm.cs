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
        private CaseHandler _caseHandler;
        private LhouseHandler _hrHandler;
        private int ClientId { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _caseHandler = new CaseHandler();
            _hrHandler = LhouseHandler.Instance;
            FillComboBoxes();
            GriderStart();
        }

        public void FillComboBoxes()
        {
            foreach (var l1 in _caseHandler.GetLawyers())
            {
                RespEmpCombo.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
                CrCaseAdvokat.Items.Add($"{l1.Id} {l1.FirstName} {l1.LastName}");
            }
            foreach (var s1 in _caseHandler.GetLegalServices())
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
                CaseDataGrid.Rows[n].Cells[5].Value = c1.Service;
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
            NegPricetxt.Text = negPrice.ToString();
            _caseHandler.InitializeCase(id, negPrice, respEmp);
        }

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            decimal negPrice = Convert.ToDecimal(CaseDataGrid.SelectedRows[0].Cells[7].Value);
            string respEmp = CaseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            _caseHandler.InitializeCase(id, negPrice, respEmp);
           
        }
    }
}
