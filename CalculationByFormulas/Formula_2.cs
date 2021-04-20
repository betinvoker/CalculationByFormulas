using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    /*  Рассчитать дальность по поверхности Земли D, град, между проекциями точек Mo и No СН
        и ОН на поверхность Земли   */
    class Formula_2
    {
        double O, D;
        public Formula_2(double O)
        {
            this.O = O;

            D = Formula(O);
        }
        private double Formula(double O)
        {
            return Math.PI * GlobalVariables.R3 * O / 180;
        }
        public double Result()
        {
            return D;
        }
        public string Show()
        {
            return "\nФормула 2.\nДальность по поверхности Земли: " + Math.Round(D, 5) +
                " км.\nМежду проекциями точек Mo и No СН и ОН на поверхности Земли.\n"
                + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
