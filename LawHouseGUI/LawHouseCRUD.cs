﻿using BusinessLogic;
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
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = c1.Id;
                dataGridView1.Rows[n].Cells[1].Value = c1.Name;
                dataGridView1.Rows[n].Cells[2].Value = c1.RespEmployee;
                dataGridView1.Rows[n].Cells[3].Value = c1.Client;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var output = handler.GetCase(id);
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
    }
}
