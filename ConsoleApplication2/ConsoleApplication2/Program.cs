using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            samochod x = new samochod("BMW", 4, 0);
            samochod y = new samochod("Szerszen", 4, 100, "pomaranczowy", "1989");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

            x.Jedz(140);
            y.Jedz(80);

            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

            x.Hamuj();
            y.Hamuj();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
