using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce2
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrazec kruh = new Kruh(1.5);
            Console.WriteLine("Obsah kruhu: {0}\n", kruh.VypocitajObsah());

            Stvorec stvorec1 = new Stvorec(12.4);
            Console.WriteLine("Obsah stvorca: {0}\n", stvorec1.VypocitajObsah());
            Stvorec stvorec2 = new Stvorec(12.4);

            Console.WriteLine(Stvorec.Porovnaj(stvorec1, stvorec2));

            Console.ReadKey();

        }
    }
}
