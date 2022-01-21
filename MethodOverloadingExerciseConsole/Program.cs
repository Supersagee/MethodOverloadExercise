using System;

namespace MethodOverloadingExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dec1 = 133.7m;
            decimal dec2 = 286.99m;
            
            var num1 = 6;
            var num2 = 9;
            bool haveMoney = true;

            var methodOne = Add(num1, num2);

            var methodTwo = Add(dec1, dec2);

            var methodThree = Add(num1, num2, haveMoney);

            Console.WriteLine(methodOne);
            Console.WriteLine(methodTwo);
            Console.WriteLine(methodThree);

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isMoney)
        {
            var sum = num1 + num2;

            if (isMoney == true && sum == 1 || isMoney == true && sum == -1)
            {
                return $"You have {sum} dollar";
            }
            else if (isMoney == true)
            {
                return $"You have {sum} dollars";
            }
            else
            {
                return $"Your total is {sum.ToString()}";
            }
        }
    }
}
