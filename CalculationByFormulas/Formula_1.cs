using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class Formula_1
    {
        private double CH_latitude, CH_longitude, OH_latitude, OH_longitude;
        double O;
        string result;
        public Formula_1(double CH_latitude, double CH_longitude,
            double OH_latitude, double OH_longitude)
        {
            this.CH_latitude = CH_latitude;
            this.CH_longitude = CH_longitude;

            this.OH_latitude = OH_latitude;
            this.OH_longitude = OH_longitude;

            O = Formula(this.CH_latitude, this.CH_longitude, this.OH_latitude, this.OH_longitude);

            if (CheckingTheInputCoordinates(this.CH_latitude, this.CH_longitude, this.OH_latitude, this.OH_longitude))
                result = O.ToString("#.#########");
            else
                result = O.ToString("#.#####");
        }
        private double Formula(double CH_latitude, double CH_longitude, double OH_latitude, double OH_longitude)
        {
            double O;

            O = Math.Acos(Math.Sin(CH_latitude) * Math.Sin(OH_latitude) + Math.Cos(CH_latitude) 
                * Math.Cos(OH_latitude) * Math.Cos(CH_longitude - OH_longitude)) * (180.0 / Math.PI);

            return O;
        }
        //  Если условие выполняется, то расчет до ДЕВЯТОГО знака после запятой, иначе до ПЯТОГО знака
        private bool CheckingTheInputCoordinates(double CH_latitude, double CH_longitude, double OH_latitude, double OH_longitude)
        {
            if (Math.Abs(CH_latitude - OH_latitude) < 1 && Math.Abs(CH_longitude - OH_longitude) < 1.5f)
                return true;
            return false;
        }
        public double Result() { return O; }
        public string Show()
        {
            return "\nФормула 1.\nГеоцентрический угол: " + result +
                " град.\nМежду проекциями точек Mo и No СН и ОН на поверхности Земли.\n"
                + string.Concat(Enumerable.Repeat('_', 22));
        }
    }
}
