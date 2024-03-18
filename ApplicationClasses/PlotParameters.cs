using System;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace FOQA.ApplicationClasses
{
    public class PlotParameters
    {
        public int breedte { get; set; }
        public double faktor { get; set; }
        public Color kleur { get; set; }
        public string knopieNaam { get; set; }
        public string knopieNaamKort { get; set; }
        public float posisie { get; set; }
        public int skuif { get; set; }
        public bool teken { get; set; }
        //public bool tekenAanvanklik { get; set; }
        public string tekenTipe { get; set; }
        public bool vinnigeKnopie { get; set; }
        public string waardeOmTePlot { get; set; }
    }

}
