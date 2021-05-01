using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_27
    {
        double r_onO, lmax_o;
        public Formula_27() { }
        public Formula_27(double r_onO)
        {
            this.r_onO = r_onO;

            lmax_o = Formula(this.r_onO);
        }
        private double Formula(double r_onO)
        {
            return 2 * r_onO;
        }
        public double Result()
        {
            return lmax_o;
        }
        public string Show()
        {
            return "\nФормула 27.\nМаксимальный линейный размер проекции ОН: " + Math.Round(lmax_o, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
