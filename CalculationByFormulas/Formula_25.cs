using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_25
    {
        private double l1, l2, OH_height, Bm, r_bnO1, r_bnO2, r_bnO;
        public Formula_25() { }
        public Formula_25(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm * (Math.PI / 180.0);

            r_bnO1 = Formula_r_bnO1(this.l1, this.l2, this.OH_height, this.Bm);
            r_bnO2 = Formula_r_bnO2(this.l1, this.l2);
            r_bnO = Formula_r_bnO(r_bnO1, r_bnO2);
        }
        private double Formula_r_bnO1(double l1, double l2, double OH_height, double Bm)
        {
            return 0.5f * (OH_height * Math.Cos(Bm) + l2 / l1 * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l1, 2) * Math.Pow(Math.Sin(Bm), 2)) /
                (Math.Sqrt(1 + Math.Pow(l2, 2) / Math.Pow(l1, 2) * Math.Pow(Math.Sin(Bm), 2)))) * (Math.PI / 180.0);
        }
        private double Formula_r_bnO2(double l1, double l2)
        {
            return 0.5f * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2));
        }
        private double Formula_r_bnO(double r_bnO1, double r_bnO2)
        {
            return Math.Min(r_bnO1, r_bnO2);
        }   
        public double Result()
        {
            return r_bnO;
        }
        public string Show()
        {
            return "\nФормула 25.\nРадиус наибольшей вписанной окружности проекции ОЗ: " + Math.Round(r_bnO, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
