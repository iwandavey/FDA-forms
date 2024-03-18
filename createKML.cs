using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FDAClassLibrary;
using System.Windows.Forms;
using System.IO;

namespace FOQA
{
    public partial class createKML : Form
    {
        
        public int KMLEventCounter = 0;
        public int StartCounter = 0;
        public int EndCounter = 0;

        public createKML()
        {

            InitializeComponent();

        }



        private void btnCreateKML_Click(object sender, EventArgs e)
        {
            string path = "";
            string directoryName = "";
            string sFilename = "";
            //int BeginCounter = StartCounter;
            //int stopCounter = EndCounter;
            int EventCounter = KMLEventCounter;

            if (StartCounter == 0 && EndCounter == 0)
            {
                if (int.TryParse(CounterMinus.Text, out StartCounter))
                {

                }
                else
                {
                    CounterMinus.Text = "0";
                }

                if (int.TryParse(CounterPlus.Text, out EndCounter))
                {

                }
                else
                {
                    CounterPlus.Text = "0";
                }
            }
            

            Counter.Text = KMLEventCounter.ToString();
            
            //BeginCounter = Convert.ToInt32(textBox1.Text);
            //EndCounter = Convert.ToInt32(textBox2.Text);
            //EventCounter = Convert.ToInt32(lCounter.Text);


            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                path = this.sfdFile.FileName;
                directoryName = Path.GetDirectoryName(path);
                sFilename = sfdFile.FileName.ToString();
                sfdFile.FileName = sFilename;
                FOQAData.KLM.CreateKLM(DataToAnalyse.fdaDataTable, StartCounter, EndCounter, EventCounter, path, sFilename);
            }

            this.Close();
        }

        private void createKML_Load(object sender, EventArgs e)
        {
            Counter.Text = KMLEventCounter.ToString();

            if(UseCounterStartEnd.Checked)
            {
                CounterMinus.Text = StartCounter.ToString();
                CounterPlus.Text = EndCounter.ToString();
            }
        }
    }
    
}
