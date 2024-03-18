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
    public partial class fTest : Form
    {
        public const double EarthRadiusInMiles = 3956.0;
        public const double EarthRadiusInKilometers = 6367.0;
        public  static List<string> files = new List<string>();
        public fTest()
        {
            InitializeComponent();
        }

        public double DegreeToRadian(double angle) { return Math.PI * angle / 180.0; }
        public double RadianToDegree(double angle) { return 180.0 * angle / Math.PI; }
        

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            double dslat = Convert.ToDouble(tsLat.Text);
            double delat = Convert.ToDouble(teLat.Text);
            double dsLong = Convert.ToDouble(tsLong.Text);
            double deLong = Convert.ToDouble(teLong.Text);

            double distance = 0;
            double truebearing = 0;

            FOQAData.BearingDistance.bd(dslat, dsLong, delat, deLong, out distance, out truebearing);

            lBearing.Text = truebearing.ToString();
            lDistance.Text = distance.ToString();

            //double dRslat = DegreeToRadian(dslat);
            //double dRelat = DegreeToRadian(delat);


            ////  double R = (dType == DistanceType.Miles) ? EarthRadiusInMiles : EarthRadiusInKilometers;
            //double R = 3434.82;

            //double dRcheLat = DegreeToRadian(delat) - DegreeToRadian(dslat);
            //double dRcheLong = DegreeToRadian(deLong) - DegreeToRadian(dsLong);

            //double a = Math.Sin(dRcheLat / 2) * Math.Sin(dRcheLat / 2) + Math.Cos(DegreeToRadian(dslat)) * Math.Cos(DegreeToRadian(delat)) * Math.Sin(dRcheLong / 2) * Math.Sin(dRcheLong / 2);
            //double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            //double distance = c * R;

            //lDistance.Text = Math.Round(distance, 2).ToString();

            //double y = Math.Sin(dRcheLong) * Math.Cos(dRelat);
            //double x = Math.Cos(dRslat) * Math.Sin(dRelat) - Math.Sin(dRslat) * Math.Cos(dRelat) * Math.Cos(dRcheLong);
            //double brng = Math.Atan2(y, x);


            //lBearing.Text = ((RadianToDegree(brng) + 360) % 360).ToString();
            
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            
        }
    }



   



}
