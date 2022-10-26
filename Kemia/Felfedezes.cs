using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    class Felfedezes
    {
        public string Ev { get; set; }

        public string Nev { get; set; }

        public string Vegyjel { get; set; }

        public int Rendszam { get; set; }

        public string Felfedezo { get; set; }

        public Felfedezes(string ev, string nev, string vegyjel, int rendszam, string felfedezo)
        {
            Ev = ev;
            Nev = nev;
            Vegyjel = vegyjel;
            Rendszam = rendszam;
            Felfedezo = felfedezo;
        }
    }
}
