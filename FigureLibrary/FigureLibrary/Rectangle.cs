using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    // Класс Rectangle является производным классом от базового класса Figure
    public class Rectangle : Figure
    {
        // Конструктор
        public Rectangle(double newHeight, double newWidth)
        {
            height = newHeight;
            width = newWidth;
        }

        // Вычисление площади прямоугольника
        public override double GetSquare()
        {
            // Проверка на неотрицательные стороны прямоугольника
            if ((height < 0) || (width < 0))
            {
                Exception ex = new ArgumentException("Стороны прямоугольника должны быть положительными числами");
                Console.WriteLine(ex.Message);
                throw ex;
            }

            return height * width;
        }
    }
}