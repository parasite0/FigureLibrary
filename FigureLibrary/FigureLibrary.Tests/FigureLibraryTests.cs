using FigureLibrary;
using Xunit;
using System;

namespace FigureLibrary.Tests
{
    public class FigureLibraryTests
    {
        //Тест, который проверяет правильность вычисления площади круга
        [Fact]
        public void CircleSquare()
        {
            Circle circle = new Circle(5);

            double sqrt = circle.GetSquare();

            Assert.Equal(78.53981633974483, sqrt);
        }

        //Тест, который проверяет правильность вычисления площади треугольника
        [Fact]
        public void TriangleSquare()
        {
            Triangle triangle = new Triangle(3, 5, 7);

            double sqrt = triangle.GetSquare();

            Assert.Equal(6.49519052838329, sqrt);
        }

        //Тест, который проверяет правильность вычисления площади прямоугольника
        [Fact]
        public void RectangleSquare()
        {
            Rectangle rectangle = new Rectangle(5, 7);

            double sqrt = rectangle.GetSquare();

            Assert.Equal(35, sqrt);
        }

        //Тест, который проверяет правильность проверки на прямоугольный треугольник
        [Fact]
        public void RightTriangleTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            string str = triangle.RightTriangle();

            Assert.Equal("Треугольник прямоугольный", str);
        }

        //Тест, который проверяет правильность проверки на прямоугольный треугольник
        [Fact]
        public void RightTriangleFalse()
        {
            Triangle triangle = new Triangle(3, 6, 9);

            string str = triangle.RightTriangle();

            Assert.Equal("Треугольник не прямоугольный", str);
        }
    }
}