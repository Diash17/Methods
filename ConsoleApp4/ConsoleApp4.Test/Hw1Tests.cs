using NUnit.Framework;
using Hw1;
using System;

namespace Hw5.Tests
{
    public class Hw1Tests
    {
        [TestCase(1, 5, 7.5)]
        [TestCase(1, 2, 9)]
        [TestCase(6, 5, -55)]
        public void GetTheResultOfEquationtTest(double a, double b, double expected)
        {
            double actual = Homework1.GetTheResultOfEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(-10, -10)]
        [TestCase(5, 5)]
        public void GetTheResultOfEquationtTest_WhenAIsEqualB_ShouldThrowExeption(double a, double b)
        {
            Assert.Throws<Exception>(() => Homework1.GetTheResultOfEquation(a, b));
        }

        //Second
        [TestCase(1, 3, 2, 4, "y = 1x+(-2)")]
        [TestCase(2, 3, 3, 2, "y = -1x+(-5)")]
        public void GetEquationOfTheLineIn4Points(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Homework1.GetEquationOfTheLineIn4Points(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 0, 5)]
        [TestCase(-10, 3, -10, 3)]
        [TestCase(5, 5, 5, 3)]
        public void GetEquationOfTheLineIn4Points_WhenX1IsEqualX2_ShouldThrowExeption(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<Exception>(() => Homework1.GetEquationOfTheLineIn4Points(x1, y1, x2, y2));
        }

        //Third
        public void GetTheResultOfLinearEquation(int a, int b, int c, double expected)
        {
            double actual = Homework1.GetTheResultOfLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 3)]
        public void GetTheResultOfLinearEquation_WhenAIsZero_ShouldThrowExeption(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Homework1.GetTheResultOfLinearEquation(a, b, c));
        }

        [TestCase(2, 0, 5)]
        public void GetTheResultOfLinearEquation_WhenBIsZero_ShouldThrowExeption(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Homework1.GetTheResultOfLinearEquation(a, b, c));
        }

        [TestCase(2, 4, 0)]
        public void GetTheResultOfLinearEquation_WhenCIsZero_ShouldThrowExeption(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Homework1.GetTheResultOfLinearEquation(a, b, c));
        }
    }
}