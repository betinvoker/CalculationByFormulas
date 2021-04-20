using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationByFormulas
{
    class MainFormula
    {
        const string title_1_2 = "1.2.    Определение характеристик взаимного пространственного положения СН и ОН",
                title_1_3 = "1.3.   Определение характеристик взаимного пространственного положения СН, ОН и Солнца",
                title_1_4 = "1.4.    Расчёт геометрических характеристик проекций объекта и тени";
        string stopComputing = "\nDн > Do, дальнейшие вычисления не производятся, поскольку наблюдение\n" +
                    "ОН из точки расположения СН в данных условиях невозможно.\n" + string.Concat(Enumerable.Repeat('_', 22));
        private double CH_latitude, CH_longitude, CH_height, heightMo, OH_latitude, OH_longitude, OH_height, heightNo, l1, l2;
        private double aM, a;
        private string[] inpShowData, outShowResult;
        
        public MainFormula(){ }
        public MainFormula(double CH_latitude, double CH_longitude, double CH_height,
            double heightMo, double OH_latitude, double OH_longitude, double OH_height, double heightNo)
        {
            this.CH_latitude = CH_latitude;
            this.CH_longitude = CH_longitude;
            this.CH_height = CH_height;
            this.heightMo = heightMo;

            this.OH_latitude = OH_latitude;
            this.OH_longitude = OH_longitude;
            this.OH_height = OH_height;
            this.heightNo = heightNo;

            inpShowData = new string[]
            {
                "СН широта: " + this.CH_latitude + " град.",
                "СН долгота: " + this.CH_longitude + " град.",
                "СН высота расположения: " + this.CH_height + " км.",
                "СН высота над уровнем моря: " + this.heightMo + " км.",
                "ОН широта: " + this.OH_latitude + " град.",
                "ОН долгота: " + this.OH_longitude + " град.",
                "ОН высота расположения: " + this.OH_height + " км.",
                "ОН высота над уровнем моря: " + this.heightNo + " км.",
            };

            Formula_1 O = new Formula_1(this.CH_latitude, this.CH_longitude, this.OH_latitude, this.OH_longitude);
            Formula_2 D = new Formula_2(O.Result());
            Formula_3 Do = new Formula_3(this.CH_height, this.OH_height);
            Formula_5_and_6 hMo = new Formula_5_and_6(this.CH_height, this.heightMo);
            Formula_5_and_6 hNo = new Formula_5_and_6(this.OH_height, this.heightNo);
            Formula_4 Dn = new Formula_4();
            Formula_7 Bm = new Formula_7();
            Formula_8 Bn = new Formula_8();
            Formula_9 Wn = new Formula_9();

            if (CheckingTheInputCoordinatesForEquality(this.CH_latitude, this.CH_longitude, this.OH_latitude, this.OH_longitude))
            {
                Dn = new Formula_4(this.CH_height, this.OH_height);
                aM = 0;

                if (this.CH_height >= this.OH_height)
                {
                    Bm = new Formula_7(90);
                    Wn = new Formula_9(0);
                }
                else
                {
                    Bm = new Formula_7(-90);
                    Wn = new Formula_9(180);
                }
            }
            else
            {
                Dn = new Formula_4(hMo.Result(), hNo.Result(), D.Result(), O.Result());
            }

            /*  Если Dн > Do, то дальнейшие вычисления не производятся, поскольку наблюдение
                ОН из точки расположения СН в данных условиях невозможно.   */
            if (Dn.Result() <= Do.Result())
            {
                Bm = new Formula_7(this.CH_height, this.OH_height, O.Result());
                Bn = new Formula_8(O.Result(), (double)Bm.Result());
                Wn = new Formula_9(Bn.Result());
                Formula_12 A = new Formula_12(this.CH_latitude, this.OH_latitude, O.Result());

                outShowResult = new string[] {
                    title_1_2,
                    O.Show(),
                    D.Show(),
                    Do.Show(),
                    Dn.Show(),
                    hMo.Show_5(),
                    hNo.Show_6(),
                    Bm.Show(),
                    Bn.Show(),
                    Wn.Show(),
                    A.Show(),
                };
            }
            else
                outShowResult = new string[] {
                    title_1_2,
                    O.Show(),
                    D.Show(),
                    Do.Show(),
                    Dn.Show(),
                    hMo.Show_5(),
                    hNo.Show_6(),
                    stopComputing,
                };
        }
        public MainFormula(double CH_latitude, double CH_longitude, double CH_height, double heightMo, 
            double OH_latitude, double OH_longitude, double OH_height, double heightNo,
            double l1, double l2)
        {
            this.CH_latitude = CH_latitude;
            this.CH_longitude = CH_longitude;
            this.CH_height = CH_height;
            this.heightMo = heightMo;

            this.OH_latitude = OH_latitude;
            this.OH_longitude = OH_longitude;
            this.OH_height = OH_height;
            this.heightNo = heightNo;

            this.l1 = l1;
            this.l2 = l2;

            inpShowData = new string[]
            {
                "СН широта: " + this.CH_latitude + " град.",
                "СН долгота: " + this.CH_longitude + " град.",
                "СН высота расположения: " + this.CH_height + " км.",
                "СН высота над уровнем моря: " + this.heightMo + " км.",
                "ОН широта: " + this.OH_latitude + " град.",
                "ОН долгота: " + this.OH_longitude + " град.",
                "ОН высота расположения: " + this.OH_height + " км.",
                "ОН высота над уровнем моря: " + this.heightNo + " км.",
                "Размер проекции 1: " + this.l1 + "м.",
                "Размер проекции 2: " + this.l2 + "м.",
            };

            Formula_1 O = new Formula_1(this.CH_latitude, this.CH_longitude, this.OH_latitude, this.OH_longitude);
            Formula_5_and_6 hMo = new Formula_5_and_6(this.CH_height, this.heightMo);
            Formula_5_and_6 hNo = new Formula_5_and_6(this.OH_height, this.heightNo);
            Formula_7 Bm = new Formula_7(this.CH_height, this.OH_height, O.Result());
            Formula_22 So = new Formula_22(this.l1, this.l2, this.OH_height, Bm.Result());
            Formula_23 Go = new Formula_23(this.l1, this.l2, this.OH_height, Bm.Result());
            Formula_24 r_onO = new Formula_24(this.l1, this.l2, this.OH_height, Bm.Result());

            outShowResult = new string[] {
                title_1_4,
                O.Show(),
                hMo.Show_5(),
                hNo.Show_6(),
                Bm.Show(),
                So.Show(),
                Go.Show(),
                r_onO.Show(),
            };
        }

        //  Если координаты СН и ОН совпадают
        private bool CheckingTheInputCoordinatesForEquality(double CH_latitude, double CH_longitude, double OH_latitude, double OH_longitude)
        {
            if (CH_latitude == OH_latitude && CH_longitude == OH_longitude)
                return true;
            return false;
        }
        public string ShowInputData()
        {
            string result = "";
            foreach (var item in inpShowData)
            {
                result += item + "\n";
            }
            return string.Concat(Enumerable.Repeat('_', 22)) + "\n" + result;
        }
        public string ShowOutputData()
        {
            string result = "";
            foreach (var item in outShowResult)
            {
                result += item;
            }
            return result;
        }
    }
}
