using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOQA.ApplicationClasses;
using System.Windows.Forms;

namespace FOQA
{
    public partial class graphParameters : Form
    {
        public graphParameters()
        {
            InitializeComponent();
        }

        private void graphParameters_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = PlotList.Parameters;
        }

        private void graphParameters_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
