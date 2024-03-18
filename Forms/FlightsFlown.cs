using FDAClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Data;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FOQA.TestForms
{
    public partial class FlightsFlown : Form
    {
        private string monthYear { get; set; } = "";
        private int flights { get; set; } = 0;
        public FlightsFlown()
        {
            InitializeComponent();
        }

        private void FlightsFlown_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }
        private void FlightsFlown_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            FlightsPerMonthFlown.InsertUpdateFlightsFlow(dt);

        }
        private void LoadFlights()
        {
            if (showTop1000.Checked)
            {
                dataGridView1.DataSource = FlightsPerMonthFlown.loadFlightsFlown(1000);
            }
            else
            {
                dataGridView1.DataSource = FlightsPerMonthFlown.loadFlightsFlown();
            }

            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void showTop1000_CheckedChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }
    }
}
