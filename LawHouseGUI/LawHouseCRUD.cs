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

namespace LawHouseGUI
{
    public partial class LawHouseCRUD : Form
    {
        LhHandler handler;
        public LawHouseCRUD()
        {
            InitializeComponent();
            handler = LhHandler.Instance;
            GriderStart();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Case c1 = new Case();
            int id = Convert.ToInt32(InsertCaseIDtxt.Text);
            c1.GetCase(id);
            CaseIDtxb.Text = c1.Id.ToString();
            EndDatetxt.Text = c1.EndDate.ToString();
            Servicetxt.Text = c1.Service.ToString();
            StartDatetxt.Text = c1.StartDate.ToString();
            CaseNametxb.Text = c1.Name.ToString();
            NegPricetxt.Text = c1.NegPrice.ToString();
            Clienttxt.Text = c1.Client.ToString();
            ResoEmpCombo.Text = c1.RespEmployee.ToString();
            TotalPricetxt.Text = c1.TotalPrice.ToString();


        }

        private void GriderStart()
        {
            foreach (var c1 in handler.GetCases())
            {
                int n = CaseDataGrid.Rows.Add();
                CaseDataGrid.Rows[n].Cells[0].Value = c1.Id;
                CaseDataGrid.Rows[n].Cells[1].Value = c1.Name;
                CaseDataGrid.Rows[n].Cells[2].Value = c1.RespEmployee;
                CaseDataGrid.Rows[n].Cells[3].Value = c1.Client;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Case c1 = new Case();
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            c1.GetCase(id);
            CaseIDtxb.Text = c1.Id.ToString();
            EndDatetxt.Text = c1.EndDate.ToString();
            Servicetxt.Text = c1.Service.ToString();
            StartDatetxt.Text = c1.StartDate.ToString();
            CaseNametxb.Text = c1.Name.ToString();
            NegPricetxt.Text = c1.NegPrice.ToString();
            Clienttxt.Text = c1.Client.ToString();
            ResoEmpCombo.Text = c1.RespEmployee.ToString();
            TotalPricetxt.Text = c1.TotalPrice.ToString();
            HoursEsttxt.Text = c1.HoursEstimate.ToString();
            InsertCaseIDtxt.Text = id.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceDataGrid.Rows.Clear();
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            foreach (var service in handler.GetProvidedServices(id))
            {
                int n = ServiceDataGrid.Rows.Add();
                ServiceDataGrid.Rows[n].Cells[0].Value = service.ID;
                ServiceDataGrid.Rows[n].Cells[1].Value = service.EmployeeID;
                ServiceDataGrid.Rows[n].Cells[2].Value = service.CaseID;
                ServiceDataGrid.Rows[n].Cells[3].Value = service.Date;
                ServiceDataGrid.Rows[n].Cells[4].Value = service.Hours;
                ServiceDataGrid.Rows[n].Cells[5].Value = service.Km;
            }
        }
    }
}
