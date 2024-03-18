using FDAClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOQA.TestForms
{
    public partial class testForm : Form
    {

        public DataTable dataTable1 = new DataTable();
        public DataTable dataTable2 = new DataTable();
        
        public testForm()
        {
            InitializeComponent();
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VlugLogAnaliese.Log;
            dataGridView2.DataSource = FlightAnalysis.eventLog;
            dataGridView3.DataSource = FlightAnalysis.ParametersNotAnaliseds;

        }
    }
}
