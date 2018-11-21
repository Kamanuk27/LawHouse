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
    public partial class RegisterServices : Form
    {
        public RegisterServices()
        {
            InitializeComponent();
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

        
    }
}
