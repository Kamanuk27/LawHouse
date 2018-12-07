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
    public partial class Services : Form
    {
        public int ID { get; set; }
        private CaseHandler _caseHandler;

        public Services(int id)
        {
            InitializeComponent();
            _caseHandler = CaseHandler.Instance;
            ID = id;
            FillComboBoxes();
            YGriderstart();
        }

        private void YGriderstart()
        {
            ServiceDataGrid.Rows.Clear();

            foreach (var service in _caseHandler.GetProvidedServices(ID))
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

        private void ServiceDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        public void FillComboBoxes()
        {
            foreach (var m1 in _caseHandler.GetEmplNames())
            {
                YEmploeeCombox.Items.Add($"{m1.Id} {m1.FirstName} {m1.LastName}");
            }
        }
        private void ClearServiceTxtBox()
        {
            YEmploeeCombox.Text = "";
            YHouresTxt.Clear();
            YKmTxt.Clear();
            YCommentTxt.Clear();
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
                    int i = _caseHandler.DeleteService(id);
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

        private void NyYdButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int hours = YHouresTxt.Text != null ? Convert.ToInt32(YHouresTxt.Text) : 0;
                int km = YKmTxt.Text != null ? Convert.ToInt32(YKmTxt.Text) : 0;
                string comment = YCommentTxt.Text;
                string[] names = YEmploeeCombox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int respEmpl = Convert.ToInt32(names[0]);
               // string respEmpl = YEmploeeCombox.Text;
                int i = _caseHandler.NewService(ID, date, hours, km, comment, respEmpl);
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
                int i = _caseHandler.UpdateService(id, houres, km, date, comment);
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
