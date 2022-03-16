using NUnit.Framework;
using Hw3;
using System;


namespace Hw5.Tests
{
    public class Hw3Tests
    {
        [TestCase(1, 1, 1)]
        [TestCase(9, 2, 81)]
        [TestCase(6, 5, 7776)]

        public void ExponentiateTest(int a, int b, int expected)
        {
            int actual = Homework3.Exponentiate(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -2)]
        [TestCase(0, -2)]
        [TestCase(-2, -2)]
        public void ExponentiateTest_WhenBIsLessThanZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<Exception>(() => Homework3.Exponentiate(a, b));
        }

        //2
        [TestCase(167, 12)]
        [TestCase(0, 0)]
        [TestCase(12, 3)]
        [TestCase(-10, 0)]
        [TestCase(-6, 0)]

        public void FindNumberOfPositiveIntegersTest(int inputA, int expected)
        {
            int actual = Homework3.FindNumberOfPositiveIntegers(inputA);

            Assert.AreEqual(expected, actual);
        }





        //4
        [TestCase(15, 5)]
        [TestCase(61, 1)]
        [TestCase(67, 1)]
        [TestCase(122, 61)]
        [TestCase(121, 11)]
        public void GreatestDivisorTest(int inputA, int expected)
        {
            int actual = Homework3.GreatestDivisor(inputA);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void GreatestDivisorTest_WhenInputAOrDivisoAreZero_ShouldThrowException(int inputA)
        {
            Assert.Throws<Exception>(() => Homework3.GreatestDivisor(inputA));
        }

        //5
        [TestCase(0, 10, 7)]
        [TestCase(-7, 7, 0)]
        [TestCase(-7, 0, -7)]
        [TestCase(7, 0, 7)]
        [TestCase(-21, 14, -21)]
        [TestCase(21, -7, 35)]

        public void FindSumOfNumbersDivisionOnSevenTest(int a, int b, int expected)
        {
            int actual = Homework3.FindSumOfNumbersDivisionOnSeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        //6
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]

        public void FindNNubberOfFibonacciTest(int N, int expected)
        {
            int actual = Homework3.FindNNubberOfFibonacci(N);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FindNNubberOfFibonacciTest_WhenNEqualOrLessThanZero_ShouldThrowException(int inputA)
        {
            Assert.Throws<Exception>(() => Homework3.FindNNubberOfFibonacci(inputA));
        }

        //7
        [TestCase(4, 2, 2)]
        [TestCase(5, 25,5)]
        [TestCase(67, 19,1)]

        public void FindTheLargeDivisionWithEfklidMethodTest(int a, int b, int expected)
        {
            int actual = Homework3.FindTheLargeDivisionWithEfklidMethod(a, b);

            Assert.AreEqual(expected, actual);

        }

        //8
        [TestCase(8,2)]
        [TestCase(27,3)]
        [TestCase(64,4)]

        public void GetNumByHalfDevisionMethodTest(int input, int expected)
        {
            int actual = Homework3.GetNumByHalfDevisionMethod(input);
            Assert.AreEqual(expected, actual);

        }

        //9
        [TestCase(8, 0)]
        [TestCase(247, 1)]
        [TestCase(61114, 3)]
        public void FindNumberOfOddTest(int a, int expected)
        {
            int actual = Homework3.FindNumberOfOdd(a);
            Assert.AreEqual(expected, actual);

        }
        //10
        [TestCase(80, 08)]
        [TestCase(247, 742)]
        [TestCase(000, 000)]
        [TestCase(111, 111)]
        public void GetReverseOfNumber(int input, int expected)
        {
            int actual = Homework3.GetReverseOfNumber(input);
            Assert.AreEqual(expected, actual);

        }

        //12
        [TestCase(8,28,true)]
        [TestCase(6,286, true)]
        [TestCase(8,20,false)]
        [TestCase(9,3,false)]
        [TestCase(80,882, true)]
        [TestCase(7324,76325, true)]
        
        public void CheckIfNumbersAreSimilarTest(int input1, int input2, bool expected)
        {
            bool actual = Homework3.CheckIfNumbersAreSimilar(input1, input2);
            Assert.AreEqual(expected, actual);

        }

    }
} 