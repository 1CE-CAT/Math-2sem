using System;
using System.Numerics;
using System.Globalization;

namespace Matan
{
    public class MatrixCramer
    {
        public Complex a11, a12, a21, a22, b1, b2;

        public Complex Rations()
        {
            Console.Write("Введите коэффициент (a11, a12, a21, a22, b1, b2): ");
            string coef = Console.ReadLine();
            Console.Write("Введите значение для " + coef + " (можно вводить как вещественные, так и комплексные числа в формате x+yi): ");
            
            string input = Console.ReadLine();
            Complex value = ParseComplex(input);
            
            switch (coef)
            {
                case "a11":
                    a11 = value;
                    return a11;
                case "a12":
                    a12 = value;
                    return a12;
                case "a21":
                    a21 = value;
                    return a21;
                case "a22":
                    a22 = value;
                    return a22;
                case "b1":
                    b1 = value;
                    return b1;
                case "b2":
                    b2 = value;
                    return b2;
                default:
                    throw new Exception("Может введете верные аргументы уравнения?");
            }
        }

        public void Cramer()
        {
            Complex delta0 = a11 * a22 - a12 * a21;
            if (delta0 == Complex.Zero)
            {
                throw new Exception("Система не имеет единственного решения");
            }

            Complex delta1 = b1 * a22 - b2 * a12;
            Complex delta2 = a11 * b2 - a21 * b1;
            Complex x = delta1 / delta0;
            Complex y = delta2 / delta0;

            Console.WriteLine($"Уравнение решено: X = {x}, Y = {y}");
        }

        private static Complex ParseComplex(string input)
        {
            input = input.Replace(" ", "").Replace("i", "j");
            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double real))
            {
                return new Complex(real, 0);
            }
            
            try
            {
                return Complex.Parse(input, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                throw new Exception("Некорректный формат ввода комплексного числа. Используйте формат x+yi");
            }
        }

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
