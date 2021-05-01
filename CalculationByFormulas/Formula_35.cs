using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_35
    {
        private double r_vpM, l_minT;
        public Formula_35() { }
        public Formula_35(double r_vpM)
        {
            this.r_vpM = r_vpM;

            l_minT = Formula(this.r_vpM);
        }
        private double Formula(double r_vpM)
        {
            return 2 * r_vpM;
        }
        public double Result()
        {
            return l_minT;
        }
        public string Show()
        {
            return "\nФормула 35.\nМинимальный линейный размер проекции тени: " + Math.Round(l_minT, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
