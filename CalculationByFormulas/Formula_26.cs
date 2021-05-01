using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_26
    {
        private double r_onO, r_bnO, r_ob;
        public Formula_26() { }
        public Formula_26(double r_onO, double r_bnO)
        {
            this.r_onO = r_onO;
            this.r_bnO = r_bnO;

            r_ob = Formula(this.r_onO, this.r_bnO);
        }
        private double Formula(double r_onO, double r_bnO)
        {
            return 0.5f * (r_onO + r_bnO);
        }
        public double Result()
        {
            return r_ob;
        }
        public string Show()
        {
            return "\nФормула 26.\nСреднеарифметическое значение радиуса проекции ОН: " + Math.Round(r_ob, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
