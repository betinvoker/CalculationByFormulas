using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_31
    {
        private double l1, l2, OH_height, Bm, r_opM;
        public Formula_31() { }
        public Formula_31(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            r_opM = Formula(this.l1, this.l2, this.OH_height, this.Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double Bm)
        {
            return 0.5f * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2) + Math.Pow(OH_height * (1 / Math.Tan(OH_height)) * Math.Sin(Bm), 2));
        }
        public double Result()
        {
            return r_opM;
        }
        public string Show()
        {
            return "\nФормула 31.\nРадиус наименьшей описанной окружности проекции тени: " + Math.Round(r_opM, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
