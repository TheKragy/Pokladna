using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pokladna
{
    public class PokladniZaznam
    {
        public PokladniZaznam(int idPokladniZaznam, int cislo, DateTime datum, string popis, double castka, double zustatek, string poznamka)
        {
            this.idPokladniZaznam = idPokladniZaznam;
            Cislo = cislo;
            Datum = datum;
            Popis = popis;
            Castka = castka;
            Zustatek = zustatek;
            Poznamka = poznamka;
        }

        public int idPokladniZaznam { get; set; }
        public int Cislo { get; set; }
        public DateTime Datum { get; set; }
        public string Popis { get; set; }
        public double Castka { get; set; }
        public double Zustatek { get; set; }
        public string Poznamka { get; set; }
    }
}
