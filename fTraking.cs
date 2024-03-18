using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOQA
{
    public partial class fTraking : Form
    {
        public fTraking()
        {
            InitializeComponent();
        }

        public static string sFileName = "";

        private void fTraking_Load(object sender, EventArgs e)
        {
            ActiveForm.Text = sFileName;
        }
    }

    
}
