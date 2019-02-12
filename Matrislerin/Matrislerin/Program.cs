using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrislerin
{
    class Program
    {
        static public void Carpma(int[,] a, int[,] b)
        {
            int[,] c = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];

                    }
                    Console.Write("{0} ", c[i, j]);

                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            Random r = new Random();//Matrislerin elemanları için Random Sayı alınacak.
            Console.WriteLine("Birinci Matris:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = r.Next(1, 6);
                    Console.Write("{0} ", matrix1[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("İkinci Matris:");
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = r.Next(1, 6);
                    Console.Write("{0} ",matrix2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrislerin Çarpım Sonucu");
            Carpma(matrix1, matrix2);

            Console.ReadKey();
        }
       

    }
    
}
