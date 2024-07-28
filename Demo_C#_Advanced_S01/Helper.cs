using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__Advanced_S01
{
    internal class Helper<T>
    {

        #region Generics And Non_Generics [Swap  Example]


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
        public static void Swap(ref T X, ref T y)
        {
            T Temp = X;
            X = y;
            ; y = Temp;
        }
        #endregion

        #endregion


        #region Search Example
        #region Non_Generics[Search  Example ]
        //public static int SearchArray(int[] arr, int value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)

        //            if (arr[i] == value)
        //                return i;

        //    }

        //    return -1;

        //}


        #endregion

        #region Generic [Search Example]
        public static int SearchArray(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)

                    if (arr[i].Equals( value))// arr[i] == value ===> Invalid
                        return i;

            }

            return -1;

        }
        #endregion
        #endregion


    }
}
