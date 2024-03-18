using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FOQA
{
   


    public partial class fFileName : Form
    {
        

        public fFileName()
        {
            InitializeComponent();
        }

        private void fFileName_Load(object sender, EventArgs e)
        {
            lFilePath.Text = FOQA.fFileNamevar.sFilePath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FOQA.fFileNamevar.sFileName = tFileName.Text;
            this.Close();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            fFileNamevar.sFileName = "";
            this.Close();
        }
    }

    public class fFileNamevar
    {
        public static string sFilePath;
        public static string sFileName;
        public static int ifkExceedance;
    }
}
