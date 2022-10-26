using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kemia
{
    class Program
    {
        static List<Felfedezes> felfedezes = new List<Felfedezes>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();

            Console.ReadKey();
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("4. feladat: Felfedézesek száma az ókorban: " + felfedezes.Count(x => x.Ev == "Ókor"));
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat: Elemek száma: " + felfedezes.Count);
        }

        private static void MasodikFeladat()
        {
            using (StreamReader sr = new StreamReader("felfedezesek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(';');
                    string ev = tmp[0];
                    string nev = tmp[1];
                    string vegyjel = tmp[2];
                    int rendszam = Convert.ToInt32(tmp[3]);
                    string felfedezo = tmp[4];
                    felfedezes.Add(new Felfedezes(ev, nev, vegyjel, rendszam, felfedezo));
                }
            }
        }
    }
}
