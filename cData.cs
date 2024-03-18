using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Collections.Generic;
using System.Xml.XPath;
using FOQA;
using FDAClassLibrary;

namespace FOQAData
{
    /// <summary>
    /// Summary description for Global.
    /// </summary>
    /// 
    public class appSettings
    {
        public static string Mode = "dev";
        //public static string Mode = "user";
        //public static string Mode = "demo";

        public static string company = null;
        public static string csvPath = null;

    }
    public class sMessages
    {
        public static string sMessage = "FDA";
        public static string sMessageError = "FDA - Error";
        public static string sProgressMessage = "";
        public static string sProgressProsessMessage = "";
        public static int iProgressMin = 0;
        public static Int32 iProgressMax = 100;
        public static Int32 iProgressValue = 0;
        public static int iProgressProsesValue = 1;
        public static int iProgressProsesNumber = 1;

    }
    public class csv
    {
    
        public static bool bCSVloaded { get; set; } = false;
        public static bool csvParametersLoaded = false;
        public static bool tekenMerkerLynGrafiek = false;
        public static string csvFileName = "";
        public static string sExceedance = "";
        public static string sEXCcounter = "";
        public static string sEXCnote = "";
        public static string sExcID = "";
        public static string Reg = "";
        public static string Type = "";
        public static int fileId;
        public static int aircraftID;
        public static DateTime dtEXCDate = DateTime.Today;
        public static string csvPath = "";

        public static int EXCFilePostion = 0;

        public static string accelerationVerticalMax = "";
        public static string accelerationLongitudinalMax = "";
        public static string accelerationLongitudinalMin = "";
        public static string accelerationLateralMax = "";
        public static string airGnd = "airGND";
        public static string airGndNse = "noseAirGnd";
        public static string airGndLt = "leftAirGnd";
        public static string airGndRt = "rightAirGnd";
        public static string autoPilotA = "CMD_A";
        public static string autoPilotB = "CMD_B";

        public static string altitudeD = "";
        public static string altitudeP = "";
        public static string altitudeR = "";
        public static string attitudePitch = "";
        public static string attitudeRoll = "";

        public static string counter = "";
        public static string chtUnitMeasure;
        public static string chtReqUnitMeasure;

        public static string dateDay = "dateDay";
        public static string dateMonth = "dateMonth";
        public static string dateYear = "";
        public static string dateGMT = "date";
        public static string navDMELeft = "";
        public static string navDMERight = "";
        public static string navFreqLeft = "";
        public static string navFreqRight = "";

        #region Jet engined aircraft
        public static string eng1Bleed = "ENG1bleed";
        public static string eng1EGT = "ENG1egt";
        public static string eng1FuelFlow = "ENG1ff";
        public static string eng1N1 = "ENG1N1";
        public static string eng1N2 = "ENG1N2";
        public static string eng1OilPressure = "ENG1oilPress";
        public static string eng1OilTemp = "ENG1oilTemp";
        public static string eng1StartLever = "ENG1CutOff";
        public static string eng1ThrottleLeverAngle = "ENG1tla";

        public static string eng2Bleed = "ENG2bleed";
        public static string eng2EGT = "ENG2egt";
        public static string eng2FuelFlow = "ENG2ff";
        public static string eng2N1 = "ENG2N1";
        public static string eng2N2 = "ENG2N2";
        public static string eng2OilPressure = "ENG2oilPress";
        public static string eng2OilTemp = "ENG2oilTemp";
        public static string eng2StartLever = "ENG2CutOff";
        public static string eng2ThrottleLeverAngle = "ENG2tla";
        #endregion
        
        public static string eng1CHT1 = "";
        public static string eng1CHT2 = "";
        public static string eng1CHT3 = "";
        public static string eng1CHT4 = "";
        public static string eng1CHT5 = "";
        public static string eng1CHT6 = "";
        public static string egtUnitMeasure;
        public static string egtReqUnitMeasure;
        public static string eng1EGT1 = "";
        public static string eng1EGT2 = "";
        public static string eng1EGT3 = "";
        public static string eng1EGT4 = "";
        public static string eng1EGT5 = "";
        public static string eng1EGT6 = "";
        public static string eng1FuelPress = "";
        public static string engFuelFlowMaxValue;

        public static string eng1MP = "";

        public static string eng1RPM = "";
        public static string eng2RPM = "";

        public static string flapHandlePos = "flapHandlePosition";
        public static string flapTE = "FlapTE";
        public static string flapTELeft = "flapTELeft";
        public static string flapTERight = "flapTERight";

        public static string flightNumber = "";

        public static string fuelTankLeft = "leftMainFuelQTY";
        public static string fuelTankCentre = "centerMainFuelQTY";
        public static string fuelTankRight = "rightMainFuelQTY";
        public static string fuelTotal = "";
        public static string fuelReqUnitMeasure;
        public static string fuelUnitMeasure;
// TODO : Fuel max value
        public static string gearLeverDown = "GEARdwn";
        public static string gearNoseUp = "GEARdwn_nse";
        public static string gearLeftUp = "GEARdwn_lt";
        public static string gearRightUp = "GEARdwn_rt";
        public static string grossWeight = "grossWeight";
        public static string grossWeightUnitMeasure;
        public static string grossWeightReqWeightMeasure;

        public static string heading = "HDGmag";

        public static string latitude = "latitude";
        public static string longitude = "longitude";

        public static string messageText = "";
        public static string navDevGs = "";
        public static string navDevLoc = "";

        public static string speedBrakeHandle = "speedBrakeHandle";
        public static string speedCAS = "CAS";
        public static string speedGround= "groundSpeed";
        public static string speedMach = "Mach";
        public static string speedTAS = "";
        public static string speedV2 = "";
        public static string speedVR = "Vr";
        public static string speedVref = "";

        public static string TAT = "TAT";
        public static string timeGMT = "GMT";
        public static string timeHr = "";
        public static string timeMin = "";
        public static string timeSec = "";

        public static string verticalSpeed;

        public static string windDir = "windDir";
        public static string windVel = "windSpeed";

        public static string wrnSpeedAircraftLim1 = "overSpeedAircraft1";
        public static string wrnSpeedAircraftLim2 = "overSpeedAircraft2";
        public static string wrnStall1 = "stickShakerLT1";
        public static string wrnStall2 = "stickShakerLT2";
        public static string wrnStall3 = "stickShakerLT3";
        public static string wrnStall4 = "stickShakerLT4";

        public static string wrnDontSink = "WRNdontsink";
        public static string wrnPullUp = "WRNpullup";
        public static string wrnSinkRate = "WRNsinkrate";
        public static string wrnTerrain = "WRNterrain";
        public static string wrnTerrainPullUp = "WRNterrainpullup";
        public static string wrnTooLowTerrain = "WRNtoolowterrain";
        public static string wrnTooLowFlap = "WRNtoolowflap";
        public static string wrnTooLowGear = "WRNtoolowgear";
        public static string wrnWindShear = "WRNwindshear";

        public static IList<string> Warnings = new List<string>();

