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
using DataAccess.Repositories;

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
           
            //int id = Convert.ToInt32(InsertCaseIDtxt.Text);
            //var output = handler.GetCase(id);
            //CaseIDtxb.Text = output.Id.ToString();
            //EndDatetxt.Text = output.EndDate.ToString();
            //Servicetxt.Text = output.Service.ToString();
            //StartDatetxt.Text = output.StartDate.ToString();
            //CaseNametxb.Text = output.Name.ToString();
            //NegPricetxt.Text = output.NegPrice.ToString();
            //Clienttxt.Text = output.Client.ToString();
            //ResoEmpCombo.Text = output.RespEmployee.ToString();
            //TotalPricetxt.Text = output.TotalPrice.ToString();


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

        private void CaseDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            var output =  handler.GetCase(id);
            CaseIDtxb.Text = output.Id.ToString();
            EndDatetxt.Text = output.EndDate.ToString();
            Servicetxt.Text = output.Service.ToString();
            StartDatetxt.Text = output.StartDate.ToString();
            CaseNametxb.Text = output.Name.ToString();
            NegPricetxt.Text = output.NegPrice.ToString();
            Clienttxt.Text = output.Client.ToString();
            ResoEmpCombo.Text = output.RespEmployee.ToString();
            TotalPricetxt.Text = output.TotalPrice.ToString();
            HoursEsttxt.Text = output.HoursEstimate.ToString();
        }

        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceDataGrid.Rows.Clear();
            int id = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            foreach (var service in handler.GetProvidedServices(id))
            {
                int n = ServiceDataGrid.Rows.Add();
                ServiceDataGrid.Rows[n].Cells[0].Value = service.ID;
                ServiceDataGrid.Rows[n].Cells[1].Value = service.EmployeeName;
                ServiceDataGrid.Rows[n].Cells[2].Value = service.Date;
                ServiceDataGrid.Rows[n].Cells[3].Value = service.Comment;
                ServiceDataGrid.Rows[n].Cells[4].Value = service.Hours;
                ServiceDataGrid.Rows[n].Cells[5].Value = service.Km;
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
    }
}
