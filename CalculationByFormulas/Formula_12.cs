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
            this.CH_latitude = CH_latitude * (Math.PI / 180.0);
            this.OH_latitude = OH_latitude * (Math.PI / 180.0);
            this.O = O * (Math.PI / 180.0);

            A = Formula(this.CH_latitude, this.OH_latitude, this.O);
        }
        private double Formula(double CH_latitude, double OH_latitude, double O)
        {
            return Math.Acos(((Math.Sin(CH_latitude) * (Math.PI / 180.0)) 
                - (Math.Cos(O) * (Math.PI / 180.0))
                * (Math.Sin(OH_latitude)) * (Math.PI / 180.0))
                / ((Math.Sin(O) * (Math.PI / 180.0))
                * (Math.Cos(OH_latitude) * (Math.PI / 180.0))));
        }
        public double Result() { return A; }
        public string Show()
        {
            return "\nФормула 12.\nАзимут на СН из точки расположения ОН А = " + Math.Round(A, 5) +
                " град.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
