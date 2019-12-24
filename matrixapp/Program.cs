using System;

namespace matrixapp
{
   
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double[,] N = { { 2, 2 }, { 1, 1 } };
            double[,] L = { { 2, 5 }, { 7, 4 } };
            double[,] res = Matrix.Plus(N, L);
            for (int row = 0; row < res.GetLength(0); row++)
            {
                for (int col = 0; col < res.GetLength(1); col++)
                {
                    Console.Write(res[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
 
 

    class Matrix
{
    public static double[,] Plus(double[,] N, double[,] L)
    {
        double[,] res = new double[N.GetLength(0), N.GetLength(1)];

        for (int row = 0; row < N.GetLength(0); row++)
        {
            for (int col = 0; col < N.GetLength(1); col++)
            {
                res[row, col] = N[row, col] + L[row, col];
            }
        }
        return res;
    }
    
}
