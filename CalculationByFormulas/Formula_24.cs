using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_24
    {
        private double l1, l2, OH_height, Bm, r_onO;
        public Formula_24() { }
        public Formula_24(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            r_onO = Formula(this.l1, this.l2, this.OH_height, this.Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double Bm)
        {
            return 0.5f * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2) + Math.Pow(OH_height, 2) * Math.Pow(Math.Cos(Bm), 2));
        }
        public double Result()
        {
            return r_onO;
        }
        public string Show()
        {
            return "\nФормула 24.\nРадиус наименьшей описанной окружности проекции ОН: " + Math.Round(r_onO, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
