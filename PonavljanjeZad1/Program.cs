using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("broj: ");
            int a = Convert.ToInt32(Console.ReadLine());
            KlasaG plus = new KlasaG();
            KlasaG mnozenje = new KlasaG();

            Console.Write("Zbrajanje: ");
            plus.f50(a);
            Console.Write("Mnozenje: ");
            mnozenje.plus10(a);
            Console.ReadLine();
        }
    }
}
