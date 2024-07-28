using System.Drawing;

namespace Demo_C__Advanced_S01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Generics [Swap Example]


            #region Non_Generics

            //int A=10, B=20;
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");
            //Helper.Swap(ref  A,ref  B );
            //Console.WriteLine($"After Swapping");
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");


            //double A = 10, B = 20;
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"After Swapping");
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");


            //Point P01 = new Point(10, 20);
            //Point P02 = new Point(30, 40);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Console.WriteLine($"After Swapping");
            //Helper.Swap(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            #endregion
            #region Generics
            //int A = 10, B = 20;
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"After Swapping");
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");


            //double A = 10, B = 20;
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"After Swapping");
            //Console.WriteLine($"A= {A}");
            //Console.WriteLine($"B= {B}");


            //Point P01 = new Point(10, 20);
            //Point P02 = new Point(30, 40);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Console.WriteLine($"After Swapping");
            //Helper.Swap(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            #endregion

            #endregion

            #region NoN_Generics [Search Example]
            int[] arr = { 10, 20, 30, 54, 5, 58, 85, 5, 8, 9, 8, 8, 8, 47 };
            int Index = Helper.SearchArray(arr, 54);
            Console.WriteLine($"Index 54 Is {Index} ");

            #endregion


        }
    }
}
