using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Fuvar
    {
        int azonosito;
        string indulas_idopont;
        int utazas_idotartama;
        double tavolsag;
        double viteldij;
        double borravalo;
        string fizetes_modja;

        public Fuvar(int azonosito, string indulas_idopont, int utazas_idotartama, double tavolsag, double viteldij, double borravalo, string fizetes_modja)
        {
            this.azonosito = azonosito;
            this.indulas_idopont = indulas_idopont;
            this.utazas_idotartama = utazas_idotartama;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetes_modja = fizetes_modja;
        }

        public int Azonosito { get => azonosito; }

        //2016-12-15 23:45:00
        public int Indulas_ev { get => int.Parse(indulas_idopont.Substring(0, 4)); }
        public int Indulas_honap { get => int.Parse(indulas_idopont.Substring(5, 2)); }
        public int Indulas_nap { get => int.Parse(indulas_idopont.Substring(8, 2)); }
        public int Indulas_ora { get => int.Parse(indulas_idopont.Substring(11, 2)); }
        public int Indulas_perc { get => int.Parse(indulas_idopont.Substring(14, 2)); }
        public int Indulas_mperc { get => int.Parse(indulas_idopont.Substring(17, 2)); }
        public int Utazas_idotartama { get => utazas_idotartama; }
        public double Tavolsag { get => tavolsag; }
        public double Viteldij { get => viteldij; }
        public double Borravalo { get => borravalo; }
        public string Fizetes_modja { get => fizetes_modja; }

        
    }
}
