using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    public static class Homework3
    {
        public static int Exponentiate(int a, int b)
        {
            if (b < 0)
            {
                throw new Exception("b can't be zero");
            }

            int tmp = 1;
            int result = 1;

            while (tmp <= b)
            {
                result *= a;
                tmp++;
            }
            return result;
        }

        public static int FindNumberOfPositiveIntegers(int inputA)
        {
            int result = 0;
            if (inputA > 0)
            {
                for (int x = 1; (x * x) < (inputA); x++)
                {
                    result++;
                }
            }

            return result;
        }

        public static int GreatestDivisor(int inputA)
        {
            int divisor = Math.Abs(inputA) - 1;
            if (divisor == 0 || inputA == 0)
            {
                throw new Exception("can't be zero");
            }

            while (Math.Abs(inputA) % divisor != 0)
            {
                divisor--;
            }

            return divisor;
        }

        public static int FindSumOfNumbersDivisionOnSeven(int a, int b)
        {
            int sum = 0;
            if (b < a)
            {
                int tmp = b;
                b = a;
                a = tmp;
            }
            while (a <= b)
            {
                if (a % 7 == 0)
                {
                    sum += a;
                }
                a++;
            }
            return sum;
        }

        public static int FindNNubberOfFibonacci(int N)
        {
            int tmp0 = 0;
            int tmp1 = 1;
            int result = 0;
            if (N <= 0)
            {
                throw new Exception("Can not be less than zero or be equal zero ");
            }
            if (N <= 2)
            {
                return 1;
            }
            for (int i = 2; i <= N; i++)
            {
                result = tmp0 + tmp1;
                tmp0 = tmp1;
                tmp1 = result;
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

        public static int GetNumByHalfDevisionMethod(int input)
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

        public static int GetReverseOfNumber(int input)
        {
            int result = 0;

            while (input != 0)
            {
                result *= 10;
                result += input % 10;
                input /= 10;
            }

            return result;
        }

        public static bool CheckIfNumbersAreSimilar(int input1, int input2)
        {
            bool result = false;
            int copy2 = input2;

            while (input1 > 0)
            {
                int demaind1 = input1 % 10;

                while (copy2 != 0)
                {
                    int demaind2 = copy2 % 10;

                    if (demaind1 == demaind2)
                    {
                        result = true;
                        break;
                    }
                    copy2 /= 10;
                    input1 /= 10;
                }
            }
            return result;
        }



    }
}