using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__Advanced_S01
{
    public class Helper<T> where T : IComparable
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

        #region Generic [Search Example With Equal And Use Struct With It ]
        //public static int SearchArray(T[] arr, T value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)

        //            if (arr[i].Equals( value))// arr[i] == value ===> Invalid because == Not define In All User defined dateType Ex Struct ...
        //                return i;

        //    }

        //    return -1;

        //}
        #endregion


        #region Generics [Sort Array By Use Bubble Sort And Without Non_Generic ]
        //public static void BubbleSort(int[] arr)
        //{
        //    if(arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int k = 0; k < arr.Length-i-1; k++)
        //            {
        //                if (arr[k] > arr[k+1])
        //                {
        //                    Helper.Swap(ref arr[k], ref arr[k+1]);
        //                }
        //            }

        //        }
        //    }
        //}




        #endregion
        #endregion


        #region Generics [Sort Array By Use Bubble Sort And With Non_Generic ]
        public static void BubbleSort(T[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int k = 0; k < arr.Length - i - 1; k++)
                    {
                        if (arr[k].CompareTo(arr[k + 1])==1)
                        {
                            Helper<T>.Swap(ref arr[k], ref arr[k + 1]);
                        }
                    }

                }
            }
        }

        #endregion

    }
}
