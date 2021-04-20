using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_5_and_6
    {
        private double h;
        public Formula_5_and_6(double h, double ho)
        {
            this.h = h + ho;
        }
        public double Result()
        {
            return h;
        }
        public string Show_5()
        {
            return "\nФормула 5.\nРасстояние над уровнем моря СН: " + h +
                " км.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
        public string Show_6()
        {
            return "\nФормула 6.\nРасстояние над уровнем моря ОН: " + h +
                " км.\n" + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
