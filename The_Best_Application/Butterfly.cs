using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Best_Application
{
    public class Butterfly
    {
        private int firstNumerator, firstDenominator, secondNumerator, secondDenominator;
        public Butterfly(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {
            this.firstNumerator = firstNumerator;
            this.firstDenominator = firstDenominator;
            this.secondNumerator = secondNumerator;
            this.secondDenominator = secondDenominator;
        }

        public int GetAddNum() //сложение
        {
            int res1, res2;
            res1 = firstNumerator * secondDenominator;
            res2 = secondNumerator * firstDenominator;

            if (CheckValueZero())
                return Convert.ToInt32(null);
            else
                return res1 + res2;
        }

        public int GetSubNum() //вычитание
        {
            int res1, res2;
            res1 = firstNumerator * secondDenominator;
            res2 = secondNumerator * firstDenominator;

            if (CheckValueZero())
                return Convert.ToInt32(null);
            else
                return res1 - res2;
        }

        public int GenDen() //общий знаменатель
        {
            if (CheckValueZero())
                return Convert.ToInt32(null);
            else
                return firstDenominator * secondDenominator;
        }

        public bool CheckValueZero()
        {
            if ((firstDenominator == 0) || (secondDenominator == 0))
                return true;
            else
                return false;
        }

    }
}
