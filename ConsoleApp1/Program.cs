using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region t1 massivin max ve min ededlerinin hasilini tapmaq
            //     const int x = 3, y = 3;
            //     int[,] Matrix2d = new int[x, y]
            //{
            //       { 3, 4, 5 },
            //       { 7, 8, 10 },
            //       { 13, 45, 55 }
            //};
            //     Console.WriteLine(" matrix: ");
            //     for (int i = 0; i < x; i++)
            //     {
            //         for (int j = 0; j < y; j++)
            //         {
            //             Console.Write(Matrix2d[i, j] + " ,");
            //         }
            //         Console.WriteLine();
            //     }
            //     Console.WriteLine();
            //     int max = Matrix2d[0, 0];
            //     int min = Matrix2d[0, 0];
            //     for (int i = 0; i < x; i++)
            //     {
            //         for (int j = 0; j < y; j++)
            //         {
            //             if (max < Matrix2d[i, j])
            //             {
            //                 max = Matrix2d[i, j];
            //             }
            //             if (min > Matrix2d[i, j])
            //             {
            //                 min = Matrix2d[i, j];
            //             }
            //         }
            //     }

            //     Console.WriteLine("Max: " + max);
            //     Console.WriteLine("Min: " + min);

            //     Console.WriteLine("Max ve min ededlerin hasili: " + max * min);

            #endregion


            #region t2 1 ci massivde olan 2ci massivde olmayan elementleri ekrana cxaran proqram

            int[] massiv1 = new int[5] { 4, 5, 78, 95, 7 };

            Console.WriteLine("1ci massiv: ");
            foreach (var item1 in massiv1)
            {

                Console.Write(item1 + " ");
            }
            int[] massiv2 = new int[5] { 45, 8, 78, 96, 7 };
            Console.WriteLine(" ");
            Console.WriteLine("2ci massiv: ");
            foreach (var item2 in massiv2)
            {

                Console.Write(item2 + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("1ci massivde olan 2 ci massivde olmayan:");

            for (int i = 0; i < massiv1.Length; i++)
            {
                int number = 0;
                for (int j = 0; j < massiv2.Length; j++)
                {
                    if (!(massiv1[i] == massiv2[j]))
                    {
                        number++;
                    }
                    if (number == massiv2.Length)
                    {
                        Console.Write(massiv1[i] + " ");
                    }

                }
            }
            #endregion
        }
    }
}
