using System;

namespace Frolov_OOP_2_2
{
    class StringIsNotDigit : Exception
    {
        public StringIsNotDigit() { }
        public StringIsNotDigit(string msg) : base(msg) { }
        public StringIsNotDigit(string msg, Exception inner) : base(msg, inner) { }
    }

    class InitializationError
    {
        Exception exception;

        public InitializationError(string str)
        {
            int a;
            double b;

            bool flagInt = Int32.TryParse(str, out a);
            bool flagDouble = Double.TryParse(str, out b);

            if (flagInt)
            {
                Console.WriteLine($"Число целое: {str}");
            }
            if (flagDouble)
            {
                Console.WriteLine($"Число дробное: {str}");
            }
            else
            {
                throw new ArgumentException("Строка не является числовым форматом", exception);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "fwe2";
            string str2 = "2321";
            string str3 = "1,5";

            try
            {
                InitializationError error = new InitializationError(str1);
            }
            catch (StringIsNotDigit se)
            {
                Console.WriteLine(se.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}