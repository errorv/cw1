using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class StandardowyCzłowiek
    {
        public string Imie { get; private set; }
        public int Wiek { get; private set; }
        public string MiejsceZamieszkania { get; private set; }
        public static readonly int IloscKosciSzkieletowych = 206;
        public static readonly int IloscChromosomow = 46;

        public StandardowyCzłowiek(string imie, int wiek, string miejsceZamieszkania)
        {
            Imie = imie;
            Wiek = wiek;
            MiejsceZamieszkania = miejsceZamieszkania;
        }


        public override string ToString()
        {
            return string.Format("{0} lat {1} zamieszkały {2}", Imie, Wiek, MiejsceZamieszkania);
        }
    }
}