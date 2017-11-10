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
            Console.WriteLine(kruh.VypocitajObsah());

            Obrazec stvorec = new Stvorec(12.4);
            Console.WriteLine(stvorec.VypocitajObsah());

            Console.ReadKey();


        }
    }
}
