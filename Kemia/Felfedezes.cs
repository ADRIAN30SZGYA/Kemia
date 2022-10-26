using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    class Felfedezes
    {
        public string Ev { get; }

        public string Nev { get; }

        public string Vegyjel { get; }

        public int Rendszam { get; }

        public string Felfedezo { get; }

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
