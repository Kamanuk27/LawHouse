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

namespace LawHouseGUI
{
    public partial class RegCaseForm : Form
    {
        public RegCaseForm()
        {
            InitializeComponent();
           
        }


            

        //c1.GetCase(1);
        //textBox1.Text = c1.Id.ToString();
        //textBox2.Text = c1.Name.ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            Case c1 = new Case();
            int id = Convert.ToInt32(CaseNumtextBox.Text);
            c1.GetCase(id);
            idTextBox.Text = c1.Id.ToString();
            andDatetextBox1.Text = c1.EndDate.ToString();
            serviceTextBox.Text = c1.Service.ToString();
            startDatetextBox.Text = c1.StartDate.ToString();
            nameTextBox.Text = c1.Name.ToString();
            negPriceTextBox.Text = c1.NegPrice.ToString();
            clientTextBox.Text = c1.Client.ToString();
            //respEmployeeTextBox.Text = c1.RespEmployee.ToString();
            totalPriceTextBox.Text = c1.TotalPrice.ToString();

        }
    }
}
