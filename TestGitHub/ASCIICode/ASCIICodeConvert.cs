using System;


namespace ASCIICode
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = int.Parse(Console.ReadLine());

            var allText = string.Empty;

            for (int i = 0; i < lineNumber; i++)
            {
                int asciiCode = int.Parse(Console.ReadLine());
                var toChar = (char)asciiCode;
                allText += toChar;
            }

            Console.WriteLine(allText);
        }
    }
}
