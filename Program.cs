using System;

namespace Matan
{
    public class MatrixCramer
    {
        public double a11, a12, a21, a22, b1, b2;

        public double Rations()
        {
            Console.Write("Введите коэффициент (a11, a12, a21, a22, b1, b2): ");
            string coef = Console.ReadLine();
            Console.Write("Введите значение для " + coef + ": ");
            
            switch (coef)
            {
                case "a11":
                    a11 = Convert.ToDouble(Console.ReadLine());
                    return a11;
                case "a12":
                    a12 = Convert.ToDouble(Console.ReadLine());
                    return a12;
                case "a21":
                    a21 = Convert.ToDouble(Console.ReadLine());
                    return a21;
                case "a22":
                    a22 = Convert.ToDouble(Console.ReadLine());
                    return a22;
                case "b1":
                    b1 = Convert.ToDouble(Console.ReadLine());
                    return b1;
                case "b2":
                    b2 = Convert.ToDouble(Console.ReadLine());
                    return b2;
                default:
                    throw new Exception("Может введете верные аргументы уравнения?");
            }
        }

        public void Cramer()
        {
            double delta0 = a11 * a22 - a12 * a21;
            if (delta0 == 0)
            {
                throw new Exception("Система не имеет единственного решения.");
            }

            double delta1 = b1 * a22 - b2 * a12;
            double delta2 = a11 * b2 - a21 * b1;
            double x = delta1 / delta0;
            double y = delta2 / delta0;

            Console.WriteLine($"Уравнение решено: X = {x}, Y = {y}");
        }

    }
}
