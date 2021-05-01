using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_32
    {
        private double l1, l2, OH_height, Bm, r_vpM1, r_vpM2, r_vpM;
        public Formula_32() { }
        public Formula_32(double l1, double l2, double OH_height, double Bm)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.OH_height = OH_height;
            this.Bm = Bm;

            r_vpM1 = Formula_r_vpM1(this.l1, this.l2, this.OH_height, this.Bm);
            r_vpM2 = Formula_r_vpM1(this.l1, this.l2);
            r_vpM = Formula_r_vpM(r_vpM1, r_vpM2);
        }
        private double Formula_r_vpM1(double l1, double l2, double OH_height, double Bm)
        {
            return 0.5f * OH_height * (1 / Math.Tan(OH_height)) * Math.Sin(Bm) / Math.Sqrt(1 + Math.Pow(l2, 2) * Math.Pow(Math.Sin(Bm), 2) / Math.Pow(l1, 2));
        }
        private double Formula_r_vpM1(double l1, double l2)
        {
            return 0.5f * Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2));
        }
        private double Formula_r_vpM(double r_vpM1, double r_vpM2)
        {
            return Math.Min(r_vpM1, r_vpM2);
        }
        public double Result()
        {
            return r_vpM;
        }
        public string Show()
        {
            return "\nФормула 32.\nРадиус наибольшей вписанной окружности проекции тени: " + Math.Round(r_vpM, 5) +
                " м.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
