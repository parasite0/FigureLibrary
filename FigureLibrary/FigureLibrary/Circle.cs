using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    // Класс Circle является производным классом от базового класса Figure
    public class Circle : Figure
    {
        // Конструктор
        public Circle(double newRadius)
        {
            radius = newRadius;
        }

        // Вычисление площади круга
        public override double GetSquare()
        {
            // Проверка на неотрицательный радиус
            if (radius < 0)
            {
                Exception ex = new ArgumentException("Радиус должен быть положительным числом");
                Console.WriteLine(ex.Message);
                throw ex;
            }

            return Math.PI * radius * radius;
        }
    }
}