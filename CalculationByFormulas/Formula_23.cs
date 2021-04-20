using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_23
    {
        private double l1, l2, OH_height, Bm, Go;
        public Formula_23() { }
        public Formula_23(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            if (this.Bm <= 0)
                this.Bm = 0;

            Go = Formula(this.l1, this.l2, this.OH_height, this.Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double Bm)
        {
            return 2 * (((l1 * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2) * Math.Pow(Math.Sin(Bm), 2))) + 
                (l2 * Math.Sqrt(Math.Pow(l2, 2) + Math.Pow(l1, 2) * Math.Pow(Math.Sin(Bm), 2)))) / 
                Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2)) + OH_height * Math.Cos(Bm));
        }
        public double Result()
        {
            return Go;
        }
        public string Show()
        {
            return "\nФормула 23.\nПериметр проекции ОН: " + Math.Round(Go, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
