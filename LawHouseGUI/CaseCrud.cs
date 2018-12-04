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
    public partial class CaseCrud : UserControl
    {
        private CaseHandler caseHandler;
        public int CaseId { get; set; }
        public CaseCrud()
        {
            InitializeComponent();
            caseHandler = CaseHandler.Instance;
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            foreach (var l1 in caseHandler.GetLawyers())
            {
                RespEmpCbx.Items.Add(l1);
            }

        }

        public void FillTextBoxes(string emp, decimal price, int id)
        {
            CaseId = id;
            RespEmpCbx.Text = emp;
            NegPricetbx.Text = price.ToString();
            caseHandler.InitializeCase(id, "case", "client", DateTime.Now, "service", price, 0, emp);
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
             if (CaseId == 0)
             {
                    MessageBox.Show("Vælg en sag, der skal opdateres");
             }
                else
                {
                   
                    decimal negPrice = Convert.ToDecimal(NegPricetbx.Text);
                    string respEmpl = RespEmpCbx.Text;
                    int i = caseHandler.UpdateCase(CaseId, negPrice, respEmpl);
                    if (i == 1)
                    {
                    MessageBox.Show($"Sagen nr. {CaseId} er blevet opdateret");
                    }
                    else
                    {
                    MessageBox.Show("Sagen kunne ikke opdateres. Prøv igen");
                    }

                }
            
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (CaseId == 0)
            {
                MessageBox.Show("Vælg en sag, der skal slettes");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Er du sikker? ", "Sletter Sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = caseHandler.DeleteCase(CaseId);

                    if (i == 1)
                    {
                        MessageBox.Show($"Sagen nr. {CaseId} er blevet slettet");
                    }
                    else
                    {
                        MessageBox.Show("Sagen kunne ikke slettes. Prøv igen");
                    }
                    ClearTxtBoxes();
                    //CaseDataGrid.Rows.Clear();
                    //GriderStart();
                }
                else
                {
                    MessageBox.Show("Annulleret");
                }
            }

        }

        private void ClearTxtBoxes()
        {
          RespEmpCbx.Text = "";
          NegPricetbx.Clear();
          TotalPricetbx.Clear();

        }

        private void CloseCaseBut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult =
                    MessageBox.Show("Er du sikker? ", "Afslutter sagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    decimal totalPrice = Convert.ToDecimal(TotalPricetbx.Text);
                    DateTime endDate = Convert.ToDateTime(EndCaseTimePictbx.Value.ToShortDateString());
                    int i = caseHandler.CloseCase(CaseId, totalPrice, endDate);
                    if (i == 1)
                    {
                        MessageBox.Show($"Sagen nr. {CaseId} er blevet afsluttet");
                    }
                    else
                    {
                        MessageBox.Show("Sagen kunne ikke afsluttes. Prøv igen");
                    }
                    ClearTxtBoxes();
                    //CaseDataGrid.Rows.Clear();
                    //GriderStart();
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

        private void CalculatePriceBt_Click(object sender, EventArgs e)
        {
            if (CaseId == 0)
            {
                MessageBox.Show("Vælg en sag for prisberegningen");
            }
            else
            {
                decimal price = caseHandler.GetPrice(CaseId);
                TotalPricetbx.Text = price.ToString();

            }

        }
    }
}
