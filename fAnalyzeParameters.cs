using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FOQA
{
    public partial class fAnalyzeParameters : Form
    {
        public fAnalyzeParameters()
        {
            InitializeComponent();
        }

        private void DisplayParameters()
        {
            //tMinFlapsUpALT.Text = FOQAData.Anelise.iMinFlapsUpALT.ToString();
            //tEarlyFlapRetract.Text = FOQAData.Anelise.iEarlyFlapRetract.ToString();
            //tLandingNoFlap.Text = FOQAData.Anelise.iLandingNoFlap.ToString();
            //tLandingFlapChange.Text = FOQAData.Anelise.iLandingFlapChange.ToString();
            //tMinPowerAlt.Text = FOQAData.Anelise.iMinPowerALT.ToString();
            //tSpeedAdditive.Text = FOQAData.Anelise.iSpeedAdditive.ToString();
            //cRotationRate.Checked = FOQAData.Anelise.bAnalizeRotationRate;
            //tBankAltitude.Text = FOQAData.Anelise.iBankALT.ToString();
            //tBankAngle.Text = FOQAData.Anelise.iMaxBankAngle.ToString();
        }

        private void fAnalyzeParameters_Load(object sender, EventArgs e)
        {
            DisplayParameters();
        }

        private void tMinFlapsUpALT_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tMinFlapsUpALT.Text;
            if (int.TryParse(s, out i))
            {
                tMinFlapsUpALT.Text = i.ToString();
            }
            else
            {
                tMinFlapsUpALT.Text = "0";
            }
        }

        private void tEarlyFlapRetract_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tEarlyFlapRetract.Text;
            if (int.TryParse(s, out i))
            {
                tEarlyFlapRetract.Text = i.ToString();
            }
            else
            {
                tEarlyFlapRetract.Text = "0";
            }
        }

        private void tLandingNoFlap_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tLandingNoFlap.Text;
            if (int.TryParse(s, out i))
            {
                tLandingNoFlap.Text = i.ToString();
            }
            else
            {
                tLandingNoFlap.Text = "0";
            }
        }

        private void tLandingFlapChange_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tLandingFlapChange.Text;
            if (int.TryParse(s, out i))
            {
                tLandingFlapChange.Text = i.ToString();
            }
            else
            {
                tLandingFlapChange.Text = "0";
            }
        }

        private void tMinPowerAlt_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tMinPowerAlt.Text;
            if (int.TryParse(s, out i))
            {
                tMinPowerAlt.Text = i.ToString();
            }
            else
            {
                tMinPowerAlt.Text = "0";
            }
        }

        private void tSpeedAdditive_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = tSpeedAdditive.Text;
            if (int.TryParse(s, out i))
            {
                tSpeedAdditive.Text = i.ToString();
            }
            else
            {
                tSpeedAdditive.Text = "0";
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //FOQAData.Anelise.iMinFlapsUpALT = Convert.ToInt16(tMinFlapsUpALT.Text);
            //FOQAData.Anelise.iEarlyFlapRetract = Convert.ToInt16(tEarlyFlapRetract.Text);
            //FOQAData.Anelise.iLandingNoFlap = Convert.ToInt16(tLandingNoFlap.Text);
            //FOQAData.Anelise.iLandingFlapChange = Convert.ToInt16(tLandingFlapChange.Text);
            //FOQAData.Anelise.iMinPowerALT = Convert.ToInt16(tMinPowerAlt.Text);
            //FOQAData.Anelise.iSpeedAdditive = Convert.ToInt16(tSpeedAdditive.Text);
            //FOQAData.Anelise.bAnalizeRotationRate = cRotationRate.Checked;
            //FOQAData.Anelise.iBankALT = Convert.ToInt16(tBankAltitude.Text);
            //FOQAData.Anelise.iMaxBankAngle = Convert.ToInt16(tBankAngle.Text);

        }

        private void jetParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FOQAData.Anelise.iMinFlapsUpALT = 1000;
            //FOQAData.Anelise.iEarlyFlapRetract = 700;
            //FOQAData.Anelise.iLandingNoFlap = 1000;
            //FOQAData.Anelise.iLandingFlapChange = 800;
            //FOQAData.Anelise.iMinPowerALT = 800;
            //FOQAData.Anelise.iSpeedAdditive = 5;
            //FOQAData.Anelise.bAnalizeRotationRate = true;

            DisplayParameters();
        }

        private void propParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FOQAData.Anelise.iMinFlapsUpALT = 500;
            //FOQAData.Anelise.iEarlyFlapRetract = 500;
            //FOQAData.Anelise.iLandingNoFlap = 500;
            //FOQAData.Anelise.iLandingFlapChange = 500;
            //FOQAData.Anelise.iMinPowerALT = 500;
            //FOQAData.Anelise.iSpeedAdditive = 5;
            //FOQAData.Anelise.bAnalizeRotationRate = false;

            //DisplayParameters();
        }

        private void setDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        

        
       

        
    }
}
