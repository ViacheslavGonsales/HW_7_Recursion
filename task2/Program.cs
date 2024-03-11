//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

namespace Tasks
{
    static class Program
    {
        public static void Main (string [] args)
        {
            System.Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
            System.Console.WriteLine("Даны два неотрицательных числа m и n.");
            string firstText = "Введите значение m => ";
            System.Console.Write(firstText);
            int firstNumber = NumberInTerminal(0xFFFFFF,firstText,0);
            string secondText ="Введите значение n => ";
            System.Console.Write(secondText);
            int secondNumber = NumberInTerminal(0xFFFFFF,secondText,0);
            System.Console.WriteLine($"Значение по фукнкции Аккермана ({firstNumber},{secondNumber}) = {Ack(firstNumber,secondNumber)}");
        }

        public static int NumberInTerminal(int numberDigits, string repeatString, int minValueSet)
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString,out numInt)) 
                    || !(numInt >= minValueSet) 
                    || !(numInt <= numberDigits)
                  )
            {
                System.Console.WriteLine("Ошибка ввода, повторите");
                System.Console.Write(repeatString);
                numString = Console.ReadLine(); 
            }
            return numInt;
        }

        public static int Ack(int m, int n)
        {
            if (m == 0) 
            {
                return n + 1;
            }
            else
            {
                if (n == 0) 
                {
                    return Ack(m - 1, 1);
                }
                else
                {
                    return Ack(m - 1, Ack(m, n - 1));
                } 
            }
        }
    }
}
