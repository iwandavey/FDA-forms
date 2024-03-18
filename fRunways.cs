using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FOQAData;
using System.Diagnostics;

namespace FOQA
{
    public partial class fRunways : Form
    {
        protected static string sState = "";
        protected static int iRWYID;

        public fRunways()
        {
            InitializeComponent();
        }

        private void dgRunways_CurrentCellChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void bAply_Click(object sender, EventArgs e)
        {
            SetValues();
            
            if (sState == "Add")
            {
                fData.DataAirports.Insert_tRunway(fValue.sRunwayDesignator, fValue.iRunwayTrack, fValue.iRunwayElevation, fValue.bUseRunway,
                    fValue.desLatitude, fValue.desLongitude, fValue.iTouchDownMarkersLength);
                LoadData();
                sState = "Save";
            }
            else if (sState == "Edit")
            {
                fData.DataAirports.Update_tRunway(fValue.iRWYID, fValue.sRunwayDesignator, fValue.iRunwayTrack, fValue.iRunwayElevation, fValue.bUseRunway,
                    fValue.desLatitude, fValue.desLongitude, fValue.iTouchDownMarkersLength);
                LoadData();
                sState = "Save";
            }

            Enable(sState);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            sState = "Edit";
            Enable(sState);
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            sState = "Add";
            Enable(sState);
        }

        private void Enable(string sEnable)
        {
            if (sEnable == "")
            {
            }
            else if (sEnable == "Edit")
            {
                tRunway.Enabled = true;
                tTrack.Enabled = true;
                tElevation.Enabled = true;
                chbUseRunway.Enabled = true;

                tLatitude.Enabled = true;
                tLongitude.Enabled = true;
                tTouchDownZoneLength.Enabled = true;

                bAply.Enabled = true;
                bNew.Enabled = false;
                bEdit.Enabled = false;
            }
            else if (sEnable == "Add")
            {
                tRunway.Enabled = true;
                tTrack.Enabled = true;
                tElevation.Enabled = true;
                chbUseRunway.Enabled = true;

                tLatitude.Enabled = true;
                tLongitude.Enabled = true;
                tTouchDownZoneLength.Enabled = true;

                tLatitude.Text = "";
                tLongitude.Text = "";
                tTouchDownZoneLength.Text = "";
                
                tRunway.Text = "";
                tTrack.Text = "";
                tElevation.Text = "";
                chbUseRunway.Checked = false;

                bAply.Enabled = true;
                bNew.Enabled = false;
                bEdit.Enabled = false;
            }
            else if (sEnable == "Save")
            {
                tRunway.Enabled = false;
                tTrack.Enabled = false;
                tElevation.Enabled = false;
                chbUseRunway.Enabled = false;

                tLatitude.Enabled = false;
                tLongitude.Enabled = false;
                tTouchDownZoneLength.Enabled = false;
                
                bAply.Enabled = false;
                bEdit.Enabled = true;
                bNew.Enabled = true;
            }
        }

        private void fRunways_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgRunways.DataSource = fData.DataAirports.Load_Runways(fData.DataAirports.iAirportID);
            populate();
        }

        private void populate()
        {
            fValue.iRWYID = Convert.ToInt32(dgRunways[dgRunways.CurrentRowIndex, 0]);
            fValue.sRunwayDesignator = dgRunways[dgRunways.CurrentRowIndex, 1].ToString();
            fValue.iRunwayTrack = Convert.ToInt16(dgRunways[dgRunways.CurrentRowIndex, 2]);
            fValue.iRunwayElevation = Convert.ToInt16(dgRunways[dgRunways.CurrentRowIndex, 3]);
            fValue.bUseRunway = Convert.ToBoolean(dgRunways[dgRunways.CurrentRowIndex, 4]);
            fValue.desLatitude = Convert.ToDouble(dgRunways[dgRunways.CurrentRowIndex, 5]);
            fValue.desLongitude = Convert.ToDouble(dgRunways[dgRunways.CurrentRowIndex, 6]);
            fValue.iTouchDownMarkersLength = Convert.ToInt16(dgRunways[dgRunways.CurrentRowIndex, 7]);

        //    iRWYID = fValue.

            tRunway.Text = fValue.sRunwayDesignator;
            tTrack.Text = fValue.iRunwayTrack.ToString();
            tElevation.Text = fValue.iRunwayElevation.ToString();
            chbUseRunway.Checked = fValue.bUseRunway;
            tLatitude.Text = fValue.desLatitude.ToString();
            tLongitude.Text = fValue.desLongitude.ToString();
            tTouchDownZoneLength.Text = fValue.iTouchDownMarkersLength.ToString();
            //tTouchDownZoneLength.Text = 
            
        }

        private void SetValues()
        {
            fValue.iRWYID = Convert.ToInt32(dgRunways[dgRunways.CurrentRowIndex, 0]);
            fValue.sRunwayDesignator = tRunway.Text.ToString();
            fValue.iRunwayTrack = Convert.ToInt32(tTrack.Text);
            fValue.iRunwayElevation = Convert.ToInt32(tElevation.Text);
            fValue.desLatitude = Convert.ToDouble(tLatitude.Text);
            fValue.desLongitude = Convert.ToDouble(tLongitude.Text);
            fValue.iTouchDownMarkersLength = Convert.ToInt16(tTouchDownZoneLength.Text);
            fValue.bUseRunway = chbUseRunway.Checked;

            //if ((cLatitude.Text == "S")||(cLatitude.Text == "N"))
            //{
            //    fValue.sHem = cLatitude.Text;
            //}
            //fValue.iLatitudeD = Convert.ToInt16(tLatitudeDeg.Text);
            //fValue.iLatitudeM = Convert.ToInt16(tLatitudeMin.Text);
            //fValue.dLatitudeS = Convert.ToDouble(tLatitudeSec.Text);

            //if ((cLongitude.Text) == "E" || (cLongitude.Text == "W"))
            //{
            //    fValue.sDir = cLongitude.Text;
            //}
            //fValue.iLongitudeD = Convert.ToInt16(tLongitudeDeg.Text);
            //fValue.iLongitudeM = Convert.ToInt16(tLongitudeMin.Text);
            //fValue.dLongitudeS = Convert.ToInt16(tLongitudeSec.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sGoogleViewLatLong = new StringBuilder();
            sGoogleViewLatLong.Append("http://maps.google.com/maps?q=");
            sGoogleViewLatLong.Append(fValue.desLatitude.ToString() + ", " + "+" + fValue.desLongitude.ToString());

            Process.Start(sGoogleViewLatLong.ToString());

            
          
        }
    }
    public static class fValue
    {
        public static string sRunwayDesignator;
        public static int iRunwayTrack;
        public static int iRunwayElevation;
        public static int iTouchDownMarkersLength;
        public static int iRWYID;
        public static bool bUseRunway;

        public static double desLatitude = 0;
        public static string sHem = "";
        public static int iLatitudeD = 0;
        public static int iLatitudeM = 0;
        public static double dLatitudeS = 0;

        public static double desLongitude = 0;
        public static string sDir = "";
        public static int iLongitudeD = 0;
        public static int iLongitudeM = 0;
        public static double dLongitudeS = 0;

        

    }
}
