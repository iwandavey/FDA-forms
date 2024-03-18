using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace FOQAcalc
{
    public class cCalc
    {
        /// <summary>
        /// This method calculate acceleration in fps.
        /// </summary>
        /// <param name="initialVelocity">Enter the ititial velocity in knots</param>
        /// <param name="finalVelocity">Enter the final velocity in knots</param>
        /// <param name="timeSeconds">enter time in seconds</param>
        /// <returns>Return the acceleration / deceleration(-) in fps</returns>
        public static double Acceleration(double initialVelocity, double finalVelocity, double timeSeconds)
        {
            //double acceleration = 0;
            double knotsToFPSConstant = 1.6878098571;
            return Math.Round(((finalVelocity * knotsToFPSConstant) - (initialVelocity * knotsToFPSConstant)) / timeSeconds,3);


        }
        public static void LatLongDtoL(double dLat, double dLong, out int iLatitude_D, out int iLatitude_M, out double dLatitude_S, out string sLatitude,
            out int iLongitude_D, out int iLongitude_M, out double dLongitude_S, out string sLongitude)
        {
            sLatitude = dLat < 0? "S" : "N";
            sLongitude = dLong < 0 ? "W" : "E";
            
            dLat = Math.Abs(dLat);
            double d = Math.Floor(dLat);
            dLat -= d;
            dLat *= 60;
            double m = Math.Floor(dLat);
            dLat -= m;
            dLat *= 60;
            double s = Math.Floor(dLat);

            iLatitude_D = Convert.ToInt16(d);
            iLatitude_M = Convert.ToInt16(m);
            dLatitude_S = s;

            dLong = Math.Abs(dLong);
            d = Math.Floor(dLong);
            dLong -= d;
            dLong *= 60;
            m = Math.Floor(dLong);
            dLong -= m;
            dLong *= 60;
            s = Math.Floor(dLong);

            iLongitude_D = Convert.ToInt16(d);
            iLongitude_M = Convert.ToInt16(m);
            dLongitude_S = s;
            
        }

        public static void LatLong_DMStoDouble(int iLat_D, int iLat_M, double dLat_S, string sLat_Hem,
            int iLong_D, int iLong_M, double dLong_S, string sLong_Dir, out double dLatitude_Double, out double dLongitude_Double)
        {
            double dLong_M = iLong_M;
            //double dLong_S = iLong_S;

            double dLat_M = iLat_M;
            //double dLat_S = iLat_S;

            dLong_M /= 60;
            dLong_S /= 3600;

            dLat_M /= 60;
            dLat_S /= 3600;

            dLongitude_Double = iLong_D + dLong_M + dLong_S;
            dLatitude_Double = iLat_D + dLat_M + dLat_S;

            if (sLat_Hem.ToUpper() == "S")
            {
                dLatitude_Double *= -1;
            }

            if (sLong_Dir.ToUpper() == "W")
            {
                dLongitude_Double *= -1;
            }
            
        }
    }
}
