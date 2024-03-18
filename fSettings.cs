using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using FOQAData;

namespace FOQA
{
    public partial class fSettings : Form
    {

        public fSettings()
        {
            InitializeComponent();
        }

        private void bFolderDialog_Click(object sender, EventArgs e)
        {
            fbDialog.SelectedPath = tPath.Text;
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                tPath.Text = fbDialog.SelectedPath.ToString();
            }
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            //tPath.Text = csv.sPath;
        }

        private void fSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string sFileName = "datCSVpath.txt";
            //string sProjPath = Path.GetDirectoryName(Application.ExecutablePath);
            ////string sPath = "";

            //if (tPath.Text != csv.sPath)
            //{
            //    if (MessageBox.Show("You have changed the default csv file location. Do you want to save this path? ", "Path changed!",
            //        MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            StreamWriter SW;
            //            SW = File.CreateText(sFileName);
            //            SW.WriteLine(tPath.Text);
            //            SW.Close();
            //            csv.sPath = tPath.Text;
            //        }
            //        catch(Exception EE)
            //        {
            //            MessageBox.Show(EE.ToString(), "FOQA write file settings.");
            //        }

            //    }
            //}
        }
        
    }
}
