using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_28
    {
        double r_bnO, lmin_o;
        public Formula_28() { }
        public Formula_28(double r_bnO)
        {
            this.r_bnO = r_bnO;

            lmin_o = Formula(this.r_bnO);
        }
        private double Formula(double r_bnO)
        {
            return 2 * r_bnO;
        }
        public double Result()
        {
            return lmin_o;
        }
        public string Show()
        {
            return "\nФормула 28.\nМинимальный линейный размер проекции ОН: " + Math.Round(lmin_o, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
