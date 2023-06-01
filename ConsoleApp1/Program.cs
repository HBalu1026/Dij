using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        class Adatok
        {
            int evszam;
            string tipus;
            string kereztnev;
            string vezeteknev;

            public Adatok(int evszam, string tipus, string kereztnev, string vezeteknev)
            {
                this.evszam = evszam;
                this.tipus = tipus;
                this.kereztnev = kereztnev;
                this.vezeteknev = vezeteknev;
            }
        }

        static void Main(string[] args)
        {
            string[] fajl = File.ReadAllLines("nobel.csv");
            List<Adatok> adatokLista = new List<Adatok>();
            for (int i = 1; i < fajl.Length; i++)
            {
                string[] splitelt = fajl[i].Split(';');
                adatokLista.Add(Convert.ToInt32(splitelt[0]), splitelt[1], splitelt[2], splitelt[3]);
            }

            //3
            for (int i = 0; i < adatokLista.Length; i++)
            {
                
            }
            string eredmeny3 = adatokLista.Select(n=>n.tipus).Where(n => n.keresztnev == "Arthur B." && n.vezeteknev == "McDonald");
            Console.WriteLine("3.feladat: " + eredmeny3);

            //4
            string eredmeny4vezetek = adatokLista.Select(n => n.vezeeknev).Where(n => n.evszam == 2017 && n.tipus == "irodalmi");
            string eredmeny4kereszt = adatokLista.Select(n => n.keresztnev).Where(n => n.evszam == 2017 && n.tipus == "irodalmi");
            Console.WriteLine("4.feladat: " + eredmeny4kereszt + " " + eredmeny4vezetek);

            //6
            string[] eredmeny6 = adatokLista.Select(n => n.vezeteknev == "Curie");
            Console.WriteLine("6.feladat: " + eredmeny6.Select(n => n.evszam) + ": " + eredmeny6.Select(n => n.keresztnev) + " " + eredmeny6.Select(n => n.vezeteknev) + "(" + eredmeny6.Select(n => n.tipus) + ")");
            
        }

        private static string[] StreamReader(char v)
        {
            throw new NotImplementedException();
        }
    }
}
