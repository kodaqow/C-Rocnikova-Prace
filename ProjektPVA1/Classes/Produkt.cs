using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPVA1
{
    public class Produkt
    {
        public string nazev { get; set; }
        public double cena { get; set; }
        public int mnozstvi { get; set; }

        public Produkt(string nazev, double cena, int mnozstvi)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.mnozstvi = mnozstvi;
        }
    }
}