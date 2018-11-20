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
            int id = Convert.ToInt32(CaseNumtextBox.Text);
            c1.GetCase(id);
            idTextBox.Text = c1.Id.ToString();
            textBox1.Text = c1.EndDate.ToString();
            serviceTextBox.Text = c1.Service.ToString();
            textBox2.Text = c1.StartDate.ToString();
            nameTextBox.Text = c1.Name.ToString();
            negPriceTextBox.Text = c1.NegPrice.ToString();
            clientTextBox.Text = c1.Client.ToString();
            respEmployeeTextBox.Text = c1.RespEmployee.ToString();
            totalPriceTextBox.Text = c1.TotalPrice.ToString();


        }

        private void startDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
