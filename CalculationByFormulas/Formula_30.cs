using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_30
    {
        private double l1, l2, OH_height, Bm, Gt;
        public Formula_30() { }
        public Formula_30(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            Gt = Formula(this.l1, this.l2, this.OH_height, this.Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double Bm)
        {
            return 2 * ((l1 * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l1, 2) * Math.Pow(Math.Sin(Bm), 2))) / 
                Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l1, 2)) + OH_height * (1 / Math.Tan(OH_height)) * Math.Sin(Bm));
        }
        public double Result()
        {
            return Gt;
        }
        public string Show()
        {
            return "\nФормула 30.\nПериметр проекции ОН: " + Math.Round(Gt, 5) +
                " м\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
