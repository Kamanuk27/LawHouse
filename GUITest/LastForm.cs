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
    public partial class Ydelser : Form
    {

        private OldCaseHandler _caseHandler;
        private LhouseHandler _hrHandler;
        public int ServiceId { get; set; }
        public Ydelser()
        {
            InitializeComponent();
            _caseHandler = OldCaseHandler.Instance;
            _hrHandler = LhouseHandler.Instance;
            GetServices();
        }

        private void GetServices()
        {
            foreach (var c1 in _hrHandler.GetSubject())
            {
                int n = ServiceGridView.Rows.Add();
                ServiceGridView.Rows[n].Cells[0].Value = c1.Id;
                ServiceGridView.Rows[n].Cells[1].Value = c1.Name;
                ServiceGridView.Rows[n].Cells[2].Value = c1.HoursEstimate;
                ServiceGridView.Rows[n].Cells[3].Value = c1.TimeEstimate;
                ServiceGridView.Rows[n].Cells[4].Value = c1.Price;
            }
        }
        private void MakeNewServBut_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _hrHandler.NewSubject(name, hours, time, price);
        }

        private void UpdateServButt_Click(object sender, EventArgs e)
        {
            string name = MkServiceName.Text;
            int hours = Convert.ToInt32(MkServiceHours.Text);
            int time = Convert.ToInt32(MkServiceTime.Text);
            decimal price = Convert.ToDecimal(MkServiceFixPr.Text);
            _hrHandler.UpdateSubjects(ServiceId, name, hours, time, price);
        }

        private void ServiceGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceId = Convert.ToInt32(ServiceGridView.SelectedRows[0].Cells[0].Value);
            MkServiceName.Text = ServiceGridView.SelectedRows[0].Cells[1].Value.ToString();
            MkServiceHours.Text = ServiceGridView.SelectedRows[0].Cells[2].Value.ToString();
            MkServiceTime.Text = ServiceGridView.SelectedRows[0].Cells[3].Value.ToString();
            MkServiceFixPr.Text = ServiceGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteServButt_Click(object sender, EventArgs e)
        {
            _hrHandler.DeleteSubject(ServiceId);
        }
    }
}
