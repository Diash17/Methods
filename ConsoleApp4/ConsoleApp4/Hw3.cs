using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Homework3
    {
        public static double Exponentiate(double a, double b)
        {
            double result = Math.Pow(a, b);
            return result;
        }

        public static int FindNumberOfPositiveIntegers(int inputA)
        {

            int result = 0;
            for (int x = 1; (x * x) < inputA; ++x)
            {
                result += 1;
            }

            return result;

        }

        public static int FindLargerDivision(int inputA)
        {
            int a = 0;
            int result = a;
            for (a = (inputA - 1); a > 0; a--)
            {
                int reminder = (inputA % a);
                if (reminder == 0)
                {
                    result = a;
                    break;

                }
            }
            return result;
        }

        public static int FindSumOfNumbersDivisionOnSeven(int a, int b)
        {
            int sum = 0;
            while (a != b)
            {
                a++;
                if (a % 7 == 0)
                {
                    sum += a;
                }
            }
            return sum;
        }

        public static int FindNNubberOfFibonacci(int N)
        {
            int tmp1 = 1;
            int tmp2 = 1;
            int result = 0;
            if (N <= 0)
            {
                throw new Exception("Can not be less that zero ");
            }
            for (int i = 3; i <= 0; i++)
            {
                result = tmp1 + tmp2;
                tmp1 = tmp2;
                tmp2 = result;
            }
            return result;
        }

        public static int FindTheLargeDivisionWithEfklidMethod(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        public static int FindTheLargeDivisionWithEfklidMethod(int input)
        {
            int N = 0;
            int a = 0;
            int b = input;

            do
            {
                N = (a + b) / 2;
                if (Math.Pow(N, 3) > input)
                {
                    b = N;
                }
                else
                {
                    a = N;
                }
            } while (Math.Pow(N, 3) != input);

            return N;
        }

        public static int FindNumberOfOdd(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                int tmp = a % 10;
                a /= 10;

                int remainder = tmp % 2;
                if (remainder != 0)
                {
                    ++sum;
                }
            }
            return sum;
        }

        public static string CheckIfNubmersAreSimilar(int input1, int input2)
        {
            int copy2 = input2;
            string result = "";
            while (input1 > 0)
            {
                int digit1 = input1 % 10;
                input1 /= 10;

                while (copy2 > 0)
                {
                    int demaind2 = copy2 % 10;
                    copy2 /= 10;
                    if (digit1 == demaind2)
                    {
                        result = "Yes";
                    }
                    else
                    {
                        result = "No";
                    }
                }
            }
            return result;
        }

        public static string CheckIfSimilarDigits(int input1, int input2)
        {
            int copy2 = input2;
           
            while (input1 > 0)
            {
                int digit1 = input1 % 10;
                input1 /= 10;
                while (copy2 > 0)
                {
                    int demaind2 = copy2 % 10;
                    copy2 /= 10;
                    if (digit1 == demaind2)
                    {
                        return "Yes";
                    }
                }
            }
            return "No";
        }
    }
}