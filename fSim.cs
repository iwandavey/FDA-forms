using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FOQAData;
using FDAClassLibrary;


namespace FOQA
{
    

    public partial class fSim : Form
    {

        Boolean bStop = false;
        public int counter { get; set; }
        public int iwan;
        public fSim()
        {
            InitializeComponent();
        }

        private void fSim_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            tkBarPosition.Maximum = DataToAnalyse.fdaDataTable.Rows.Count;
            
            if (counter < 10)
            {
                tkBarPosition.Value = 10;
            }
            else
            {
                for (int i = 0; i < DataToAnalyse.fdaDataTable.Rows.Count - 10; i++)
                {
                    if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[i][FlightParameters.rowCounter]) == counter)
                    {
                        tkBarPosition.Value = i;
                        break;
                    }

                }
            }

            Cursor.Current = Cursors.Default;

        }

        private void play(int filePosition)
        {
            int iAlt1 = 0, iAlt2 = 0;
           
            for (int n = filePosition; n < DataToAnalyse.fdaDataTable.Rows.Count - 5; n++)
            {
                tsCounter.Text = DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.rowCounter].ToString();
                iAlt1 = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.altitudePressure]);
                iAlt2 = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n + 1][FlightParameters.altitudePressure]);
                EADI.ALT = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.altitudePressure]);

                EADI.CAS = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.speedCAS]);
                EADI.GroundSpeed = (short)Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.speedGround]);

                Int32.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.altitudeRadioLeft].ToString(), out int ra);
                EADI.RA = ra;

                EADI.PitchValue = (float)Convert.ToDouble(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.attitudePitchLeft]);
                //EADI.RollValue = ((float)((double)DataToAnalyse.fdaDataTable.Rows[n][csv.attitudeRoll])) - (2 * ((float)((double)DataToAnalyse.fdaDataTable.Rows[n][csv.attitudeRoll])));
                EADI.RollValue = ((float)Convert.ToDouble(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.attitudeRollLeft]));
                EADI.MachNo = DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.speedMach].ToString();
                    
                iAlt1 = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.altitudePressure]);
                iAlt2 = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n - 6][FlightParameters.altitudePressure]);
                EADI.VS = Convert.ToInt32((iAlt1-iAlt2) * 10);

                    
                float.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.navDevLocLeft].ToString(), out float f1);
                EADI.ILSloc = f1;
                float.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.navDevGSLeft].ToString(), out float f2);
                EADI.ILSgs = f2;

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.autoPilotA))
                {
                    if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.autoPilotA]) == 1)
                    {
                        EADI.FMAcmd = "CMD A";
                    }
                    else if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.autoPilotB]) == 1)
                    {
                        EADI.FMAcmd = "CMD B";
                    }
                    else
                    {
                        EADI.FMAcmd = "Off";
                    }
                }

                EHSI.HDG = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.magneticHeadingLeft]);
                EHSI.WindDirection = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.windDirection]);
                EHSI.WindVelocity = Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.windVelocity]);
                    
                float.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.flapTeLeft].ToString(), out float x);
                GFlap.Value = x;
                // get back to engine parameters

                for (int i = 0; i < FlightParameters.JetEngineParameters.Count; i++)
                {
                    if (i == 0)
                    {
                        float.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.JetEngineParameters[i].N1].ToString(), out float N1);
                        GE1N1.Value =N1;
                        lE1N1.Text = Math.Round(N1,1).ToString();
                    }
                    if (i == 1)
                    {
                        float.TryParse(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.JetEngineParameters[i].N1].ToString(), out float N1);
                        GE2N1.Value = N1;
                        lE2N1.Text = Math.Round(N1, 1).ToString();
                    }

                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.gearUpNose))
                {
                    if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.gearUpNose]) == 1)
                    {
                        lGearNose.BackColor = Color.Red;
                    }
                    else
                    {
                        lGearNose.BackColor = Color.LawnGreen;
                    }
                    if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][csv.gearLeftUp]) == 1)
                    {
                        lGearLeft.BackColor = Color.Red;
                    }
                    else
                    {
                        lGearLeft.BackColor = Color.LawnGreen;
                    }
                    if (Convert.ToInt32(DataToAnalyse.fdaDataTable.Rows[n][FlightParameters.gearUpRight]) == 1)
                    {
                        lGearRight.BackColor = Color.Red;
                    }
                    else
                    {
                        lGearRight.BackColor = Color.LawnGreen;
                    }
                }
              
                Thread.Sleep(tkBarSpeed.Value);
                Application.DoEvents();
                if (bStop)
                {
                    return;
                }

            }
        }

        private void tkBar_Scroll(object sender, EventArgs e)
        {
            tsCounter.Text = DataToAnalyse.fdaDataTable.Rows[tkBarPosition.Value][FlightParameters.rowCounter].ToString();
            bStop = false;
        }
        private void tsButtonPlay_Click(object sender, EventArgs e)
        {
            bStop = false;
            play(tkBarPosition.Value);
        }
        private void tsButtonStopPause_Click(object sender, EventArgs e)
        {
            bStop = true;
        }

    }
}
