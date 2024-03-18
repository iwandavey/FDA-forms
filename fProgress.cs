using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;



namespace FOQA
{
    public partial class fProgress : Form
    {
        public fProgress()
        {
            InitializeComponent();
        }

        private void fProgress_Load(object sender, EventArgs e)
        {
            
            Application.DoEvents();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FOQAData.sMessages.iProgressProsesNumber == 1)
            {
                lProsess.Visible = false;
                pProsess.Visible = false;
            }
            else
            {
                lProsess.Visible = true;
                pProsess.Visible = true;
            }

            bool bSetValues = true;
            double dPers = 0;
            pProsess.Maximum = FOQAData.sMessages.iProgressProsesNumber;

            if (bSetValues)
            {
                pBar.Minimum = FOQAData.sMessages.iProgressMin;
                pBar.Maximum = FOQAData.sMessages.iProgressMax;
                
                pBar.Value = FOQAData.sMessages.iProgressValue;
                if (FOQAData.sMessages.iProgressProsesValue < pProsess.Maximum &&
                    FOQAData.sMessages.iProgressProsesValue > pProsess.Minimum)
                {
                    pProsess.Value = FOQAData.sMessages.iProgressProsesValue;
                }
                
                bSetValues = false;
            }
            dPers = (((double)FOQAData.sMessages.iProgressValue / (double)FOQAData.sMessages.iProgressMax) * 100);
            lProgress.Text = Math.Round(dPers, 1).ToString() + " %";
            lProsess.Text = FOQAData.sMessages.sProgressProsessMessage + "( " +
                FOQAData.sMessages.iProgressProsesValue + " of " +
                FOQAData.sMessages.iProgressProsesNumber + ")";
            pBar.Value = FOQAData.sMessages.iProgressValue;
            
        }

       

        
    }
}
