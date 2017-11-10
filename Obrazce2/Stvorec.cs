using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce2
{
    sealed partial class Stvorec : Obrazec, IKreslenie
    {
        double strana;

        public Stvorec(double strana)
        {
            this.strana = strana;
        }

        public override double VypocitajObsah()
        {
            return Math.Pow(strana, 2);
        }

        public void Vykresli()
        {
            Console.WriteLine("Kreslim stvorec");
        }

        public void Vytlac()
        {
            Console.WriteLine("Tlacim stvorec");
        }
    }
}
