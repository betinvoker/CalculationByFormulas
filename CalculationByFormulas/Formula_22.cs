using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_22
    {
        private double l1, l2, OH_height;
        private double So;
        private double? Bm;
        public Formula_22(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            So = Formula(l1, l2, OH_height, Bm);
        }
        private double Formula(double l1, double l2, double OH_height, double Bm)
        {
            return Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2)) * (OH_height * Math.Cos(Bm) + 
                (l1 * l2 * Math.Sin(Bm)) / Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2)));
        }
        public double Result()
        {
            return So;
        }
        public string Show()
        {
            return "\nФормула 22.\nПлощадь проекции ОН: " + Math.Round(So, 5) +
                " м2.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
