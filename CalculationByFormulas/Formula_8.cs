using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_8
    {
        double O, Bm, Bn;
        public Formula_8() { }
        public Formula_8(double O, double Bm)
        {
            this.O = O;
            this.Bm = Bm;

            Bn = Formula(O, Bm);
        }
        private double Formula(double O, double Bm)
        {
            return -(Bm + O);
        }
        public double Result()
        {
            return Bn;
        }
        public string Show()
        {
            return "\nФормула 8.\nУгол места ОН из точки расположения СН " + Math.Round(Bn, 5) +
                " град.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
