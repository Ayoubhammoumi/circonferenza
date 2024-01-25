using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circonferenza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circonferenza circonferenza = new circonferenza();

            circonferenza.raggio = 5;

            Console.WriteLine("{0}", circonferenza.calcolaperimetro(circonferenza.perimetro));

            Console.WriteLine("{0}", circonferenza.calcoloarea(circonferenza.area));

            Console.ReadLine();
        }

    }
}
