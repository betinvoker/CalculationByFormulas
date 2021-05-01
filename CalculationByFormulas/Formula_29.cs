using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_29
    {
        private double l1, l2, OH_height, hq, Bm, St;
        public Formula_29() { }
        public Formula_29(double l1, double l2, double OH_height, double hq, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.hq = hq * (Math.PI / 180.0);
            this.Bm = Bm * (Math.PI / 180.0);

            St = Formula(this.l1, this.l2, this.OH_height, this.hq, this.Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double hq, double Bm)
        {
            return Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2)) * (OH_height * (1 / Math.Tan(hq)) * Math.Sin(Bm) * (180.0 / Math.PI));
        }
        public double Result()
        {
            return St;
        }
        public string Show()
        {
            return "\nФормула 29.\nПлощадь проекции тени ОН: " + Math.Round(St, 5) +
                " м2\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
