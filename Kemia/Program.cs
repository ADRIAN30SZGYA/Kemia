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
            OtodikFeladat();
            HetedikFeladat();
            NyolcadikFeladat();

            Console.ReadKey();
        }

        private static void NyolcadikFeladat()
        {
            Console.WriteLine("8. feladat: Statisztika");

            Dictionary<string, int> stat = new Dictionary<string, int>();

            foreach (var item in felfedezes)
            {
                if (item.Ev != "Ókor")
                {
                    if (stat.ContainsKey(item.Ev))
                    {
                        stat[item.Ev]++;
                    }
                    else
                    {
                        stat.Add(item.Ev, 1);
                    }
                }
            }

            foreach (var item in stat)
            {
                if (item.Value > 3)
                {
                    Console.WriteLine("\t" + item.Key + ": " + item.Value + " db");
                }
            }
        }

        private static void HetedikFeladat()
        {
            int i = 0;
            foreach (var item in felfedezes)
            {
                if (item.Ev == "Ókor")
                {
                    i++;
                }
            }

            int max = Convert.ToInt32(felfedezes[i + 1].Ev) - Convert.ToInt32(felfedezes[i].Ev);
            i++;

            while (i < felfedezes.Count - 1)
            {
                if (max < Convert.ToInt32(felfedezes[i + 1].Ev) - Convert.ToInt32(felfedezes[i].Ev))
                {
                    max = Convert.ToInt32(felfedezes[i + 1].Ev) - Convert.ToInt32(felfedezes[i].Ev);
                }
                i++;
            }

            Console.WriteLine("7. feladat: " + max + " év volt a leghosszabb időszak két elem felfedezése között.");
        }

        private static void HatodikFeladat(string bekeres)
        {
            Console.WriteLine("6. feladat: Keresés");

            bool van = false;
            int i = 0;
            while (!van && i < felfedezes.Count)
            {
                if (felfedezes[i].Vegyjel.ToLower() == bekeres.ToLower())
                {
                    van = true;
                    Console.WriteLine("\tAz elem vegyjele: " + felfedezes[i].Vegyjel);
                    Console.WriteLine("\tAz elem neve: " + felfedezes[i].Nev);
                    Console.WriteLine("\tRendszáma: " + felfedezes[i].Rendszam);
                    Console.WriteLine("\tFelfedezés éve: " + felfedezes[i].Ev);
                    Console.WriteLine("\tFelfedező: " + felfedezes[i].Felfedezo);
                }
                i++;
            }

            if (!van)
            {
                Console.WriteLine("\tNincs ilyen elem az adatforrásban!");
            }
        }

        private static void OtodikFeladat()
        {
            Console.Write("5. feladat: Kérek egy vegyjelet: ");
            string bekeres = Console.ReadLine();
            while (bekeres.All(Char.IsLetter) && bekeres.Length != 2)
            {
                Console.Write("5. feladat: Kérek egy vegyjelet: ");
                bekeres = Console.ReadLine();
            }

            HatodikFeladat(bekeres);
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
