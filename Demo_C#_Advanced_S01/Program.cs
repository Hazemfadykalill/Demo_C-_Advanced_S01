using Demo_C__Advanced_S01.Generic;
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
            //int[] arr = { 10, 20, 30, 54, 5, 58, 85, 5, 8, 9, 8, 8, 8, 47 };
            //int Index = Helper<int>.SearchArray(arr, 54);
            //Console.WriteLine($"Index 54 Is {Index} ");

            #endregion

            #region Generics [Search Example With Struct]

            ///Employee employee01 = new Employee() { Id=10,Name="Aliaa",Salary=1000};
            ///Employee employee02 = new Employee() { Id=11,Name="Hazem",Salary=12000};
            ///if (employee01==employee02)//employee01==employee02 ===>invalid because == not define in user defined struct
            ///{
            ///    Console.WriteLine("Equal");
            ///}
            ///else
            ///{
            ///    Console.WriteLine(" Not Equal");
            ///}


            //Employee employee01 = new Employee() { Id=10,Name="Aliaa",Salary=1000};
            //Employee employee02 = new Employee() { Id=11,Name="Hazem",Salary=12000};
            //Employee employee03 = new Employee() { Id=12,Name="fady",Salary=13000};
            //Employee employee04 = new Employee() { Id = 11, Name = "Hazem", Salary = 12000 };
            // Employee[] employee = new Employee[2]
            // {
            //     employee01, employee02
            // };

            // int Index = Helper<Employee>.SearchArray(employee, employee03);
            // Console.WriteLine($"Index employee03 is {Index} ");

            // int Index02 = Helper<Employee>.SearchArray(employee, employee04);
            // Console.WriteLine($"Index employee04 is {Index02} ");
            #endregion

            #region Generics [Search With Class ]

            ////Employee employee01 = new Employee() { Id=10,Name="Aliaa",Salary=1000};
            ////Employee employee02 = new Employee() { Id=11,Name="Hazem",Salary=12000};
            ////Employee employee03 = new Employee() { Id=11,Name="Hazem",Salary=12000};


            ///if (employee03==employee02)//employee01==employee02 ===>valid because ==  define in user defined class
            ///                           // == Compare  between Two References
            ///{
            ///    Console.WriteLine("Equal");
            ///}
            ///else
            ///{
            ///    Console.WriteLine(" Not Equal");
            ///}

            ///if (employee03.Equals(employee02))

            ///{
            ///    Console.WriteLine("Equal");
            ///}
            ///else
            ///{
            ///    Console.WriteLine(" Not Equal");
            ///}

            ///Console.WriteLine($"Get HashCode E02 is {employee02}");//  12000
            ///Console.WriteLine($"Get HashCode E03 is {employee03}");//  12000
            #endregion

            #region Not Generics [BubbleSort Example]
            int[] arr = { 10, 258, 4, 878, 14, 55, 14 };
            Console.WriteLine("Without Bubble Sorting"); 
            foreach (int i in arr)
            {
                Console.Write(" " + i);//  10 258 4 878 14 55 14
            }
            Helper.BubbleSort(arr);
            Console.WriteLine(" \n\nWith Bubble Sorting");
            foreach (int i in arr)
            {
                Console.Write(" " + i);//   4 10 14 14 55 258 878
            }



            #endregion



        }
    }
}
