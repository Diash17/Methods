using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public static class Homework2
    {
        public static int DoMathOperations(int A, int B)
        {
            int result = 0;

            if (A > B)
            {
                result = (A + B);
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }
            return result;
        }

        public static int DefineQuarterOfCircle(double x, double y)
        {
            int result;
            if ((x > 0) && (y > 0))
            {
                result = 1;
            }
            else if ((x < 0) && (y > 0))
            {
                result = 2;
            }
            else if ((x < 0) && (y < 0))
            {
                result = 3;
            }
            else if ((x > 0) && (y < 0))
            {
                result = 4;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public static string CreateNumberToWords(int userNumber)
        {
            int first = (userNumber / 10);
            int second = (userNumber % 10);
            string decade = "";
            string unit = "";
            string result = "";

            if (userNumber < 10 || userNumber > 99)
            {
                throw new Exception("Write two-digit number");
            }

            if (userNumber > 19)
            {

                if (first == 1)
                {
                    decade = "ten";
                }
                else if (first == 2)
                {
                    decade = "twenty";
                }
                else if (first == 3)
                {
                    decade = "thirty";
                }
                else if (first == 4)
                {
                    decade = "fourty";
                }
                else if (first == 5)
                {
                    decade = "fifty";
                }
                else if (first == 6)
                {
                    decade = "sixty";
                }
                else if (first == 7)
                {
                    decade = "seventy";
                }
                else if (first == 8)
                {
                    decade = "eighty";
                }
                else if (first == 9)
                {
                    decade = "ninety";
                }


                 if (second == 0)
                {
                    unit =null;
                }
                else if (second == 1)
                {
                    unit = "one";
                }
                else if (second == 2)
                {
                    unit = "two";
                }
                else if (second == 3)
                {
                    unit = "three";
                }
                else if (second == 4)
                {
                    unit = "four";
                }
                else if (second == 5)
                {
                    unit = "five";
                }
                else if (second == 6)
                {
                    unit = "six";
                }
                else if (second == 7)
                {
                    unit = "seven";
                }
                else if (second == 8)
                {
                    unit = "eight";
                }
                else
                {
                    unit = "nine";
                }
                result = ($"{decade} {unit}");
                return result;
            }
            else
            {
                if ((userNumber / 1 == 19))
                {
                    result = ("nineteen");
                }

                if ((userNumber / 1 == 18))
                {
                    result = ("eighteen");
                }

                if ((userNumber / 1 == 17))
                {
                    result = ("seventeen");
                }

                if ((userNumber / 1 == 16))
                {
                    result = ("sixteen");
                }

                if ((userNumber / 1 == 15))
                {
                    result = ("fifteen");
                }

                if ((userNumber / 1 == 14))
                {
                    result = ("fourteen");
                }

                if ((userNumber / 1 == 13))
                {
                    result = ("thirteen");
                }

                if ((userNumber / 1 == 12))
                {
                    result = ("twelve");
                }

                if ((userNumber / 1 == 11))
                {
                    result = ("eleven");
                }
                return result;
            }
        }

    }
}
