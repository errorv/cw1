using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<konto> konta = new List<konto>
            {
            new konto("JakubSzmagaj", "11111", 3000, 1),
            new konto("SzymonKowalski", "22222", 1000, 2),
            new konto("PiotrDuda", "33333", 2000, 3)
            };
            konta[0].WplacPieniadze(10);
            konta[1].ZmienFunduszeKont(50);
            konta[2].KontoUsuniete(false);

            Console.WriteLine(konta[0].ToString());
            Console.WriteLine(konta[1].ToString());
            Console.ReadKey();


        }
    }
}