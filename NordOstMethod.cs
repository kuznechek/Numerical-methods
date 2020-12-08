using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_3higher
{
    internal class Program
    {
        const int n = 4;
        static int[] a = new int[n] {85, 105, 0, 40};
        static int[] b = new int[n] {60, 125, 40, 35};
        static int[,] c = new int[n, n]
        {
            {12, 3, 7, 10},
            {3, 8, 15, 10},
            {5, 2, 3, 12},
            {9, 14, 8, 1}
        };
        static int[,] d = new int[n, n]
        {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
        struct Element {
 
           public int Delivery{get;set;}
           public int Value   {get; set;}
           public static int  FindMinElement(int a, int b)
            {
                if (a > b) return b;
                if (a == b) { return a; }
                else return a;
            }
           
        }
 
        static void Main(string[] args)
        {
            Print();
            Nord_Ost();
        }

        static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("A = ");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0}\t", a[k]);
            }
            Console.WriteLine();
            Console.Write("B = ");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0}\t", b[k]);
            }
            Console.WriteLine();
            Console.WriteLine("Матрица С :");
            for (int k = 0; k < n; k++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write("{0}\t", c[k,h]);
                }
                Console.WriteLine();
            }
        }
        static void Nord_Ost()
        {
            int i = 0; int j = 0;
            while (i < n && j < n)
            {
                try
                {
                    if (a[i] == 0) { i++; }
                    if (b[j] == 0) { j++; }
                    if (a[i] == 0 && b[j] == 0) { i++; j++; }
                    d[i,j] = Element.FindMinElement(a[i], b[j]);
                    a[i] -= d[i,j];
                    b[j] -= d[i,j];
                }
                catch { }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}({1})\t", c[i, j], d[i,j]);
                }
                Console.WriteLine();
            }
            int Result = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Result += (c[i, j] * d[i,j]);
                }
            }
            Console.WriteLine("Результат = {0}", Result);
            Console.ReadLine();
        }
    }
}