        public static DataSet loadCSV(string path, string fileName)
        {
            DataSet ds = new DataSet();
            OleDbConnection cnCSV = new OleDbConnection(); 
            try
            {
                cnCSV.ConnectionString = "Provider=\"Microsoft.Jet.OLEDB.4.0\";" +
                              "Data Source=" + path + ";" +
                              "Extended Properties=\"text;HDR=Yes;FMT=Delimited(,)\";";

                OleDbCommand comm = new OleDbCommand("SELECT * FROM [" + fileName + "#csv] ", cnCSV);
                cnCSV.Open();

                OleDbDataAdapter d = new OleDbDataAdapter(comm);

                d.Fill(ds, fileName);

                return ds;
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), "Error loading csv.");
                ds = null;
                return ds;
            }
            finally
            {
                cnCSV.Close();
            }

        }

        public static DataTable loadCSVtable(string path, string fileName)
        {
            DataTable dt = new DataTable();
            OleDbConnection cnCSV = new OleDbConnection();
            try
            {
                cnCSV.ConnectionString = "Provider=\"Microsoft.Jet.OLEDB.4.0\";" +
                              "Data Source=" + path + ";" +
                              "Extended Properties=\"text;HDR=Yes;FMT=Delimited(,)\";";

                OleDbCommand comm = new OleDbCommand("SELECT * FROM [" + fileName + "#csv] ", cnCSV);
                
                cnCSV.Open();
                
                OleDbDataAdapter d = new OleDbDataAdapter(comm);
                
                d.Fill(dt);

                return dt;
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), "Error loading csv.");
                dt = null;
                return dt;
            }
            finally
            {
                dt.Dispose();
                cnCSV.Close();
            }

        }

        public static DataTable loaddtCSV(string path, string fileName)
        {
            DataTable dt = new DataTable();
            OleDbConnection cnCSV = new OleDbConnection();
            try
            {
                cnCSV.ConnectionString = "Provider=\"Microsoft.Jet.OLEDB.4.0\";" +
                              "Data Source=" + path + ";" +
                              "Extended Properties=\"text;HDR=Yes;FMT=Delimited(,)\";";

                //OleDbCommand comm = new OleDbCommand("SELECT * FROM [" + fileName + "#csv] WHERE (CAS > 60 AND ((ALT <  18000) AND (ALT > -500)))  ORDER BY [COUNTER]", cnCSV);
                // TODO : Garmin hersien
                //OleDbCommand comm = new OleDbCommand("SELECT * FROM [" + fileName + "#csv] WHERE (CAS > 45)  ORDER BY [COUNTER]", cnCSV);
                OleDbCommand comm = new OleDbCommand("SELECT * FROM [" + fileName + "#csv] ", cnCSV);
                cnCSV.Open();

                OleDbDataAdapter d = new OleDbDataAdapter(comm);

                d.Fill(dt);

                return dt;
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), "Error loading csv.");
                dt = null;
                return dt;
            }
            finally
            {
                cnCSV.Close();
            }


        }
        public static bool csvFileExists(string rootpath, string filename)
        {
            if (File.Exists(Path.Combine(rootpath, filename)))
                return true;

            foreach (string subDir in Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories))
            {
                if (File.Exists(Path.Combine(subDir, filename)))
                    return true;
            }

            return false;
        }
        public static void setParameters()
        {
            DataSet ds = new DataSet();
            OleDbCommand cmdEx = new OleDbCommand();

            //Assign Connection

            cmdEx.Connection = new OleDbConnection(fData.DataProc.sCon);
            cmdEx.Connection.Open();
            cmdEx.CommandText = "Select * from paramConfig where AircraftId = " + aircraftID;

            OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);
            da.Fill(ds, "paramConfig");

            if (ds.Tables["paramConfig"].Rows.Count != 1)
            {
                csvParametersLoaded = false;
                MessageBox.Show("Error - Aircraft parameters for " + csv.Reg + " has not been loaded. You will not be able to analyse or view graphs.", "csv Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string commandText = null; 
            if (ds.Tables["paramConfig"].Rows[0]["EngineType"].ToString().ToLower() == "jet")
            {
                commandText = "SELECT * FROM paramJetEngine where AircraftId = " + aircraftID;
            }

            if (ds.Tables["paramConfig"].Rows[0]["EngineType"].ToString().ToLower() == "piston")
            {
                commandText = "SELECT * FROM paramPistonEngine where AircraftId = " + aircraftID;
            }

            cmdEx.CommandText = commandText;
            da.SelectCommand = cmdEx;
            da.Fill(ds, "paramEngine");

            cmdEx.CommandText = "Select * from Warnings where AircraftId = " + aircraftID;
            da.SelectCommand = cmdEx;
            da.Fill(ds, "Warnings");

            cmdEx.Connection.Close();
            
            if (ds.Tables[0].Rows.Count == 1)
            {
                #region New parameters
                DataRow r = ds.Tables[0].Rows[0];
                
                FlightParameters.accelerationLateralMax = r["accelerationLateralMax"].ToString();
                FlightParameters.accelerationLateralMin = "Geen";
                FlightParameters.accelerationLongitudinalMax = r["accelerationLongitudinalMax"].ToString();
                FlightParameters.accelerationLongitudinalMin = r["accelerationLongitudinalMin"].ToString();
                FlightParameters.accelerationVerticalMax = r["accelerationVerticalMax"].ToString();
                FlightParameters.accelerationVerticalMin = "Geen";

                FlightParameters.airGround = r["airGND"].ToString();
                FlightParameters.airGroundLeftMain = r["airGndLt"].ToString();
                FlightParameters.airGroundNose = r["airGndNse"].ToString();
                FlightParameters.airGroundRightMain = r["airGndRt"].ToString();

                FlightParameters.altitudeDensity = r["altitudeD"].ToString();
                FlightParameters.altitudePressure = r["altitudeP"].ToString();
                FlightParameters.altitudeRadioLeft = r["altitudeR"].ToString();

                FlightParameters.autoPilotA = r["autoPilotA"].ToString(); 
                FlightParameters.autoPilotB = r["autoPilotB"].ToString();

                FlightParameters.attitudePitchLeft = r["attitudePitch"].ToString();
                FlightParameters.attitudeRollLeft = r["attitudeRoll"].ToString();

                FlightParameters.EngineType = r["EngineType"].ToString();

                FlightParameters.GMTdate = r["dateGMT"].ToString();
                FlightParameters.GMTtime = r["timeGMT"].ToString();

                FlightParameters.flapHandlePosition = r["flapHandlePos"].ToString();
                FlightParameters.flapTeLeft = r["flapTeLeft"].ToString();
                FlightParameters.flapTeRight = r["flapTeRight"].ToString();

                FlightParameters.flightNumber = r["flightNumber"].ToString();

                FlightParameters.fuelTankCenterQuantity = r["fuelTankCentre"].ToString();
                FlightParameters.fuelTankLeftQuantity = r["fuelTankLeft"].ToString();
                FlightParameters.fuelTankRightQuantity = r["fuelTankRight"].ToString();
                FlightParameters.fuelTotalQuantity = r["fuelTotal"].ToString();

                FlightParameters.fuelFlowMax = r["engFuelFlowMaxValue"].ToString();
               

                FlightParameters.gearLeverDown = r["gearLeverDown"].ToString();
                FlightParameters.gearUpLeft = r["gearLeftUp"].ToString();
                FlightParameters.gearUpNose = r["gearNoseUp"].ToString();
                FlightParameters.gearUpRight = r["gearRightUp"].ToString();

                FlightParameters.grossWeight = r["grossWeight"].ToString();
                
                FlightParameters.magneticHeadingLeft = r["heading"].ToString();

                FlightParameters.latitude = r["latitude"].ToString();
                FlightParameters.longitude = r["longitude"].ToString();

                FlightParameters.navDevGSLeft = r["navDevGs"].ToString();
                FlightParameters.navDevLocLeft = r["navDevLoc"].ToString();

                FlightParameters.navDMELeft = r["NavDMELeft"].ToString();
                FlightParameters.navDMERight = r["NavDMERight"].ToString();
                FlightParameters.navFreqLeft = r["NavFreqLeft"].ToString();
                FlightParameters.navFreqRight = r["NavFreqRight"].ToString();

                FlightParameters.rowCounter = r["counter"].ToString();
                
                FlightParameters.speedBrakeHandle = r["speedBrakeHandle"].ToString();
                FlightParameters.speedCAS = r["speedCAS"].ToString();
                FlightParameters.speedGround = r["speedGround"].ToString();
                FlightParameters.speedMach = r["speedMach"].ToString();
                FlightParameters.speedTAS = r["speedTAS"].ToString();
                FlightParameters.speedV2 = r["speedV2"].ToString();
                FlightParameters.speedVR = r["speedVR"].ToString();
                FlightParameters.speedVref = r["speedVref"].ToString();
               
                FlightParameters.TAT = r["TAT"].ToString();

                FlightParameters.verticalSpeed = r["verticalSpeed"].ToString();

                FlightParameters.unitEGTNormalised = r["egtUnitMeasure"].ToString();
                FlightParameters.unitEGTRequired = r["egtUnitMeasure"].ToString();
                FlightParameters.unitFuelNormalised = r["fuelUnitMeasure"].ToString();
                FlightParameters.unitFuelRequired = r["fuelReqUnitMeasure"].ToString();
                FlightParameters.unitWeightNormalised = r["grossWeightUnitMeasure"].ToString();
                FlightParameters.unitWeightRequired = r["grossWeightReqUnitMeasure"].ToString();

                FlightParameters.windDirection = r["windDir"].ToString();
                FlightParameters.windVelocity = r["windVel"].ToString();

                #endregion
                #region old parameters
                //accelerationLongitudinalMax = ds.Tables[0].Rows[0]["accelerationLongitudinalMax"].ToString();
                //accelerationLongitudinalMin = ds.Tables[0].Rows[0]["accelerationLongitudinalMin"].ToString();
                //accelerationVerticalMax = ds.Tables[0].Rows[0]["accelerationVerticalMax"].ToString();
                //accelerationLateralMax = ds.Tables[0].Rows[0]["accelerationLateralMax"].ToString();
                //airGnd = ds.Tables[0].Rows[0]["airGND"].ToString();
                //airGndNse = ds.Tables[0].Rows[0]["airGndNse"].ToString();
                //airGndLt = ds.Tables[0].Rows[0]["airGndLt"].ToString();
                //airGndRt = ds.Tables[0].Rows[0]["airGndRt"].ToString();
                //autoPilotA = ds.Tables[0].Rows[0]["autoPilotA"].ToString();
                //autoPilotB = ds.Tables[0].Rows[0]["autoPilotB"].ToString();

                //altitudeD = ds.Tables[0].Rows[0]["altitudeD"].ToString();
                //altitudeP = ds.Tables[0].Rows[0]["altitudeP"].ToString();
                //altitudeR = ds.Tables[0].Rows[0]["altitudeR"].ToString();
                //attitudePitch = ds.Tables[0].Rows[0]["attitudePitch"].ToString();
                //attitudeRoll = ds.Tables[0].Rows[0]["attitudeRoll"].ToString();
    
                //counter = ds.Tables[0].Rows[0]["counter"].ToString();
                //chtUnitMeasure = ds.Tables[0].Rows[0]["chtUnitMeasure"].ToString();
                //chtReqUnitMeasure = ds.Tables[0].Rows[0]["chtReqUnitMeasure"].ToString();
                //dateDay = ds.Tables[0].Rows[0]["dateDay"].ToString();
                //dateMonth = ds.Tables[0].Rows[0]["dateMonth"].ToString();
                //dateYear = ds.Tables[0].Rows[0]["dateYear"].ToString();
                //dateGMT = ds.Tables[0].Rows[0]["dateGMT"].ToString();
                
                //eng1Bleed = ds.Tables[0].Rows[0]["eng1Bleed"].ToString();
                //eng1CHT1 = ds.Tables[0].Rows[0]["eng1CHT1"].ToString();
                //eng1CHT2 = ds.Tables[0].Rows[0]["eng1CHT2"].ToString();
                //eng1CHT3 = ds.Tables[0].Rows[0]["eng1CHT3"].ToString();
                //eng1CHT4 = ds.Tables[0].Rows[0]["eng1CHT4"].ToString();
                //eng1CHT5 = ds.Tables[0].Rows[0]["eng1CHT5"].ToString();
                //eng1CHT6 = ds.Tables[0].Rows[0]["eng1CHT6"].ToString();
                //egtReqUnitMeasure = ds.Tables[0].Rows[0]["egtReqUnitMeasure"].ToString();
                //egtUnitMeasure = ds.Tables[0].Rows[0]["egtUnitMeasure"].ToString();
                //eng1EGT = ds.Tables[0].Rows[0]["eng1EGT"].ToString();
                //eng1EGT1 = ds.Tables[0].Rows[0]["eng1EGT1"].ToString();
                //eng1EGT2 = ds.Tables[0].Rows[0]["eng1EGT2"].ToString();
                //eng1EGT3 = ds.Tables[0].Rows[0]["eng1EGT3"].ToString();
                //eng1EGT4 = ds.Tables[0].Rows[0]["eng1EGT4"].ToString();
                //eng1EGT5 = ds.Tables[0].Rows[0]["eng1EGT5"].ToString();
                //eng1EGT6 = ds.Tables[0].Rows[0]["eng1EGT6"].ToString();

                //eng1FuelFlow = ds.Tables[0].Rows[0]["eng1FuelFlow"].ToString();
                //eng1FuelPress = ds.Tables[0].Rows[0]["eng1FuelPress"].ToString();
                
                //engFuelFlowMaxValue = ds.Tables[0].Rows[0]["engFuelFlowMaxValue"].ToString();

                //eng1N1 = ds.Tables[0].Rows[0]["eng1N1"].ToString();
                //eng1N2 = ds.Tables[0].Rows[0]["eng1N2"].ToString();
                //eng1MP = ds.Tables[0].Rows[0]["eng1MP"].ToString();
                //eng1OilPressure = ds.Tables[0].Rows[0]["eng1OilPressure"].ToString(); 
                //eng1OilTemp = ds.Tables[0].Rows[0]["eng1OilTemp"].ToString();
                //eng1RPM = ds.Tables[0].Rows[0]["eng1RPM"].ToString();
                //eng1StartLever = ds.Tables[0].Rows[0]["eng1StartLever"].ToString();
                //eng1ThrottleLeverAngle = ds.Tables[0].Rows[0]["eng1ThrottleLeverAngle"].ToString();

                //eng2Bleed = ds.Tables[0].Rows[0]["eng2Bleed"].ToString();
                //eng2EGT = ds.Tables[0].Rows[0]["eng2EGT"].ToString();
                //eng2FuelFlow = ds.Tables[0].Rows[0]["eng2FuelFlow"].ToString();
                //eng2N1 = ds.Tables[0].Rows[0]["eng2N1"].ToString();
                //eng2N2 = ds.Tables[0].Rows[0]["eng2N2"].ToString();
                //eng2OilPressure = ds.Tables[0].Rows[0]["eng2OilPressure"].ToString();
                //eng2OilTemp = ds.Tables[0].Rows[0]["eng2OilTemp"].ToString();
                //eng2StartLever = ds.Tables[0].Rows[0]["eng2StartLever"].ToString();
                //eng2ThrottleLeverAngle = ds.Tables[0].Rows[0]["eng2ThrottleLeverAngle"].ToString();

                //flapHandlePos = ds.Tables[0].Rows[0]["flapHandlePos"].ToString();
                //flapTE = ds.Tables[0].Rows[0]["flapTE"].ToString();
                //flapTELeft = ds.Tables[0].Rows[0]["flapTELeft"].ToString();
                //flapTERight = ds.Tables[0].Rows[0]["flapTERight"].ToString();

                //flightNumber = ds.Tables[0].Rows[0]["flightNumber"].ToString();

                //fuelTankLeft = ds.Tables[0].Rows[0]["fuelTankLeft"].ToString();
                //fuelTankCentre = ds.Tables[0].Rows[0]["fuelTankCentre"].ToString();
                //fuelTankRight = ds.Tables[0].Rows[0]["fuelTankRight"].ToString();
                //fuelTotal = ds.Tables[0].Rows[0]["fuelTotal"].ToString();

                //fuelReqUnitMeasure = ds.Tables[0].Rows[0]["fuelReqUnitMeasure"].ToString();
                //fuelUnitMeasure = ds.Tables[0].Rows[0]["fuelUnitMeasure"].ToString();

                //gearLeverDown = ds.Tables[0].Rows[0]["gearLeverDown"].ToString();
                //gearNoseUp = ds.Tables[0].Rows[0]["gearNoseUp"].ToString();
                //gearLeftUp = ds.Tables[0].Rows[0]["gearLeftUp"].ToString();
                //gearRightUp = ds.Tables[0].Rows[0]["gearRightUp"].ToString();

                //grossWeight = ds.Tables[0].Rows[0]["grossWeight"].ToString();
                //grossWeightUnitMeasure = ds.Tables[0].Rows[0]["grossWeightUnitMeasure"].ToString();
                //grossWeightReqWeightMeasure = ds.Tables[0].Rows[0]["grossWeightReqUnitMeasure"].ToString();
                
                //heading = ds.Tables[0].Rows[0]["heading"].ToString();

                //latitude = ds.Tables[0].Rows[0]["latitude"].ToString();
                //longitude = ds.Tables[0].Rows[0]["longitude"].ToString();

                //messageText = ds.Tables[0].Rows[0]["MessageText"].ToString();// die waardes is nie algemeen op 737 nie.

                //navDevGs = ds.Tables[0].Rows[0]["navDevGs"].ToString();
                //navDevLoc = ds.Tables[0].Rows[0]["navDevLoc"].ToString();
                //navDMELeft = ds.Tables[0].Rows[0]["NavDMELeft"].ToString();
                //navDMERight = ds.Tables[0].Rows[0]["NavDMERight"].ToString();
                //navFreqLeft = ds.Tables[0].Rows[0]["NavFreqLeft"].ToString();
                //navFreqRight = ds.Tables[0].Rows[0]["NavFreqRight"].ToString();
                
                //speedBrakeHandle = ds.Tables[0].Rows[0]["speedBrakeHandle"].ToString();
                //speedCAS = ds.Tables[0].Rows[0]["speedCAS"].ToString();
                //speedGround = ds.Tables[0].Rows[0]["speedGround"].ToString();
                //speedMach = ds.Tables[0].Rows[0]["speedMach"].ToString();
                //speedTAS = ds.Tables[0].Rows[0]["speedTAS"].ToString();
                //speedV2 = ds.Tables[0].Rows[0]["speedV2"].ToString();
                //speedVR = ds.Tables[0].Rows[0]["speedVR"].ToString();
                //speedVref = ds.Tables[0].Rows[0]["speedVref"].ToString();

                //TAT = ds.Tables[0].Rows[0]["TAT"].ToString();

                //timeGMT = ds.Tables[0].Rows[0]["timeGMT"].ToString();
                
                //timeHr = ds.Tables[0].Rows[0]["timeHr"].ToString();
                //timeMin = ds.Tables[0].Rows[0]["timeMin"].ToString();
                //timeSec = ds.Tables[0].Rows[0]["timeSec"].ToString();
                

                //verticalSpeed = ds.Tables[0].Rows[0]["verticalSpeed"].ToString();

                //windDir = ds.Tables[0].Rows[0]["windDir"].ToString();
                //windVel = ds.Tables[0].Rows[0]["windVel"].ToString();

                //wrnSpeedAircraftLim1 = ds.Tables[0].Rows[0]["wrnSpeedAircraftLim1"].ToString();
                //wrnSpeedAircraftLim2 = ds.Tables[0].Rows[0]["wrnSpeedAircraftLim2"].ToString();
                //wrnStall1 = ds.Tables[0].Rows[0]["wrnStall1"].ToString();
                //wrnStall2 = ds.Tables[0].Rows[0]["wrnStall2"].ToString();
                //wrnStall3 = ds.Tables[0].Rows[0]["wrnStall3"].ToString();
                //wrnStall4 = ds.Tables[0].Rows[0]["wrnStall4"].ToString();
#endregion
                csvParametersLoaded = true;
            }
            else
            {
                csvParametersLoaded = false;
                MessageBox.Show("Error - Aircraft parameters for " + csv.Reg + " has not been loaded. You will not be able to analyse or view graphs.", "csv Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FlightParameters.JetEngineParameters.Clear();

            if (ds.Tables["paramEngine"].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables["paramEngine"].Rows)
                {
                    //Warnings.Add(r["Warning"].ToString());
                    FlightParameters.JetEngineParameters.Add(new JetEngineParameters() 
                    {   bleed = r["Bleed"].ToString(), 
                        engineNumber = int.Parse(r["EngineNumber"].ToString()),
                        egt = r["egt"].ToString(),
                        ff = r["FuelFlow"].ToString(),
                        N1 = r["N1"].ToString(),
                        N2 = r["N2"].ToString(),
                        oilPressure = r["OilPress"].ToString(),
                        oilTemp = r["OilTemp"].ToString(),
                        fuelLever = r["StartLever"].ToString(),
                        thrustLeverAngle = r["ThrustLeverAngle"].ToString()
                    });

                }
            }
            else if (!ds.Tables.Contains("paramEngine"))
            {
                csvParametersLoaded = false;
                MessageBox.Show("Error - Aircraft engine parameters for " + csv.Reg + " could not been loaded. You will not be able to analyse or view graphs.", "csv Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FlightParameters.BinereParameters.Clear();
            
            if (ds.Tables["Warnings"].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables["Warnings"].Rows)
                {
                    FlightParameters.BinereParameters.Add(new BinaryParameters()
                    {   parameter = r["Warning"].ToString(),
                        flagValue = bool.Parse(r["FlagValue"].ToString())
                    });
                }
            }

            ds = null;
        }
        public static double setEgtUnit(double temp)
        {
            double result = 0;

            csv.egtUnitMeasure = csv.egtUnitMeasure.ToLower();
            csv.egtReqUnitMeasure = csv.egtReqUnitMeasure.ToLower();
            if (csv.egtUnitMeasure == "c" && csv.egtReqUnitMeasure == "f")
            {
                result = conversionTools.convertCtoF(temp);
            }
            else if (csv.egtUnitMeasure == "f" && csv.egtReqUnitMeasure == "c")
            {
                result = conversionTools.convertFtoC(temp);
            }
            else
            {
                result = temp;
            }

            return result;
        }

        public static double setChtUnit(double cht)
        {
            double result;

            csv.chtUnitMeasure = csv.chtUnitMeasure.ToLower();
            csv.chtReqUnitMeasure = csv.chtReqUnitMeasure.ToLower();

            if (csv.chtUnitMeasure == "c" && csv.chtReqUnitMeasure == "f")
            {
                result = conversionTools.convertCtoF(cht);
            }
            else if (csv.chtUnitMeasure == "f" && csv.chtReqUnitMeasure == "c")
            {
                result = conversionTools.convertFtoC(cht);
            }
            else
            {
                result = cht;
            }

            return result;
        }

        public static double setFuelUnit(double fuel)
        {
            double result;

            if (FlightParameters.unitFuelNormalised.ToLower()  == "kg" && FlightParameters.unitFuelRequired.ToLower() == "lbs")
            {
                result = conversionTools.convertKgToLbs(fuel);
            }
            else if (FlightParameters.unitFuelNormalised.ToLower() == "lbs" && FlightParameters.unitFuelRequired.ToLower() == "kg")
            {
                result = conversionTools.convertLbsToKg(fuel);
            }
            else if (FlightParameters.unitFuelNormalised.ToLower() == "usgal" && FlightParameters.unitFuelRequired.ToLower() == "l")
            {
                result = conversionTools.convertUsgToL(fuel);
            }
            else if (FlightParameters.unitFuelNormalised.ToLower() == "l  " && csv.fuelReqUnitMeasure == "usgal")
            {
                result = conversionTools.convertLToUsg(fuel);
            }
            else
            {
                result = fuel;
            }
            return result;
        }

        public static double setGrossWeight(double weight)
        {
            double result;
            
            if (FlightParameters.unitWeightNormalised.ToLower() == "kg" && FlightParameters.unitWeightNormalised.ToLower() == "lbs")
            {
                result = conversionTools.convertKgToLbs(weight);
            }
            else if (FlightParameters.unitWeightNormalised.ToLower() == "lbs" && FlightParameters.unitWeightNormalised.ToLower() == "kg")
            {
                result = conversionTools.convertLbsToKg(weight);
            }
            else
            {
                result = weight;
            }
            return result;
        }

    }
    public class Analyse
    {
        public static int iSpeedAdditive = 5;

        public static double dILS_H_LOC_Max = 0;
        public static double dILS_H_LOC_Min = 0;
        public static double dILS_H_GS_Max = 0;
        public static double dILS_H_GS_Min = 0;

        // Nog nie geimplementeer nie.
        //----------------------------------------
        public static double dJet_Min_power = 0;
        public static double dJet_Stable_power = 0;
        public static double bankMaxAngleLowALT = 3.5;
        // --------------------------------

        public static double bankAngleBelow1000 = 30;
        public static double maksKrunkOnderVersnelHoogte = 30;
        public static double bankAngleBelow200 = 15;
        public static double bankAngleBelow50 = 10;

        public static int iEarlyFlapRetract = 700;
        public static int iMinFlapsUpALT = 800;
        public static int minVersnelHoogte = 400;
        public static int maxKoersVeranderOpstuig = 25;
        public static bool bAnalizeRotationRate = true;

        public static int iMinPowerALT = 1000;

        public static int iCASbuffer = 5;
        public static int iStableALT = 800;
        public static int iLandingNoFlapAlt = 1000;
        public static int iLandingFlapChange = 900;
        public static double landingVertikaleG = 1.85; //1.85
        public static double landingVersnelling = -0.32;
        public static int landingVersnellingTydsverloop = 30;
        public static int landingTruStuKragTydsVerloop = 20;
        
        public static double hoeKruisSpoed = 0.76;
        public static double hoeKruiseDurasie = 600;

        public static int maksTruStuKrag = 80;
        public static int maksTruStuKragSpoed = 45;
        public static string getTime(int n)
        {
            string s = "";
            TimeSpan ts;
            if(csv.timeGMT != "" &&  n < frmMainFOQA.CSV.Rows.Count - 4 && n > 4)
            {
                

                s = frmMainFOQA.CSV.Rows[n][csv.timeGMT].ToString();

                if (s == "")
                {
                    for (int i = 4; i > 0; i--)
                    {
                        DateTime.TryParse(frmMainFOQA.CSV.Rows[n - i][csv.timeGMT].ToString(), out DateTime val);

                        s = frmMainFOQA.CSV.Rows[n - i][csv.timeGMT].ToString();
                        
                        if (TimeSpan.TryParse(val.TimeOfDay.ToString(), out ts) && s != "")
                        {
                            ts += TimeSpan.FromSeconds(i);
                            s = ts.ToString();
                            break;
                        }
                    }
                }
                

            }
            else if (csv.timeHr != "")
            {
                if (frmMainFOQA.CSV.Columns.Contains(csv.timeHr))
                {
                    s = frmMainFOQA.CSV.Rows[n][csv.timeHr].ToString();
                }

                if (frmMainFOQA.CSV.Columns.Contains(csv.timeMin))
                {
                    s += ":" + frmMainFOQA.CSV.Rows[n][csv.timeMin].ToString();
                }

                if (frmMainFOQA.CSV.Columns.Contains(csv.timeSec))
                {
                    s += ":" + frmMainFOQA.CSV.Rows[n][csv.timeSec].ToString();
                }
            }
            else
            {
                s = "0";
            }
            //MessageBox.Show(s, " tyd waarde van s");
            return s;
        }

    }
    public class conversionTools
    {
        public static double convertCtoF(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
        public static double convertFtoC(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public static double convertLToUsg(double litre)
        {
            double result;

            result = litre / 3.78541;

            return result;
        }
        public static double convertUsgToL(double usg)
        {
            double result;

            result = usg * 3.78541;

            return result;
        }
        public static double convertKgToLbs(double kg)
        {
            double result;

            result = kg * 2.201;

            return result;
        }
        public static double convertLbsToKg(double lbs)
        {
            double result;

            result = lbs / 2.201;

            return result;
        }

    }
    public class CSVdata
    {
        public static string sAircraftType = "";
    }
	public class fData
	{

        public class DataAirports
        {
            public static int iAirportID = 0;

            public static double dTouchDownZoneLatitude = 0;
            public static double dTouchDownZoneLongitude = 0;
            public static double dTouchDownoneLength = 0;
            public static double dTouchDownZoneLength = 0;
            public static double dLandingLatitude = 0;
            public static double dLandingLongitude = 0;

            public static void Delete_tAirport(int iAirport)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "delete from tblRunways where fkAirport = " + iAirport;
                cmdEx.ExecuteNonQuery();

                cmdEx.CommandText = "delete from tblAirport where AirportID = " + iAirport;
                cmdEx.ExecuteNonQuery();

                cmdEx.Connection.Close();

            }

            public static void Insert_tAirport(string sICAO, string sIATA, string sAirportName, double dLatitude, double dLongitude, int iVariation, bool bUse)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "insert into tblAirport (ICAOdes, IATA, AirportName, Latitude, Longitude, Variation,  Use)" +
                    "values ('" + sICAO + "', '" + sIATA + "', '" + sAirportName + "', " + dLatitude + ", " + dLongitude + ", " + iVariation + ", " + bUse + ")";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

            public static void Insert_tRunway(string sRunwayDesignator, int iRunwayTrack, int iRunwayElevation, bool bUseRunway, double dLatitude, double dLongitude,
                int iTouchDownMarkersLength)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "insert into tblRunways (fkAirport, RunwayDesignator, RunwayTrack, RunwayElevation, UseRunway,RunwayLatitude, RunwayLongitude, TouchdownMarkersMaxLength)" +
                    "values (" + iAirportID + ", '" + sRunwayDesignator + "', " + iRunwayTrack + ", " + iRunwayElevation + ", " +
                    bUseRunway + ", " + dLatitude + ", " + dLongitude + ", " + iTouchDownMarkersLength + ")";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
            public static DataSet Load_Runways(int iAirportID)
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tblRunways where fkAirport = " + iAirportID;

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tRunways");

                cmdEx.Connection.Close();

                return ds;

            }
            public static void Update_tAirport(int iAirportID, string sICAO, string sIATA,
                string sAirportName, double dLatitude, double dLongitude, int iVariation, bool bUse)
            {

                OleDbCommand cmdEx = new OleDbCommand() 
                {
                    CommandType = CommandType.Text,
                    Connection = new OleDbConnection(DataProc.sCon)
                    
                };

                //cmdEx.CommandType = System.Data.CommandType.Text;

                //cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "Update tblAirport set " +
                    "ICAOdes = '" + sICAO + "', " +
                    "IATA = '" + sIATA + "', " +
                    "AirportName = '" + sAirportName + "', " +
                    "Latitude = " + dLatitude + ", " +
                    "Longitude = " + dLongitude + ", " +
                    "Variation = " + iVariation + ", " +
                    "USE = " + bUse + " " +

                    "where AirportID = " + iAirportID;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
            public static void Update_tRunway(int iRWYID, string sRunwayDesignator, int iRunwayTrack, int iRunwayElevation, bool bUseRunway,
                double dLatitude, double dLongitude, int iTouchDownZoneLength)
            {
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "Update tblRunways set " +
                    "RunwayDesignator = '" + sRunwayDesignator + "', " +
                    "RunwayTrack = " + iRunwayTrack + ", " +
                    "RunwayElevation = " + iRunwayElevation + ", " +
                    "UseRunway = " + bUseRunway + ", " +
                    "RunwayLatitude = " + dLatitude + ", " +
                    "RunwayLongitude = " + dLongitude + ", " +
                    "TouchdownMarkersMaxLength = " + iTouchDownZoneLength + " " +

                    "where RWYID = " + iRWYID;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
            public static string Load_Runway(string sAPT, int iHDG, out string sRunway)
            {


                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tblAirport.ICAOdes, tblAirport.IATA, tblAirport.Variation, tblRunways.RunwayDesignator, " +
                       "tblRunways.RunwayTrack, tblRunways.RunwayElevation, tblRunways.UseRunway, tblRunways.RunwayLatitude, tblRunways.RunwayLongitude, tblRunways.TouchdownMarkersMaxLength, tblAirport.Use " +
                       "FROM tblAirport INNER JOIN tblRunways ON tblAirport.AirportID = tblRunways.fkAirport " +
                       "WHERE(((tblAirport.IATA)='" + sAPT + "') AND " +
                       "((tblAirport.Use)=True) AND " +
                       "((tblRunways.UseRunway)=True));";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAirports");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        int iRWYTRK = Convert.ToInt16(ds.Tables[0].Rows[i]["RunwayTrack"]);
                        if (BearingDistance.angle_between(iHDG, iRWYTRK - 30, iRWYTRK + 30))
                        {
                            return sRunway = (ds.Tables[0].Rows[i]["RunwayDesignator"].ToString()).Substring(0, 2);

                        }
                    }
                }
                else
                {
                    return sRunway = "*";
                }


                return sRunway = "*";

            }

        }

        public class DataProc
        {
            public static string sCon; // = "Pr
                                       // ovider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Documents and Settings\\Iwan Davey\\My Documents\\Visual Studio Projects\\MyTransport\\MyTransport\\tptDat.mde;Persist Security Info=False";

            public static DataSet dsMain = new DataSet();
            public static DataSet dsOther = new DataSet();
            public static DataSet dsCSV = new DataSet();
            public static int iRecount;

            public static DataSet dsTemp = new DataSet();

            public static DataSet Load_Exc(string sType1, string sType2, string sType3, string sType4, string sType5, string sType6,
                string sStartDate, string sEndDate, bool open, bool closed, bool bIncludeDate, string[] scope, bool viewTech)
            {
                Cursor.Current = Cursors.WaitCursor;

                DataSet ds = new DataSet();

                try
                {
                    OleDbCommand cmdEx = new OleDbCommand();

                    cmdEx.CommandType = System.Data.CommandType.Text;

                    //Assign Connection
                    string s = "";
                    string t = "";
                    for (int i = 0; i <= scope.Length - 1; i++)
                    {
                        
                        if (i == 0)
                        {
                            t = "(scope.scope)= '" + scope[i] + "' ";
                        }
                        else
                        {
                            t += " or (scope.scope)= '" + scope[i] + "' ";
                        }
                    }
                    s = "AND (" + t + ") ";

                    if (!viewTech)
                    {
                        s += "AND (tblCause.Cause NOT LIKE 'Tech%' ) ";
                    }
                    
                    cmdEx.Connection = new OleDbConnection(sCon);
                    cmdEx.Connection.Open();

                    if (bIncludeDate)
                    {//SUBSTRING([File].[Name],1,3)
                        cmdEx.CommandText = "SELECT tblExceedance.*, tAircraftType.Type, tblSeverity.Severity, tblCause.Cause, tblFlightPhase.Phase, tblFiles.FileName, MID(tblFiles.FileName,1,6) as FileReg, " +
                            "scope.scope " +
                        "FROM ((((((tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType) INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft)" +
                        "INNER JOIN tblExceedance ON tblFiles.FileID = tblExceedance.fkTblFile)" +
                        "INNER JOIN tblSeverity ON tblSeverity.SeverityID = tblExceedance.fkSeverity)" +
                        "INNER JOIN tblCause ON tblCause.CauseID = tblExceedance.fkCause) " +
                        "INNER JOIN tblFlightPhase ON tblFlightPhase.FlightPhaseID = tblExceedance.fkfFlightPhase) " +
                        "INNER JOIN scope ON scope.ID = tblExceedance.scopeID " +
                            "WHERE (((tAircraftType.Type)= '" + sType1 + "' Or (tAircraftType.Type)= '" + sType2 + "' Or (tAircraftType.Type) = '" +
                            sType3 + "' Or (tAircraftType.Type) = '" + sType4 + "' OR (tAircraftType.Type) = '" + sType5 + "' OR (tAircraftType.Type) = '" + sType6 + "') " +
                            "AND ((tblExceedance.ExcClosed)= " + open + " or (tblExceedance.ExcClosed)= " + closed + ") " +
                            s +
                            "AND ((tblExceedance.DateOfExc) Between #" + sStartDate + "# And #" + sEndDate + "#)) " +
                            "ORDER BY tblExceedance.ExcedanceID DESC;";
                    }
                    else
                    {
                        cmdEx.CommandText = "SELECT tblExceedance.*, tAircraftType.Type, tblSeverity.Severity, tblCause.Cause, tblFlightPhase.Phase, tblFiles.FileName, MID(tblFiles.FileName,1,6) as FileReg " +
                        "FROM (((((tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType) INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft)" +
                        " INNER JOIN tblExceedance ON tblFiles.FileID = tblExceedance.fkTblFile)" +
                        " INNER JOIN tblSeverity ON tblSeverity.SeverityID = tblExceedance.fkSeverity)" +
                        " INNER JOIN tblCause ON tblCause.CauseID = tblExceedance.fkCause) " +
                        " INNER JOIN tblFlightPhase ON tblFlightPhase.FlightPhaseID = tblExceedance.fkfFlightPhase " +
                        "WHERE (((tAircraftType.Type)= '" + sType1 + "' Or (tAircraftType.Type)= '" + sType2 + "' Or (tAircraftType.Type) = '" + sType3 + "' Or (tAircraftType.Type) = '" + sType5 + "') " +
                       // "AND ((tblExceedance.ExcClosed)= " + sOpen + " Or (tblExceedance.ExcClosed)= " + sClosed + ")) " +
                        //"AND ((tblExceedance.DateOfExc) Between #" + sStartDate + "# And #" + sEndDate + "#)) " +
                        "ORDER BY tblExceedance.ExcedanceID DESC;";
                    }

                    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                    da.Fill(ds, "tExceedance");
                    cmdEx.Connection.Close();

                    return ds;
                }
                catch (Exception)
                {

                    return null;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            public static DataSet Load_ACFileHistory()
            {
                DataSet ds = new DataSet();
                try
                {

                    OleDbCommand cmdEx = new OleDbCommand();

                    cmdEx.CommandType = System.Data.CommandType.Text;

                    //Assign Connection

                    cmdEx.Connection = new OleDbConnection(sCon);
                    cmdEx.Connection.Open();
                    cmdEx.CommandText = "SELECT tblAircraft.Registration, tblFiles.Filename, Min(tblLog.LogDate) AS MinOfLogDate, Max(tblLog.LogDate) AS MaxOfLogDate, tblFiles.FileID " +
                        "FROM (tblAircraft INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft) INNER JOIN tblLog ON tblFiles.FileID = tblLog.fkFile " +
                        "GROUP BY tblAircraft.Registration, tblFiles.Filename, tblFiles.FileID " +
                        "HAVING (((Min(tblLog.LogDate)) Between #12/1/2006# And #1/31/2007#)) " +
                        "ORDER BY tblAircraft.Registration, Min(tblLog.LogDate);";


                    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                    da.Fill(ds, "tFile");
                    cmdEx.Connection.Close();

                    return ds;

                }
                catch (Exception)
                {

                    return null;
                }

            }
            public static DataSet Load_Aircraft()
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tblAircraft";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAircraft");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                return ds;

            }
            public static int loadAircraftID(string sAircraftReg)
            {
                int aircraftID = 0;
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT AircraftID, Registration FROM tblAircraft Where (Registration = '" + sAircraftReg + "')";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tAircraft");
                cmdEx.Connection.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return aircraftID = Convert.ToInt32(ds.Tables[0].Rows[0]["AircraftID"]);
                }
                else
                {
                    return aircraftID = 0;
                }

            }
            public static DataSet Load_AircraftType()
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tAircraftType";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAircraftType");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                return ds;

            }
            public static string Load_AircraftType(string sReg)
            {
                string AircraftType = "";
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tAircraftType.Type " +
                "FROM tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType " +
                "WHERE (((tblAircraft.Registration) = '" + sReg + "'))";

                //cmdEx.CommandText = "SELECT tblAircraft.Registration, tAircraftType.Type " +
                //"FROM tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType " +
                // "WHERE(((tblAircraft.Registration)Like 'TGB'));";


                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAircraft");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {

                    AircraftType = ds.Tables[0].Rows[0]["Type"].ToString();
                    return AircraftType;
                }
                else
                {
                    //MessageBox.Show("The aircraft that you are trying to Analyse is not in the data base.", "Load aircraft type.",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    AircraftType = "";
                }

                return AircraftType;

            }
            public static DataSet loadAirports()
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tblAirport";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAirports");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_Attachments(int ifkExceedance)
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tAttachments where fkExceedance = " + ifkExceedance;

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                //dsMain.Tables.Clear();
                da.Fill(ds, "tAttachments");
                // iRecount = dsMain.Tables[0].Rows.Count;
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_Cause()
            {
                DataSet ds = new DataSet();

            OleDbCommand cmdEx = new OleDbCommand()
            {
                CommandType = CommandType.Text,
                Connection = new OleDbConnection(sCon)
            };

        //cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

               // cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "select * from tblCause";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                ds.Tables.Clear();
                da.Fill(ds, "tCause");

                cmdEx.Connection.Close();

                return ds;

            }
            public static void Load_Crew(string sFileame, int iCounter, out string sCaptain, out string sFO)
            {
                sCaptain = sFO = "";

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tblFiles.Filename, tblLog.TOCounter, tblLog.LandCounter, tblLog.Captain, tblLog.FO " +
                    "FROM tblFiles INNER JOIN tblLog ON tblFiles.FileID = tblLog.fkFile " +
                    "WHERE (((tblFiles.Filename)= '" + sFileame + "') AND ((tblLog.TOCounter)< " + (iCounter + 1) + ") AND ((tblLog.LandCounter)>" + (iCounter - 1) + "))";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tCrew");

                cmdEx.Connection.Close();

                if (ds.Tables != null && ds.Tables[0].Rows.Count >= 1)
                {
                    sCaptain = ds.Tables[0].Rows[0]["Captain"].ToString();
                    sFO = ds.Tables[0].Rows[0]["FO"].ToString();
                }
                else
                {
                    sCaptain = "None found";
                    sFO = "None found";
                }


            }
            public static DataSet Load_CSVrelatedRecords(int fkFile)
            {
                DataSet ds = new DataSet();
                try
                {

                    OleDbCommand cmdEx = new OleDbCommand();

                    cmdEx.CommandType = System.Data.CommandType.Text;

                    //Assign Connection

                    cmdEx.Connection = new OleDbConnection(sCon);
                    cmdEx.Connection.Open();
                    cmdEx.CommandText = "SELECT tblExceedance.*, tAircraftType.Type, tblSeverity.Severity, tblCause.Cause, tblFlightPhase.Phase, tblFiles.FileName  " +
                        "FROM (((((tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType) INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft)" +
                        " INNER JOIN tblExceedance ON tblFiles.FileID = tblExceedance.fkTblFile)" +
                        " INNER JOIN tblSeverity ON tblSeverity.SeverityID = tblExceedance.fkSeverity)" +
                        " INNER JOIN tblCause ON tblCause.CauseID = tblExceedance.fkCause) " +
                        " INNER JOIN tblFlightPhase ON tblFlightPhase.FlightPhaseID = tblExceedance.fkfFlightPhase " +
                        "WHERE (tblExceedance.fkTblFile = " + fkFile + " )";

                    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                    da.Fill(ds, "tExceedance");
                    cmdEx.Connection.Close();

                    return ds;

                }
                catch (Exception)
                {

                    return null;
                }

            }
            public static DataTable loadExceedanceById(int ID)
            {

                DataTable dt = new DataTable();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select tblExceedance.*, tblFiles.FileName, MID(tblFiles.FileName,1,3) as FileReg  " +
                    "FROM tblExceedance INNER JOIN " +
                    "tblFiles ON tblExceedance.fktblFile = tblFiles.FileId " +
                    "where ExcedanceId = " + ID;

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(dt);

                cmdEx.Connection.Close();

                return dt;

            }
            public static DataSet Load_FindAirportAndRunway(double dTODHG, int iElevation, double dLatitude, double dLongitude)
            {
                double dVariance = 0.025;
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);

                cmdEx.CommandText = "SELECT tblAirport.ICAOdes, tblAirport.IATA, tblAirport.Variation, tblRunways.RunwayDesignator, " +
                   "tblRunways.RunwayTrack, tblRunways.RunwayElevation, tblRunways.UseRunway, tblRunways.RunwayLatitude, tblRunways.RunwayLongitude, tblRunways.TouchdownMarkersMaxLength, tblAirport.Use " +
                   "FROM tblAirport INNER JOIN tblRunways ON tblAirport.AirportID = tblRunways.fkAirport " +
                   "WHERE(((tblRunways.RunwayLatitude) Between " + (dLatitude - dVariance) + " And " + (dLatitude + dVariance) + ") AND " +
                   "((tblRunways.RunwayLongitude) Between " + (dLongitude - dVariance) + " And " + (dLongitude + dVariance) + ") AND " +
                   "((tblAirport.Use)=True) AND " +

                   "((tblRunways.UseRunway)=True));";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tAirports");
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_FindAirport(double dTODHG, int iElevation, double dLatitude, double dLongitude)
            {
                double dVariance = 0.3;
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand
                {
                    CommandType = CommandType.Text,
                    Connection = new OleDbConnection(sCon),
                    CommandText = "SELECT tblAirport.ICAOdes, tblAirport.IATA, tblAirport.Variation, tblAirport.Use " +
                   "FROM tblAirport " +
                   "WHERE(((tblAirport.Latitude) Between " + (dLatitude - dVariance) + " And " + (dLatitude + dVariance) + ") AND " +
                   "((tblAirport.Longitude) Between " + (dLongitude - dVariance) + " And " + (dLongitude + dVariance) + ") AND " +
                   "((tblAirport.Use)=True));"
                };

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tAirports");
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_FindAirportsNoLatitude(double dTODHG, int iElevation)
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tblAirport.ICAOdes, tblAirport.IATA, tblRunways.RunwayDesignator, " +
                    "tblRunways.RunwayTrack, tblRunways.RunwayElevation, tblRunways.UseRunway, tblAirport.Use " +
                    "FROM tblAirport INNER JOIN tblRunways ON tblAirport.AirportID = tblRunways.fkAirport " +
                    "WHERE (((tblRunways.RunwayTrack) Between " + (dTODHG - 8) + " And " + (dTODHG + 8) + ") AND " +
                    "((tblRunways.RunwayElevation) Between " + (iElevation - 500) + " And " + (iElevation + 500) + ") AND " +
                    "((tblRunways.UseRunway)=True) AND ((tblAirport.Use)=True))";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tAirports");
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_Flights(string startDate, string endDate)
            {
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tAircraftType.Type, tblExceedance.Exceedance, Count(tblExceedance.Exceedance) AS iCount " +
                    "FROM ((tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType) INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft) INNER JOIN tblExceedance ON tblFiles.FileID = tblExceedance.fkTblFile " +
                    "WHERE (((tblExceedance.DateOfExc) Between #" + startDate + "# And #" + endDate + "#)) " + // die is verander. "WHERE (((tblExceedance.DateOfExc) Between #" + sDateStart + "# And #" + sDateEnd + "#))
                    "GROUP BY tAircraftType.Type, tblExceedance.Exceedance " +
                    "ORDER BY tAircraftType.Type, Count(tblExceedance.Exceedance) DESC; ";


                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tGen");
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_TopEight(string sDateStart, string sDateEnd)
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tAircraftType.Type, tblExceedance.Exceedance, Count(tblExceedance.Exceedance) AS iCount " +
                    "FROM ((tAircraftType INNER JOIN tblAircraft ON tAircraftType.AircraftTypeID = tblAircraft.fType) INNER JOIN tblFiles ON tblAircraft.AircraftID = tblFiles.fkAircraft) INNER JOIN tblExceedance ON tblFiles.FileID = tblExceedance.fkTblFile " +
                    "WHERE (((tblExceedance.DateOfExc) Between #" + sDateStart + "# And #" + sDateEnd + "#)) " +
                    "GROUP BY tAircraftType.Type, tblExceedance.Exceedance " +
                    "ORDER BY tAircraftType.Type, Count(tblExceedance.Exceedance) DESC; ";


                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tGen");
                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_FlightPhase()
            {
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT * FROM tblFlightPhase order by Phase DESC";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                ds.Tables.Clear();
                da.Fill(ds, "tFlightPhase");

                cmdEx.Connection.Close();

                return ds;

            }
            public static DataSet Load_FlapSpeeds()
            {
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tAircraftType.Type, tFlap.FlapPos, tFlap.FlapSpeedLimmit " +
                    "FROM tAircraftType INNER JOIN tFlap ON tAircraftType.AircraftTypeID = tFlap.fkAircraftType " +
                    "WHERE ((tAircraftType.Type) = '" + csv.Type + "')";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                ds.Tables.Clear();
                da.Fill(ds, "tFlapSpeeds");

                cmdEx.Connection.Close();

                return ds;

            }
            public static string loadFileName(int FileID)
            {
                string sql = "Select Filename FROM tblFiles Where FileID = " + FileID;
                string fileName = "";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = new OleDbConnection(sCon);
                try
                {
                    cmd.CommandText = sql;

                    cmd.Connection.Open();
                    OleDbDataReader dbR = cmd.ExecuteReader();

                    fileName = dbR.GetValue(0).ToString();

                    return fileName;
                }
                catch
                {
                    return fileName = "error";
                }
                finally
                {
                    cmd.Connection.Close();
                }


            }
            public static int loadFileID(string FileName)
            {
                int FileID = 0;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = new OleDbConnection(sCon);

                try
                {
                    OleDbDataReader Filedr;
                    cmd.CommandText = "SELECT FileID FROM tblFiles WHERE Filename = " + "'" + FileName + "'" + "";

                    cmd.Connection.Open();
                    Filedr = cmd.ExecuteReader(CommandBehavior.Default);

                    while (Filedr.Read())
                    {
                        FileID = Filedr.GetInt32(0);
                    }

                    return FileID;

                }
                catch (Exception)
                {
                    return FileID;
                }
                finally
                {
                    cmd.Connection.Close();
                }

            }
            public static DataSet Load_Severity()
            {
                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "select * from tblSeverity";


                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                ds.Tables.Clear();
                da.Fill(ds, "tSeverity");

                cmdEx.Connection.Close();

                return ds;

            }
            public static DataTable loadScope()
            {
                
                DataTable dt = new DataTable();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "select * from Scope";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);
                
                da.Fill(dt);

                cmdEx.Connection.Close();

                return dt;

            }
            public static DataSet Load_FlightFromFlightTracker(int ifkFile, double dCounter)
            {
                DataSet ds = new DataSet();
                try
                {

                    OleDbCommand cmdEx = new OleDbCommand();

                    cmdEx.CommandType = System.Data.CommandType.Text;

                    //Assign Connection

                    cmdEx.Connection = new OleDbConnection(sCon);
                    cmdEx.Connection.Open();
                    cmdEx.CommandText = "SELECT LogDate, LogFlightNo, TakeOff, TORWY, Land, LandRWY  " +
                        "FROM tblLog WHERE ((TOCounter < " + (dCounter + 5) + ") AND (LandCounter > "
                        + (dCounter - 5) + ") AND (fkFile = " + ifkFile + "))";
                    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                    da.Fill(ds, "tExceedance");
                    cmdEx.Connection.Close();

                    return ds;

                }
                catch (Exception)
                {

                    return null;
                }

            }
            //public static DataSet Load_Vref(string sAircraftType, double dWeightTons, int iFlap)
            //{
            //    DataSet ds = new DataSet();
            //    OleDbCommand cmdEx = new OleDbCommand();

            //    cmdEx.CommandType = System.Data.CommandType.Text;

            //    //Assign Connection

            //    cmdEx.Connection = new OleDbConnection(sCon);
            //    cmdEx.Connection.Open();
            //    cmdEx.CommandText = "SELECT tVref.AircraftType, tVref.Weight, tVref.Flap, tVref.Speed " +
            //        "FROM tVref " +
            //        "WHERE (((tVref.AircraftType)= '" + sAircraftType + "') AND " +
            //        "((tVref.Weight) Between " + (dWeightTons - 5) + " And " + (dWeightTons + 5) + ") AND " +
            //        "((tVref.Flap) Between " + (iFlap - 3) + " AND " + (iFlap + 3) + ")) " +
            //        "ORDER BY tVref.Weight ASC";

            //    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

            //    ds.Tables.Clear();
            //    da.Fill(ds, "tVref");

            //    cmdEx.Connection.Close();

            //    return ds;

            //}
            public static void loadApRyByCounterLerNaam(string lerNaam, int counter, out string opstygLh, out string opstygRy, out int opstygKoers, out string landLh,  out string landRy, out int landKoers)
            {
                opstygLh = "";
                opstygRy = "";
                landLh = "";
                landRy = "";
                opstygKoers = 0;
                landKoers = 0;

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "SELECT tblFiles.Filename, tblLog.TOCounter, tblLog.LandCounter, tblLog.[TakeOff], tblLog.[TORWY], tblLog.[TOHDG], tblLog.[Land], tblLog.[LandHDG], tblLog.[LandRWY] " +
                       "FROM tblFiles INNER JOIN tblLog ON tblFiles.FileID = tblLog.fkFile " +
                       "WHERE (((tblFiles.Filename)='" + lerNaam + "') AND ((tblLog.TOCounter) < " + counter + " ) AND ((tblLog.LandCounter)>" + counter + "))";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "logEntry");

                cmdEx.Connection.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    opstygLh = ds.Tables[0].Rows[0]["TakeOff"].ToString();
                    opstygRy = ds.Tables[0].Rows[0]["TORWY"].ToString();
                    int.TryParse(ds.Tables[0].Rows[0]["TOHDG"].ToString(), out opstygKoers);
                    landLh = ds.Tables[0].Rows[0]["Land"].ToString();
                    landRy = ds.Tables[0].Rows[0]["LandRWY"].ToString();
                    int.TryParse(ds.Tables[0].Rows[0]["LandHDG"].ToString(), out landKoers);
                }
                else
                {
                    opstygLh = "";
                    opstygRy = "";
                    landLh = "";
                    landRy = "";
                    opstygKoers = 0;
                    landKoers = 0;
                }


            }
            public static void Update_tExc(int ifkFile, int ifkAirport, int ifkRunway, int ifkFlightPhase, int ifkCause, int scopeID, string sExceedance,
                double dCounter, DateTime dtDateOfExc, string eventTime,
                int ifkSeverity, string sFlightNo, int iExceedanceID, Boolean bClosed, string sExcNote)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "Update tblExceedance set " +
                    "fkTblFile = " + ifkFile + ", " +
                    "fkAirport = " + ifkAirport + ", " +
                    "fkRunway = " + ifkRunway + ", " +
                    "fkfFlightPhase = " + ifkFlightPhase + ", " +
                    "fkSeverity = " + ifkSeverity + ", " +
                    "fkCause = " + ifkCause + ", " +
                    "scopeID = " + scopeID + ", " +
                    "FlighNo = '" + sFlightNo + "', " +
                    "Exceedance = '" + sExceedance + "', " +
                    "fCounter = " + dCounter + ", " +
                    "DateOfExc = '" + dtDateOfExc.ToString("dd-MMM-yyyy") + "', " +
                    "TimeOfExc = '" + eventTime + "', " +
                    "ExcNote = '" + sExcNote + "', " +
                    "ExcClosed = " + bClosed + " " +
                    "where ExcedanceID = " + iExceedanceID;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();



            }
            public static void Update_DateANDflightNo(int iexcID, DateTime dtDate, string sFlightNo)
            {
                OleDbCommand cmdEx = new OleDbCommand();
                cmdEx.CommandType = CommandType.Text;
                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "Update tblExceedance set " +
                    "DateOfExc = '" + dtDate + "', " +
                    "FlighNo = '" + sFlightNo + "' " +
                    "where ExcedanceID = " + iexcID;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
            public static void Insert_tAircraft(string sRegistration, string sAircraftType, int ifType)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "insert into tblAircraft (Registration, Type, fType)" +
                    "values ('" + sRegistration + "', '" + sAircraftType + "', " + ifType + ")";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
            public static void Insert_tAttachments(int ifkExceedance, string sFilePath, string sFileName)
            {
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "insert into tAttachments (fkExceedance, FilePath, FileName)" +
                    "values (" + ifkExceedance + ", '" + sFilePath + "', '" + sFileName + "')";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();
            }
            public static void Insert_tExc(int ifkFile, int AirportId, int ifkFlightPhase, int SeverityId, int ifkCause, int scope, string sFlightNo,
                string sExceedance, double dCounter, DateTime dtExcDate, string eventTime, Boolean bExcClosed, string sExcNote)
            {

                try
                {
                    OleDbCommand cmdEx = new OleDbCommand();

                    cmdEx.CommandType = System.Data.CommandType.Text;

                    cmdEx.Connection = new OleDbConnection(sCon);
                    cmdEx.Connection.Open();

                    #region Kyk of die event reeds geskryf is.

                    cmdEx.CommandText = "SELECT FlighNo FROM tblExceedance WHERE (FlighNo = '"+ sFlightNo  +"' AND DateOfExc = #" +
                        dtExcDate.Date + "# AND Exceedance = '" + sExceedance + "')";

                    OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "Log");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cmdEx.Connection.Close();
                        ds = null;
                        return;
                    }

                    #endregion

                    cmdEx.CommandText = "insert into tblExceedance (fkTblFile, fkAirport, fkfFlightPhase, fkSeverity, fkCause, scopeID, FlighNo," +
                        " Exceedance, Fcounter, DateOfExc, TimeOfExc, ExcClosed, ExcNote)" +
                        "values (" + ifkFile + ", " + AirportId + ", " + ifkFlightPhase + ", " + SeverityId + ", " + ifkCause + ", " + scope + ", '" +
                        sFlightNo + "', '" + sExceedance + "', " + dCounter + ", '" + dtExcDate.ToString("yyyy-MMM-dd") + "', '" +
                        eventTime + "', " + bExcClosed + ", '" + sExcNote + "')";

                    cmdEx.ExecuteNonQuery();
                    cmdEx.Connection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString(), "Error inserting a record into Exceedance.");
                }

            }
            public static void Insert_tFiles(string sFileName, DateTime dtDateRead, int ifkAircraft)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "insert into tblFiles (Filename, DateRead, fkAircraft)" +
                    "values ('" + sFileName + "', # " + dtDateRead.ToString("yyyy-MM-dd") + " #, " + ifkAircraft + ")";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

            public static void Insert_tFlightLog(int ifkFile, string sLogFlightNo, DateTime dtLogDate, string toTime, string sTO, string sTRWY,
                int iTOAlt, double dTOHDG, int iTOCounter, string landTime, string sLandAP, string sLRWY, double dLandHDG, int iLandALT, int iLandCounter, double avarageCruiseMach)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                
                cmdEx.Connection.Open();

                DateTime.TryParse(toTime, out DateTime toT);
                DateTime.TryParse(landTime, out DateTime ldT);

                #region nuwe kode
                cmdEx.CommandText = "SELECT LogFlightNo, LogDate, ToTime FROM tblLog WHERE (LogFlightNo = '" + sLogFlightNo + "' AND LogDate = #" + dtLogDate.Date.ToString("MM/dd/yyyy") + "# AND " +
                    " TOTime = '" + toT.TimeOfDay.ToString() + "')";

                

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);
                DataSet ds = new DataSet();



                da.Fill(ds, "Log");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //MessageBox.Show("The log entry have been made. ", "Writing to log");
                    cmdEx.Connection.Close();
                    ds = null;
                    return;
                }


                #endregion

                

                cmdEx.CommandText = "insert into tblLog (fkFile, LogFlightNo, LogDate, ToTime, TakeOff, TORWY, TOALT, TOHDG, TOCounter, LandTime, Land, LandRWY, LandHDG, LandALT, LandCounter, averageCruiseSpeed)" +
                   "values (" + ifkFile + ", '" +
                   sLogFlightNo + "', #" +
                   dtLogDate.ToString("dd-MMM-yyyy") + "#, '" +
                   toT.TimeOfDay.ToString() + "', '" +
                   sTO + "', '" + sTRWY + "', " + iTOAlt + ", " + dTOHDG + ", " + iTOCounter + ", '" +
                   ldT.TimeOfDay.ToString() + "', '" + sLandAP + "', '" + sLRWY + "', " + dLandHDG + ", " + iLandALT + ", " + iLandCounter + ", " + avarageCruiseMach + ")";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();
                cmdEx.Dispose();

            }

            public static void Delete_tAircraft(int iAircraft)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "delete from tblAircraft where AircraftID = " + iAircraft;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

            public static void Delete_tAttachment(int iAttachmentID)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "delete from tAttachments where AttachmentID = " + iAttachmentID;

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

            public static void Delete_tExc(int iExceedanceID)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "delete from tblExceedance where ExcedanceID = " + iExceedanceID;


                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

            public static void Delete_File_AllRef(int iFileID)
            {


                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;
                cmdEx.Connection = new OleDbConnection(sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "delete from tblExceedance where fkTblFile = " + iFileID;
                cmdEx.ExecuteNonQuery();
                cmdEx.CommandText = "delete from tblLog where fkFile = " + iFileID;
                cmdEx.ExecuteNonQuery();
                cmdEx.CommandText = "delete from tblFiles where FileID = " + iFileID;
                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }
        }

        public class DataSettings
        {
            public static DataSet Load_CSV_path()
            {

                DataSet ds = new DataSet();
                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = CommandType.Text;

                //Assign Connection

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();
                cmdEx.CommandText = "Select * from tSettings";

                OleDbDataAdapter da = new OleDbDataAdapter(cmdEx);

                da.Fill(ds, "tSettings");
                cmdEx.Connection.Close();

                return ds;

            }
            public static void Update_Path(string sCSVPath)
            {

                OleDbCommand cmdEx = new OleDbCommand();

                cmdEx.CommandType = System.Data.CommandType.Text;

                cmdEx.Connection = new OleDbConnection(DataProc.sCon);
                cmdEx.Connection.Open();

                cmdEx.CommandText = "Update tSettings set " +
                    "DefaultCSVdir = '" + sCSVPath + "' " +
                    "where SettingsID = 1";

                cmdEx.ExecuteNonQuery();
                cmdEx.Connection.Close();

            }

        }

        public static string ReplaceChar(string sToFixx)
        {
            string s;
            s = sToFixx.Replace("'", "''");
            return s;
        }

    }
    public class BearingDistance
    {
        public static double DegreeToRadian(double angle) { return Math.PI * angle / 180.0; }
        public static double RadianToDegree(double angle) { return 180.0 * angle / Math.PI; }

        public static void bd(double dStartLatitude, double dStartLongitude, double dEndLatitude, double dEndLongitude, out double dDistance, out double dTrueBearing)
        {
            double dsLat = dStartLatitude;
            double deLat = dEndLatitude;
            double dsLong = dStartLongitude;
            double deLong = dEndLongitude;

            double dRslat = DegreeToRadian(dsLat);
            double dRelat = DegreeToRadian(deLat);


          //  double R = (dType == DistanceType.Miles) ? EarthRadiusInMiles : EarthRadiusInKilometers;
            double R = 3434.82;

            double dRcheLat = DegreeToRadian(deLat) - DegreeToRadian(dsLat);
            double dRcheLong = DegreeToRadian(deLong) - DegreeToRadian(dsLong);

            double a = Math.Sin(dRcheLat / 2) * Math.Sin(dRcheLat / 2) + Math.Cos(DegreeToRadian(dsLat)) * Math.Cos(DegreeToRadian(deLat)) * Math.Sin(dRcheLong / 2) * Math.Sin(dRcheLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = c * R;

            dDistance = Math.Round(distance, 4);
            dDistance = (dDistance * 6080) / 3280; // Get the meter distance

            double y = Math.Sin(dRcheLong) * Math.Cos(dRelat);
            double x = Math.Cos(dRslat) * Math.Sin(dRelat) - Math.Sin(dRslat) * Math.Cos(dRelat) * Math.Cos(dRcheLong);
            double brng = Math.Atan2(y, x);


            dTrueBearing = ((RadianToDegree(brng) + 360) % 360);
        }

        public static bool angle_between(int iHeading, int iMax, int iMin)
        {
            iHeading = (360 + (iHeading % 360)) % 360;
            iMax = (3600000 + iMax) % 360;
            iMin = (3600000 + iMin) % 360;

            if (iMax < iMin)
                return iMax <= iHeading && iHeading <= iMin;
            return iMax <= iHeading || iHeading <= iMin;

        }


    }
    public class Controls
    {
        public static bool bShowLatitudeLongitude = false;
        public static string sGoogleview;
        
    }
    public class KLM
    {
        public static void CreateKLM(DataTable dt, int Begin, int End, int EventCounter, string path, string FileName)
        {
            Cursor.Current = Cursors.WaitCursor;

            string directoryName = "";

            string sName = "";
          //  string sDescription = "";

            int CSVRecordcount = 0;


            double Distance = 0;
            double Bearing = 0;

            int Records = End - Begin;

            if (End <= Begin || Records < 10)
            {
                MessageBox.Show("You have not selected a big enough sample, or end point is smaller that start point.", "FDA KLM creator.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //double[,] LatLongALT = new double[End - Begin, 3];
            double[,] LatLongALT = new double[50000, 3];

            //BeginCounter = Convert.ToInt32(textBox1.Text);
            //EndCounter = Convert.ToInt32(textBox2.Text);

            //if (double.TryParse(lCounter.Text, out EventCounter))
            //{
            //    // MessageBox.Show(EventCounter.ToString() + " die counter wat geretrive is", "Dev");

            //}
            //else
            //{
            //    BeginingCounterOfset = 500;
            //    EndCounterOfset = 500;
            //    EventCounter = 3910;
            //    MessageBox.Show("Counter could not be set to a value corresponding to a event. The counter would be set to " + EventCounter.ToString(), "KML creat.");

            //    //return;
            //}

            // Check wether the CSV has data.

            //if (dt != null && ds.Tables.Count > 0)
            if (dt != null)
            {
                CSVRecordcount = dt.Rows.Count;

            }
            else
            {
                MessageBox.Show("There are no open CSV", "KLM Creator");
                return;
            }

            directoryName = Path.GetDirectoryName(path);

            sName = csv.csvFileName;
            //sDescription = "Iwan Voorbeeld";
            

            if (FileName.Length > 4)
            {
                string sub = FileName.Substring(FileName.Length - 4, 4);
                if (sub == ".kml")
                {
                    
                }
                else
                {
                    FileName += ".kml";
                }
            }
            else
            {
                FileName += ".kml";
            }

            StreamWriter writer = File.CreateText(FileName);
            writer.WriteLine("<?xml version='1.0' encoding='UTF-8'?>");
            writer.WriteLine("<kml xmlns='http://www.opengis.net/kml/2.2'>");
            writer.WriteLine("<Document>");

            int i = 0;
            //int y = 1;


            for (int k = 0; k < CSVRecordcount - 2; k++)
            {
                double one = 0;
                double.TryParse(dt.Rows[k][FlightParameters.rowCounter].ToString(), out one);
                //MessageBox.Show(one.ToString(), "oe");
                if (one > Begin && one < End)
                {

                    if (i != 0)// nie seker hoekom die hier uitgewerk word nie. 20220313
                    {
                        BearingDistance.bd(LatLongALT[i - 1, 1], LatLongALT[i - 1, 0], Convert.ToDouble(dt.Rows[k][csv.latitude]), Convert.ToDouble(dt.Rows[k][FlightParameters.longitude]), out Distance, out Bearing);
                    }

                    if (i == 0)
                    {
                        LatLongALT[i, 0] = Convert.ToDouble(dt.Rows[k][FlightParameters.longitude]);
                        LatLongALT[i, 1] = Convert.ToDouble(dt.Rows[k][FlightParameters.latitude]);
                        LatLongALT[i, 2] = (((Convert.ToInt16(dt.Rows[k][FlightParameters.altitudePressure])) / 3.28) + 400);

                        i++;

                    }
                    else if (Distance < 1.5 && i > 0)
                    {
                        LatLongALT[i, 0] = Convert.ToDouble(dt.Rows[k][FlightParameters.longitude]);
                        LatLongALT[i, 1] = Convert.ToDouble(dt.Rows[k][FlightParameters.latitude]);
                        LatLongALT[i, 2] = (((Convert.ToInt32(dt.Rows[k][FlightParameters.altitudePressure])) / 3.28) + 100);

                        i++;

                    }

                }

            }//end getting the coordinates

            //  MessageBox.Show(i.ToString(), "Lat points ploted");

            //  writer.WriteLine(dLongitude.ToString() + "," + dLatitude.ToString() + "," + dAltitude.ToString());

            writer.WriteLine("<Placemark>");
            writer.WriteLine("<Style><LineStyle>");
            writer.WriteLine("<color>ffff00ff</color>");
            writer.WriteLine(" <width>2</width>");
            writer.WriteLine("</LineStyle></Style>");
            writer.WriteLine("<name>Track</name>");
            writer.WriteLine("<LineString>");
            writer.WriteLine("<extrude>1</extrude>");
            writer.WriteLine("<tessellate>1</tessellate>");
            writer.WriteLine("<altitudeMode>absolute</altitudeMode>");
            writer.WriteLine("<coordinates>");

            for (int x = 0; x < LatLongALT.GetLength(0); x++)
            {
                if (LatLongALT[x, 0] != 0)
                {
                    writer.WriteLine(LatLongALT[x, 0].ToString() + "," + LatLongALT[x, 1].ToString() + "," + LatLongALT[x, 2].ToString());
                }

            }

            writer.WriteLine("</coordinates>");
            writer.WriteLine("</LineString>");
            writer.WriteLine("</Placemark>");

            for (int k = 0; k < CSVRecordcount - 2; k++)
            {

                double.TryParse(dt.Rows[k][FlightParameters.rowCounter].ToString(), out double one);
                //double one = Convert.ToDouble(dt.Rows[k][csv.counter]);

                if (one > Begin && one < End)
                {
                    // Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down
                    if (csv.airGnd != "")
                    {
                        if (((Convert.ToDouble(dt.Rows[k][FlightParameters.airGround])) == 1) && (Convert.ToDouble(dt.Rows[k + 1][FlightParameters.airGround]) == 0))
                        {
                            writer.WriteLine("<Placemark>");
                            writer.WriteLine("<name> Touch down </name>");

                            writer.WriteLine("<Point>");
                            writer.WriteLine("<coordinates>");

                            writer.WriteLine((dt.Rows[k][FlightParameters.longitude]).ToString() + ", " +
                                (dt.Rows[k][FlightParameters.latitude]).ToString() + ", 0");

                            writer.WriteLine("</coordinates>");
                            writer.WriteLine("</Point>");
                            writer.WriteLine("</Placemark>");
                        }
                    }
                    // END Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down Touch Down END
                    #region test
                    //if (csv.gearLeftUp != "")
                    //{
                    //    if (((Convert.ToDouble(dt.Rows[k][csv.gearLeftUp])) == 1) && (Convert.ToDouble(dt.Rows[k + 1][csv.gearLeftUp]) == 0))
                    //    {
                    //        writer.WriteLine("<Placemark>");
                    //        writer.WriteLine("<name> Gear Down </name>");
                    //        writer.WriteLine("<description> CAS at gear down " + dt.Rows[k][csv.speedCAS].ToString() + " kts</description>");
                    //        writer.WriteLine("<Point>");
                    //        writer.WriteLine("<altitudeMode>absolute</altitudeMode>");
                    //        writer.WriteLine("<coordinates>");

                    //        //writer.WriteLine((dt.Rows[k][csv.longitude]).ToString() + ", " +
                    //        //    (dt.Rows[k][csv.latitude]).ToString() + ", 0");

                    //        writer.WriteLine((dt.Rows[k][csv.longitude]).ToString() +
                    //            ", " + (dt.Rows[k][csv.latitude]).ToString() +
                    //            ", " + (((Convert.ToInt16(dt.Rows[k][csv.altitudeP])) / 3.28) + 50).ToString());

                    //        writer.WriteLine("</coordinates>");
                    //        writer.WriteLine("</Point>");
                    //        writer.WriteLine("</Placemark>");
                    //    }

                    //    if (((Convert.ToDouble(dt.Rows[k][csv.gearLeftUp])) == 0) && (Convert.ToDouble(dt.Rows[k + 1][csv.gearLeftUp]) == 1))
                    //    {
                    //        writer.WriteLine("<Placemark>");
                    //        writer.WriteLine("<name> Gear Up </name>");
                    //        writer.WriteLine("<Point>");
                    //        writer.WriteLine("<coordinates>");

                    //        writer.WriteLine((dt.Rows[k][csv.longitude]).ToString() +
                    //            ", " + (dt.Rows[k][csv.latitude]).ToString() +
                    //            ", " + (((Convert.ToInt16(dt.Rows[k][csv.altitudeP])) / 3.28) + 50).ToString());

                    //        writer.WriteLine("</coordinates>");
                    //        writer.WriteLine("</Point>");
                    //        writer.WriteLine("</Placemark>");
                    //    }
                    //}

                    #endregion
                    i++;

                } // end if exceedance range.
            }

            writer.WriteLine("</Document>");
            writer.WriteLine("</kml>");
            
            writer.Close();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Exceedance file.", "FOQA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
    public class Tools
    {
        public static double StartCounter = 0;
        public static double EndCounter = 0;
        public static double Distance = 0;
        public static double FU = 0;
        public static double touchDownAltitude = 0;
        public static double liftOffAltitude = 0;

        public static void CalculateDistance(DataTable dt)
        {
            double DistanceTraveledInMPS = 0;
            double TotalDistance = 0;
            double GroundSpeed = 0;
            Distance = 0;
            FU = 0;

            for (int i = 0;
                (i < dt.Rows.Count);
                i++)
            {
                if ((Convert.ToDouble(dt.Rows[i][csv.counter]) > StartCounter) && (Convert.ToDouble(dt.Rows[i][csv.counter]) <= EndCounter))
                {
                    GroundSpeed = Convert.ToDouble(dt.Rows[i][csv.speedGround]);
                    //FU += ((Convert.ToDouble(dt.Rows[i][csv.eng1FuelFlow])) + (Convert.ToDouble(dt.Rows[i][csv.eng2FuelFlow]))) / 3600;
                    DistanceTraveledInMPS = (((GroundSpeed * 6076.12) / 3280) / 3600);
                    TotalDistance += DistanceTraveledInMPS;
                }

            }
            // double SGW = Convert.ToDouble(dt.Rows[Convert.ToInt32(StartCounter)][csv.grossWeight]);
            // double EGW = Convert.ToDouble(dt.Rows[Convert.ToInt32(EndCounter)][csv.grossWeight]);
            // FU = SGW - EGW;

            Distance = TotalDistance;
            dt.Dispose();
        }


        public static void CalculateFuelBurnedBetweenPoints(DataTable dt, out double FuelBurned, out double FuelBurnedGW)
        {
            FU = 0;
            Int32 SGW = 0;
            Int32 EGW = 0;

            for (int i = 0;
                (i < dt.Rows.Count);
                i++)
            {
                if ((Convert.ToDouble(dt.Rows[i][csv.counter]) > StartCounter) && (Convert.ToDouble(dt.Rows[i][csv.counter]) <= EndCounter))
                {
                    if (csv.eng2FuelFlow == "")
                    {
                        FU += ((Convert.ToDouble(dt.Rows[i][csv.eng1FuelFlow]))) / 3600;
                    }
                    else
                    {
                        FU += ((Convert.ToDouble(dt.Rows[i][csv.eng1FuelFlow])) + (Convert.ToDouble(dt.Rows[i][csv.eng2FuelFlow]))) / 3600;
                    }
                    

                }

                if (csv.grossWeight != "")
                {
                    if (Convert.ToDouble(dt.Rows[i][csv.counter]) == StartCounter)
                    {
                        SGW = Convert.ToInt32(dt.Rows[i][csv.grossWeight]);

                    }

                    if (Convert.ToDouble(dt.Rows[i][csv.counter]) == EndCounter)
                    {
                        EGW = Convert.ToInt32(dt.Rows[i][csv.grossWeight]);
                    }
                }

            }



            FuelBurnedGW = SGW - EGW;
            FuelBurned = FU;

            dt.Dispose();
        }

        //public static void Calculate(DataSet ds)
        //{

        //    //public double 
        //    for (int i = 0; i < dsn.Tables[0].Rows.Count; i++)
        //    {
        //        if ((Convert.ToInt16(dt.Rows[i][csv.airGnd]) == 0 && Convert.ToInt16(dt.Rows[i + 1][csv.airGnd]) == 1))

        //        {// Get all the takeoff data.
        //    //        dTOCounter = Convert.ToDouble(CSV.Rows[n][csv.counter]);
        //            iTOalt = Convert.ToInt32(CSV.Rows[n][csv.altitudeP]);
        //            dTOFlap = Convert.ToDouble(CSV.Rows[n][csv.flapTE]);
        ////            dTOHDG = Convert.ToDouble(CSV.Rows[n][csv.heading]);
        //  //          dTOPitch = Convert.ToDouble(CSV.Rows[n][csv.attitudePitch]);
        //    //        dVTakeOff = Convert.ToDouble(CSV.Rows[n][csv.speedCAS]);
        //      //      dpTOTime = Convert.ToDouble(CSV.Rows[n][csv.timeGMT]);


        //        }


        //            }//End of Takeoff data IF.

        //    for (int i = 0;
        //        (i < dt.Rows.Count);
        //        i++)
        //    {

        //            GroundSpeed = Convert.ToDouble(dt.Rows[i][csv.speedGround]);
        //            FU += ((Convert.ToDouble(dt.Rows[i][csv.eng1FuelFlow])) + (Convert.ToDouble(dt.Rows[i][csv.eng2FuelFlow]))) / 3600;
        //            DistanceTraveledInMPS = (((GroundSpeed * 6076.12) / 3280) / 3600);
        //            TotalDistance += DistanceTraveledInMPS;


        //    }
        //}


    }

    


}