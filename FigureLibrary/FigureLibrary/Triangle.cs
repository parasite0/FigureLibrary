using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    // Класс Triangle является производным классом от базового класса Figure
    public class Triangle : Figure
    {
        // Конструктор
        public Triangle(double newSide1, double newSide2, double newSide3)
        {
            side1 = newSide1;
            side2 = newSide2;
            side3 = newSide3;
        }

        // Вычисление площади треугольника
        public override double GetSquare()
        {
            // Проверка на неотрицательные стороны треугольника
            if ((side1 < 0) || (side2 < 0) || (side3 < 0))
            {
                Exception ex = new ArgumentException("Стороны треугольника должны быть положительными числами");
                Console.WriteLine(ex.Message);
                throw ex;
            }

            double semiPerimetr = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - side1) * (semiPerimetr - side2) * (semiPerimetr - side3));
        }

        // Проверка на прямоугольный треугольник
        public string RightTriangle()
        {
            // Проверка на неотрицательные стороны треугольника
            if ((side1 < 0) || (side2 < 0) || (side3 < 0))
            {
                Exception ex = new ArgumentException("Стороны треугольника должны быть положительными числами");
                Console.WriteLine(ex.Message);
                throw ex;
            }

            double[] array = { side1, side2, side3 };
            Array.Sort(array);
            string rightTriangle = array[2] * array[2] == array[0] * array[0] + array[1] * array[1] ? "Треугольник прямоугольный" : "Треугольник не прямоугольный";
            return rightTriangle;
        }
    }
}