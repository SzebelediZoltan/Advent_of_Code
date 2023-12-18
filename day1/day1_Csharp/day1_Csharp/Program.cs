using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_Csharp
{
    class Program
    {
        static List<string> adatok = new List<string>();
        static void Main(string[] args)
        {
            Bekeres();
            Kalibracio();

            Console.ReadLine();
        }

        static void Kalibracio()
        {

            int osszeg = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                string szam = "";
                string elso = "";
                string utolso = "";
                int db = 0;
                for (int j = 0; j < adatok[i].Length; j++)
                {
                    if (Char.IsNumber(adatok[i][j]))
                    {
                        if (db == 0)
                        {
                            elso = Convert.ToString(adatok[i][j]);
                        }

                        db++;
                        utolso = Convert.ToString(adatok[i][j]);
                    }
                }

                szam += elso;
                szam += utolso;
                osszeg += Convert.ToInt32(szam);
            }

            Console.WriteLine(osszeg);
        }

        static void Bekeres()
        {
            string input = Console.ReadLine();
            while(input != "")
            {
                adatok.Add(input);
                input = Console.ReadLine();
            }
        }

        static void ListaKiir(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
