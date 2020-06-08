using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    public class ClassEsercizi
    {

        public static int Max(int num1, int num2) //ESERCIZIO 1 MAX
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
                return num2;
        }

        public static int Min(int num1, int num2) //ESERCIZIO 1 MIN
        {
            if (num1 >= num2)
            {
                return num2;
            }
            else
                return num1;
        }

        public static double Media(double num1, double num2) //ESERCIZIO 1 MEDIA
        {
            return (num1 + num2) / 2;
        }
        public static double CalcoloMisterioso(double[] v)//ESRICZIO 2
        {
            double s = 0;
            if (v.Length == 0)
                s = double.NaN;
            else
            {
                for (int i = 0; i < v.Length; i++)
                    s = s + v[i];
            }
            return s;

        }


    }
}

    
