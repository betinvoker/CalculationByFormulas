using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_4
    {
        double CH_height, OH_height, hMo, hNo, D, O, Dn;
        public Formula_4()  {}
        public Formula_4(double CH_height, double OH_height)
        {
            this.CH_height = CH_height;
            this.OH_height = OH_height;

            Dn = Math.Abs(CH_height - OH_height);
        }
        public Formula_4(double hMo, double hNo, double D, double O)
        {
            this.hMo = hMo;
            this.hNo = hNo;
            this.D = D;
            this.O = O * (Math.PI / 180.0);

            Dn = Formula(hMo, hNo, D, O);
        }
        private double Formula(double hMo, double hNo, double D, double O)
        {
            if (D <= 50)
                return Math.Sqrt(Math.Pow(D, 2) + Math.Pow(hMo - hNo, 2));
            else
                return Math.Sqrt(Math.Pow(GlobalVariables.R3 + hMo, 2) +
                        Math.Pow(GlobalVariables.R3 + hNo, 2) - 2 *
                        (GlobalVariables.R3 + hMo) * (GlobalVariables.R3 + hNo) *
                        (Math.Cos(O) * (Math.PI / 180.0)));
        }
        public double Result()
        {
            return Dn;
        }
        public string Show()
        {
            return "\nФормула 4.\nДальность наблюдения: " + Math.Round(Dn, 5) +
                " км.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
