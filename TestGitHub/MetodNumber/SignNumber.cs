using System;


namespace SignNumber
{
    class SignNumber
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var intType = TypeCheck(number);
            PrintSign(intType);
        }

        static string TypeCheck(int number)
        {
            var type = string.Empty;
            if (number < 0)
            {
                type =  "negative";
            }
            else if (number == 0)
            {
                type = "zero";
            }
            else if (number > 0)
            {
                type = "positive";
            }

            return type;
        }

        static void PrintSign(string intType)
        {
            Console.WriteLine($"The number 2 is {intType}.");
        }
    }
}
