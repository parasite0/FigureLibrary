using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    // Базовый класс
    public abstract class Figure
    {
        public double width { get; set; }
        public double height { get; set; }
        public double radius { get; set; }
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        // Метод, вычисляющий площадь фигуры
        public abstract double GetSquare();
    }
}