using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__Advanced_S01
{
    internal class Helper
    {
        #region Non_Generics
        //public static void Swap(ref int x , ref int y )
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;

        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;

        //}

        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;

        //}
        #endregion

        #region Generics
        public static void Swap<T>(ref T X, ref T y)
        {
            T Temp = X;
            X = y;
            ; y = Temp;
        }
        #endregion
    }
}
