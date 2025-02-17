using System;
using Matan;

namespace Program1
{
    public class Program
    {
        static void Main()
        {
            MatrixCramer matrix = new MatrixCramer();
            for (int i = 0; i < 6; i++)
            {
                matrix.Rations();
            }
            matrix.Cramer();
        }
    }
}