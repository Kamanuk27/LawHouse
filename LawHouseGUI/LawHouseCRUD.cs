using BusinessLogic;
using System;
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
            EndDatetxt.Text = output.EndDate.ToShortDateString();
            Servicetxt.Text = output.Service.ToString();
            StartDatetxt.Text = output.StartDate.ToShortDateString();
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

        private void UpdateCaseButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseIDtxb.Text))
            {
                MessageBox.Show("Vælg en sag, der skal opdateres");
            }
            else
            {
                int id = Convert.ToInt32(CaseIDtxb.Text);
                decimal negPrice = Convert.ToDecimal(NegPricetxt.Text);
                string respEmpl = RespEmpCombo.Text;
                int i = handler.UpdateCase(id, negPrice, respEmpl);
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

        private void DeleteCaseButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(CaseIDtxb.Text))
            {
                MessageBox.Show("Vælg en sag, der skal slettes");
            }
            else
            {
                int id = Convert.ToInt32(CaseIDtxb.Text);
                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Sletter Sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
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

        private void ServiceUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DateTime date = Convert.ToDateTime(YDateTimePicker1.Value.ToShortDateString());
                int houres = Convert.ToInt32(YHouresTxt.Text);
                int km = Convert.ToInt32(YKmTxt.Text);
                int i = handler.UpdateService(id, houres, km, date);
                MessageBox.Show(i.ToString());
                ServiceDataGrid.Rows.Clear();
                YGriderstart();
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
            catch (Exception)
            {
                MessageBox.Show("Vælg sage først");
            }


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

        private void ServiseDeleteBut_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(ServiceDataGrid.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Sletter ydelsen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = handler.DeleteService(id);
                    MessageBox.Show(i.ToString());
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

        private void CloseCaseBut_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(CaseIDtxb.Text);

                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Afslutter sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    decimal totalPrice = Convert.ToDecimal(TotalPricetxt.Text);
                    DateTime endDate = Convert.ToDateTime(EndCaseTimePictxt.Value.ToShortDateString());
                    int i = handler.CloseCase(id, totalPrice, endDate);
                    MessageBox.Show(i.ToString());
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

        private void GetPrice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CaseIDtxb.Text))
            {
                MessageBox.Show("Vælg en sag for prisberegning");
            }
            else
            {
                int id = Convert.ToInt32(CaseIDtxb.Text);
                decimal price = handler.GetPrice(id);
                TotalPricetxt.Text = price.ToString();
               
            }
          
        }
    }
}

