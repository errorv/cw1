using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StandardowyCzłowiek> osoby = new List<StandardowyCzłowiek>();

            osoby.Add(new StandardowyCzłowiek("Jakub", 20, "Szczytno"));
            osoby.Add(new StandardowyCzłowiek("Adam", 21, "Warszawa"));
            osoby.Add(new StandardowyCzłowiek("Andrzej", 22, "Warszawa"));
            osoby.Add(new StandardowyCzłowiek("Ania", 23, "Kraków"));
            osoby.Add(new StandardowyCzłowiek("Maja", 24, "Olsztyn"));
            osoby.Add(new StandardowyCzłowiek("Klaudia", 25, "Warszawa"));
            osoby.Add(new StandardowyCzłowiek("Przemek", 26, "Olsztyn"));
            osoby.Add(new StandardowyCzłowiek("Wojtek", 27, "Olsztyn"));
            osoby.Add(new StandardowyCzłowiek("Ola", 28, "Kraków"));
            osoby.Add(new StandardowyCzłowiek("Jakub", 29, "Olsztyn"));
            osoby.Add(new StandardowyCzłowiek("Adam", 30, "Olsztyn"));

            double sredniaWieku = (double)osoby.Sum(x => x.Wiek) / osoby.Count;

            Console.WriteLine("Średnia wieku badanych osób wynosi {0}", sredniaWieku);

            Console.WriteLine();

            foreach (var czlowiek in osoby)
                Console.WriteLine(czlowiek.Imie);

            foreach (var czlowiek in osoby)
                Console.WriteLine(czlowiek);

            Dictionary<string, int> miasta = new Dictionary<string, int>();

            foreach (var czlowiek in osoby)
            {
                if (miasta.ContainsKey(czlowiek.MiejsceZamieszkania))
                    miasta[czlowiek.MiejsceZamieszkania]++;
                else
                    miasta.Add(czlowiek.MiejsceZamieszkania, 0);
            }

            string najczesciejWystepujaceMiasto = miasta.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine();
            Console.WriteLine("Najczęściej występujące miasto osób badanych {0}", najczesciejWystepujaceMiasto);

            Console.ReadKey();
        }
    }
}