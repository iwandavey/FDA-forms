using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FDAClassLibrary;
using FOQA.ApplicationClasses;
namespace FOQA.ApplicationClasses
{
    public class PlotList
    {
        public string initialPlotstring { get; set; }

        public static List<PlotParameters> Parameters = new List<PlotParameters>();

      // public void setParametersForPlot(float bottomVal)
        //{
        //    if (PlotList.Parameters.Count > 0)
        //    {
        //        return;
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationLongitudinalMax))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.accelerationLongitudinalMax,
        //            kleur = Color.DarkBlue,
        //            knopieNaam = "Acceleration Longitudenal max",
        //            knopieNaamKort = "Aclx",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }


        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationLongitudinalMin))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.accelerationLongitudinalMin,
        //            kleur = Color.Red,
        //            knopieNaam = "Acceleration Longitudenal min",
        //            knopieNaamKort = "Aclm",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }
        //    if (FlightParameters.accelerationVerticalMin != null)
        //    {
        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationVerticalMin))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.accelerationVerticalMin,
        //                kleur = Color.Red,
        //                knopieNaam = "Acceleration vertical min",
        //                knopieNaamKort = "Acvm",
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 23,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = false,
        //                faktor = 1,
        //                vinnigeKnopie = true
        //            });
        //        }
        //    }


        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationVerticalMax))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.accelerationVerticalMax,
        //            kleur = Color.Lime,
        //            knopieNaam = "Acceleration vertical max",
        //            knopieNaamKort = "AcvX",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.airGround))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.airGround,
        //            kleur = Color.Brown,
        //            knopieNaam = "airGround",
        //            knopieNaamKort = "AG",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }


        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.attitudeRollLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.attitudeRollLeft,
        //            kleur = Color.Brown,
        //            knopieNaam = "Attitude Roll",
        //            knopieNaamKort = "ARl",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 10,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    PlotList.Parameters.Add(new PlotParameters
        //    {
        //        waardeOmTePlot = FlightParameters.altitudePressure,
        //        kleur = Color.Blue,
        //        knopieNaam = "Altitude Pressure",
        //        knopieNaamKort = "AltP",
        //        breedte = 1,
        //        posisie = bottomVal,
        //        skuif = 1,
        //        teken = true,
        //        tekenTipe = "grafiek",
        //        //tekenAanvanklik = true,
        //        faktor = 500,
        //        vinnigeKnopie = true
        //    });

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.attitudePitchLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.attitudePitchLeft,
        //            kleur = Color.Brown,
        //            knopieNaam = "Attitude Pith",
        //            knopieNaamKort = "APi",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 10,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.altitudeRadioLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.altitudeRadioLeft,
        //            kleur = Color.BlueViolet,
        //            knopieNaam = "Altitude Radio",
        //            knopieNaamKort = "AltR",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 500,
        //            vinnigeKnopie = true
        //        });
        //    }



        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.autoPilotA))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.autoPilotA,
        //            kleur = Color.Brown,
        //            knopieNaam = "Auto Pilot A",
        //            knopieNaamKort = "APA",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 10,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.autoPilotB))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.autoPilotB,
        //            kleur = Color.Brown,
        //            knopieNaam = "Auto Pilot B",
        //            knopieNaamKort = "APB",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 10,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.flapHandlePosition))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.flapHandlePosition,
        //            kleur = Color.DarkMagenta,
        //            knopieNaam = "Flap handle position",
        //            knopieNaamKort = "fHDL",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            faktor = 5,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.flapTeLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.flapTeLeft,
        //            kleur = Color.DarkCyan,
        //            knopieNaam = "Flap TE Left",
        //            knopieNaamKort = "fTE",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = true,
        //            tekenTipe = "grafiek",
        //            faktor = 5,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankLeftQuantity))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.fuelTankLeftQuantity,
        //            kleur = Color.Black,
        //            knopieNaam = "fuel left tank",
        //            knopieNaamKort = "fLt",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 5000,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankCenterQuantity))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.fuelTankCenterQuantity,
        //            kleur = Color.Black,
        //            knopieNaam = "fuel centre tank",
        //            knopieNaamKort = "fCt",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 5000,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankRightQuantity))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.fuelTankRightQuantity,
        //            kleur = Color.Black,
        //            knopieNaam = "fuel right tank",
        //            knopieNaamKort = "fRt",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 5000,
        //            vinnigeKnopie = true
        //        });
        //    }



        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.grossWeight))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.grossWeight,
        //            kleur = Color.Brown,
        //            knopieNaam = "GrossWeight",
        //            knopieNaamKort = "GW",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 50000,
        //            vinnigeKnopie = true
        //        });
        //    }


        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.rowCounter))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.rowCounter,
        //            kleur = Color.Black,
        //            knopieNaam = "Counter",
        //            knopieNaamKort = "co",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 0,
        //            teken = true,
        //            tekenTipe = "waarde",
        //            //tekenAanvanklik = true,
        //            faktor = 500,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navDevGSLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.navDevGSLeft,
        //            kleur = Color.DarkBlue,
        //            knopieNaam = "Glide Slope Dev",
        //            knopieNaamKort = "GSd",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 0.1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navDevLocLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.navDevLocLeft,
        //            kleur = Color.SlateBlue,
        //            knopieNaam = "Localiser Dev",
        //            knopieNaamKort = "LOCd",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 23,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 0.1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navFreqLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.navFreqLeft,
        //            kleur = Color.DarkCyan,
        //            knopieNaam = "Nav Freq Left",
        //            knopieNaamKort = "fqL",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 0,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }
        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.magneticHeadingLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.magneticHeadingLeft,
        //            kleur = Color.DeepPink,
        //            knopieNaam = "Magnetic Heading",
        //            knopieNaamKort = "HDG",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = true,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }
        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedCAS))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.speedCAS,
        //            kleur = Color.DarkCyan,
        //            knopieNaam = "CAS",
        //            knopieNaamKort = "CAS",
        //            breedte = 0,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = true,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedBrakeHandle))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.speedBrakeHandle,
        //            kleur = Color.SteelBlue,
        //            knopieNaam = "SpeedBrake",
        //            knopieNaamKort = "SB",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = -50,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedGround))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.speedGround,
        //            kleur = Color.Black,
        //            knopieNaam = "GS",
        //            knopieNaamKort = "GS",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedMach))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.speedMach,
        //            kleur = Color.Red,
        //            knopieNaam = "mach",
        //            knopieNaamKort = "mach",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = false,
        //            faktor = 0.5,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedV2))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.speedV2,
        //            kleur = Color.Black,
        //            knopieNaam = "V2",
        //            knopieNaamKort = "V2",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 19,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }


        //    PlotList.Parameters.Add(new PlotParameters
        //    {
        //        waardeOmTePlot = "DaalSpoed",
        //        kleur = Color.LimeGreen,
        //        knopieNaam = "Vertical speed calculated",
        //        knopieNaamKort = "VS",
        //        posisie = bottomVal,
        //        skuif = 8,
        //        teken = false,
        //        tekenTipe = "grafiek",
        //        //tekenAanvanklik = true,
        //        faktor = 500,
        //        vinnigeKnopie = true
        //    });

        //    Type t = typeof(JetEngineParameters);
        //    PropertyInfo[] pi = typeof(JetEngineParameters).GetProperties();
        //    Color[] colors = { Color.Brown, Color.Chocolate, Color.DarkGreen
        //                      ,Color.DarkKhaki, Color.IndianRed, Color.DarkSalmon
        //                      ,Color.DarkSlateGray, Color.DarkGray, Color.Black
        //                      ,Color.DarkMagenta, Color.DarkSlateBlue, Color.Blue};
        //    int count = 0;

        //    for (int i = 0; i < FlightParameters.JetEngineParameters.Count; i++)
        //    {
        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].bleed))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].bleed,
        //                kleur = Color.Black,
        //                knopieNaam = "bleed " + (i + 1),
        //                knopieNaamKort = "b " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 50,
        //                vinnigeKnopie = true
        //            });
        //            count++;
        //        }

        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].egt))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].egt,
        //                kleur = colors[count],
        //                knopieNaam = "EGT " + FlightParameters.JetEngineParameters[i].egt,
        //                knopieNaamKort = "EGT " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 500,
        //                vinnigeKnopie = true
        //            });
        //            count++;
        //        }

        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].N1))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].N1,
        //                kleur = colors[count],
        //                knopieNaam = "N1 " + FlightParameters.JetEngineParameters[i].N1,
        //                knopieNaamKort = "N1 " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 50,
        //                vinnigeKnopie = true
        //            });
        //            count++;
        //        }

        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].N2))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].N2,
        //                kleur = colors[count],
        //                knopieNaam = "N2 " + FlightParameters.JetEngineParameters[i].N2,
        //                knopieNaamKort = "N2 " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 50,
        //                vinnigeKnopie = true
        //            });
        //            count++;
        //        }
        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].oilPressure))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].oilPressure,
        //                kleur = colors[count],
        //                knopieNaam = "OP " + FlightParameters.JetEngineParameters[i].oilPressure,
        //                knopieNaamKort = "OP " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 10,
        //                vinnigeKnopie = true
        //            });
        //        }

        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].oilTemp))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].oilTemp,
        //                kleur = colors[count],
        //                knopieNaam = "OT " + FlightParameters.JetEngineParameters[i].oilTemp,
        //                knopieNaamKort = "OT " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 10,
        //                vinnigeKnopie = true
        //            });
        //        }

        //        if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].fuelLever))
        //        {
        //            PlotList.Parameters.Add(new PlotParameters
        //            {
        //                waardeOmTePlot = FlightParameters.JetEngineParameters[i].fuelLever,
        //                kleur = colors[count],
        //                knopieNaam = "FL " + FlightParameters.JetEngineParameters[i].fuelLever,
        //                knopieNaamKort = "EFL " + (i + 1),
        //                breedte = 1,
        //                posisie = bottomVal,
        //                skuif = 19,
        //                teken = false,
        //                tekenTipe = "grafiek",
        //                //tekenAanvanklik = true,
        //                faktor = 1,
        //                vinnigeKnopie = true
        //            });
        //        }
        //        count++;

        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.gearLeverDown))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.gearLeverDown,
        //            kleur = Color.Black,
        //            knopieNaam = "Gear lever Down",
        //            knopieNaamKort = "GLD",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 2,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }
        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.gearUpLeft))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.gearUpLeft,
        //            kleur = Color.DarkBlue,
        //            knopieNaam = "Gear up left",
        //            knopieNaamKort = "GUL",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 3,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.windDirection))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.windDirection,
        //            kleur = Color.DarkBlue,
        //            knopieNaam = "Wind direction",
        //            knopieNaamKort = "WD",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.windVelocity))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.windVelocity,
        //            kleur = Color.DarkMagenta,
        //            knopieNaam = "Wind velocity",
        //            knopieNaamKort = "WS",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 1,
        //            teken = false,
        //            tekenTipe = "grafiek",
        //            //tekenAanvanklik = true,
        //            faktor = 50,
        //            vinnigeKnopie = true
        //        });
        //    }

        //    if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.GMTtime))
        //    {
        //        PlotList.Parameters.Add(new PlotParameters
        //        {
        //            waardeOmTePlot = FlightParameters.GMTtime,
        //            kleur = Color.Black,
        //            knopieNaam = "GMT",
        //            knopieNaamKort = "GMT",
        //            breedte = 1,
        //            posisie = bottomVal,
        //            skuif = 2,
        //            teken = false,
        //            tekenTipe = "waarde",
        //            //tekenAanvanklik = ,
        //            faktor = 1,
        //            vinnigeKnopie = true
        //        });
        //    }
        //}
    }
}
