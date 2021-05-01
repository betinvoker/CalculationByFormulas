using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_34
    {
        private double r_opM, l_maxT;
        public Formula_34() { }
        public Formula_34(double r_opM) 
        {
            this.r_opM = r_opM;

            l_maxT = Formula(this.r_opM);
        }
        private double Formula(double r_opM)
        {
            return 2 * r_opM;
        }
        public double Result()
        {
            return l_maxT;
        }
        public string Show()
        {
            return "\nФормула 34.\nМаксимальный линейный размер проекции тени: " + Math.Round(l_maxT, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
