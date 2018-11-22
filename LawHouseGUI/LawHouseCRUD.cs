using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            FillComboBoxes();

        }

        public void FillComboBoxes()
        {
            foreach (var l1 in handler.GetLawyers())
            {
                RespEmpCombo.Items.Add(l1);
            }

            foreach (var m1 in handler.GetEmplNames())
            {
                YEmploeeCombox.Items.Add(m1);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
            var output = handler.GetCase(id);
            CaseIDtxb.Text = output.Id.ToString();
            EndDatetxt.Text = output.EndDate.ToString();
            Servicetxt.Text = output.Service.ToString();
            StartDatetxt.Text = output.StartDate.ToString();
            CaseNametxb.Text = output.Name.ToString();
            NegPricetxt.Text = output.NegPrice.ToString();
            Clienttxt.Text = output.Client.ToString();
            RespEmpCombo.Text = output.RespEmployee.ToString();
            TotalPricetxt.Text = output.TotalPrice.ToString();
            HoursEsttxt.Text = output.HoursEstimate.ToString();
        }

        private void CaseDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           YGriderstart();
        }

        private void YGriderstart()
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

        private void UpdateButt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CaseIDtxb.Text);
            decimal negPrice = Convert.ToDecimal(NegPricetxt.Text);
            string respEmpl = RespEmpCombo.Text;


            //string service = Servicetxt.Text;
            //DateTime start = Convert.ToDateTime(StartDatetxt.Text);
            //string caseName = CaseNametxb.Text;
            //string client = Clienttxt.Text;
            //int total = Convert.ToInt32(TotalPricetxt.Text);

            int i = handler.UpdateCase(id, negPrice, respEmpl);
            MessageBox.Show(i.ToString());

        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Slette Sage", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(CaseIDtxb.Text);
                int i = handler.DeleteCase(id);
                MessageBox.Show(i.ToString());
                CaseDataGrid.Rows.Clear();
                GriderStart();

            }
            else
            {
                MessageBox.Show("Annulleret");
            }
           
        }

        private void RespEmpCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void YEmploeeCombox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void YUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
            DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
            int houres = Convert.ToInt32(YHouresTxt.Text);
            int km = Convert.ToInt32(YKmTxt.Text);
            int i = handler.EditService(id, houres, km, date);
            MessageBox.Show(i.ToString());
            ServiceDataGrid.Rows.Clear();
            YGriderstart();
        }

        private void NyYdButton_Click(object sender, EventArgs e)
        {
            int caseID = Convert.ToInt32(CaseDataGrid.SelectedRows[0].Cells[0].Value);
            DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
            int hours = Convert.ToInt32(YHouresTxt.Text);
            int km = Convert.ToInt32(YKmTxt.Text);
            string comment = YCommentTxt.Text;
            string respEmpl = YEmploeeCombox.Text;
            int i = handler.NewService(caseID, date, hours, km, comment, respEmpl);
            MessageBox.Show(i.ToString());
            ServiceDataGrid.Rows.Clear();
            YGriderstart();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Slette ydelse", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                int i = handler.DeleteSrvice(id);
                MessageBox.Show(i.ToString());
                ServiceDataGrid.Rows.Clear();
                YGriderstart();

            }
            else
            {
                MessageBox.Show("Annulleret");
            }


        }
    }
}

