using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_33
    {
        private double r_vpM, r_opM, rM;
        public Formula_33() { }
        public Formula_33(double r_vpM, double r_opM)
        {
            this.r_vpM = r_vpM;
            this.r_opM = r_opM;

            rM = Formula(this.r_vpM, this.r_opM);
        }
        private double Formula(double r_vpM, double r_opM)
        {
            return 0.5f * (r_vpM + r_opM);
        }
        public double Result()
        {
            return rM;
        }
        public string Show()
        {
            return "\nФормула 33.\nСреднеарифметическое значение радиуса проекции тени: " + Math.Round(rM, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
