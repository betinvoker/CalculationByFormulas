using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    /*  Рассчитывается дальность прямой видимости Do, км, для CH и OH, расположенных
        на высотах hм и hn  */
    class Formula_3
    {
        double CH_height, OH_height, Do;
        public Formula_3(double CH_height, double OH_height)
        {
            this.CH_height = CH_height;
            this.OH_height = OH_height;

            Do = Formula(CH_height, OH_height);
        }
        private double Formula(double CH_height, double OH_height)
        {
            return Math.Sqrt((2 * GlobalVariables.R3) * (Math.Sqrt(OH_height) + Math.Sqrt(CH_height)));
        }
        public double Result()
        {
            return Do;
        }
        public string Show()
        {
            return "\nФормула 3.\nДальность прямой видимости: " + Math.Round(Do, 5) +
                " км.\nДля СН и ОН, расположенных на высотах hм и hn.\n"
                + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
