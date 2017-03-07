using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class samochod
    {
        public string Marka { get; private set; }
        public int LiczbaKol { get; private set; }
        public int Predkosc { get; private set; }
        public string Kolor { get; private set; }
        public string Rocznik { get; private set; }
        public samochod(string marka, int lk, int v, string kolor="Czarny", string r="2016")
        {
            Marka = marka;
            LiczbaKol = lk;
            Predkosc = v;
            Kolor = kolor;
            Rocznik = r;
        }
        public void Hamuj()
        {
            Predkosc = 0;
            Console.WriteLine("samochod {0} koloru {1} zatrzymal sie", Marka, Kolor);
        
        }
        public void Jedz(int v)
        {
            if (v > 0)
                Predkosc = v;
          Console.WriteLine("samochod {0} koloru {1} ruszyl z predkoscia {2}", Marka, Kolor, Predkosc);
        }
        public override string ToString()
        {
            return string.Format("{0} samochód marki {1} jedzie z prędkością {2}"
                                 + "\nDomyślna ilość kół używanych jednocześnie w samochodzie to {3}\n",
                                 Kolor, Marka, Predkosc, LiczbaKol);
        }
    }
}
