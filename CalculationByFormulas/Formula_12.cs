using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_12
    {
        double CH_latitude, OH_latitude, O, A;
        public Formula_12(double CH_latitude, double OH_latitude, double O)
        {
            this.CH_latitude = CH_latitude;
            this.OH_latitude = OH_latitude;
            this.O = O;

            A = Formula(this.CH_latitude, this.OH_latitude, this.O);
        }
        private double Formula(double CH_latitude, double OH_latitude, double O)
        {
            return Math.Acos((Math.Sin(CH_latitude) - Math.Cos(O) * Math.Sin(OH_latitude)) /
                (Math.Sin(O) * Math.Cos(OH_latitude)));
        }
        public double Result() { return A; }
        public string Show()
        {
            return "\nФормула 12.\nАзимут на СН из точки расположения ОН А = " + Math.Round(A, 5) +
                " град.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
