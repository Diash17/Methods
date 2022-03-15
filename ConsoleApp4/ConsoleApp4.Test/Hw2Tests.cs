using NUnit.Framework;
using Hw2;
using System;
using ConsoleApp4;

namespace Hw5.Tests
{
    public class Hw2Tests
    {
        [TestCase(4, 5, -1)]
        [TestCase(5, 4, 9)]
        [TestCase(5, 5, 25)]

        public void DoMathOperations(int a, int b, ConsoleApp4.Quarters expected)
        {
            Quarters actual = (Quarters)Homework2.DoMathOperations(a, b);

            Assert.AreEqual(expected, actual);
        }
        //2
        public void DefineQuarterOfCircle(double x, double y, string expected)
        {

        }

    }
}