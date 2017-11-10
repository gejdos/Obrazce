using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce2
{
    sealed partial class Stvorec : Obrazec
    {
        double strana;

        public Stvorec(double strana)
        {
            this.strana = strana;
        }

        public override double VypocitajObsah()
        {
            return strana * strana;
        }
    }
}
