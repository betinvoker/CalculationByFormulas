using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_9
    {
        private double Bn, Wn;
        public Formula_9() { }
        public Formula_9(int num) { this.Wn = num; }
        public Formula_9(double Bn)
        {
            this.Bn = Bn;

            Wn = Formula(Bn);
        }
        private double Formula(double Bn)
        {
            return Bn + 90;
        }
        public double Result()
        {
            return Wn;
        }
        public string Show()
        {
            return "\nФормула 9.\nУгол визирования из точки расположения СН " + Math.Round(Wn, 5) +
                " град.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
