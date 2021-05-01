using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_7
    {
        private double CH_height, OH_height, O, Bm;
        public Formula_7() {}
        public Formula_7(int num) { this.Bm = num; }
        public Formula_7(double CH_height, double OH_height, double O)
        {
            this.CH_height = CH_height * (Math.PI / 180.0);
            this.OH_height = OH_height * (Math.PI / 180.0);
            this.O = O * (Math.PI / 180.0);

            Bm = Formula(this.CH_height, this.OH_height, this.O);
        }
        private double Formula(double CH_height, double OH_height, double O)
        {
            return Math.PI / 2 - Math.Atan(((Math.Cos(O) * (Math.PI / 180.0)) - (GlobalVariables.R3 + OH_height)
                / (GlobalVariables.R3 + CH_height)) / (Math.Sin(O) * (Math.PI / 180.0)));
        }
        public double Result()
        {
            return Bm;
        }
        public string Show()
        {
            return "\nФормула 7.\nУгол места СН из точки расположения ОН " + Math.Round(Bm, 5) +
                " град.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
