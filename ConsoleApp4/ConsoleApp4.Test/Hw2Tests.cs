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

        public void DoMathOperationsTest(int a, int b, int expected)
        {
            int actual = Homework2.DoMathOperations(a, b);

            Assert.AreEqual(expected, actual);
        }
        //2
        [TestCase(0, 2, Quarters.OnTheAxis)]
        [TestCase(1, 2, Quarters.I)]
        [TestCase(-1, 2, Quarters.II)]
        [TestCase(-1, -1, Quarters.III)]
        [TestCase(2, -1, Quarters.IV)]
        public void DefineQuarterOfCircleTest(double x, double y, Quarters expected)
        {
            Quarters actual = (Quarters)Homework2.DefineQuarterOfCircle(x, y);

            Assert.AreEqual(expected, actual);
        }
        //3
        [TestCase(20, "twenty ")]
        [TestCase(30, "thirty ")]
        [TestCase(12, "twelve")]
        [TestCase(46, "fourty six")]
        [TestCase(25, "twenty five")]
        [TestCase(40, "fourty ")]
       
        public void CreateNumberToWordsTest(int userNumber, string expected)
        {
            string actual = Homework2.CreateNumberToWords(userNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(300)]
        [TestCase(0)]
        [TestCase(1)]
        
        public void CreateNumberToWordsTest_WhenIsNotTwoDigit_ShouldThrowExeptionint (int userNumber)
        {
            Assert.Throws<Exception>(() => Homework2.CreateNumberToWords(userNumber));
        }
    }
}