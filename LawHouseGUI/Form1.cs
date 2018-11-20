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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Case c1 = new Case();
            //c1.GetCase(1);
            //textBox1.Text = c1.Id.ToString();
            //textBox2.Text = c1.Name.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegCaseForm regCase = new RegCaseForm();
            regCase.Show();
        }
    }
}
