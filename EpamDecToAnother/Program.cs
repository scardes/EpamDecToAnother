using System;

namespace EpamDecToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразование DEC числа, на число с основаним новой системы счисления (от 2 до 20)");

            string numInput1 = "";
            string numInput2 = "";
            int result = 0;

            Console.WriteLine("Введите десятичное число для преобразования, нажмите Enter: ");
            numInput1 = Console.ReadLine();

            int cleanNum1 = 0;
            while (!int.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Введите десятичное число для преобразования, нажмите Enter: ");
                numInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.Write("Введите основание новой системы, нажмите Enter: ");
            numInput2 = Console.ReadLine();

            int cleanNum2 = 0;
            while (!int.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Введите корректное основание новой системы, нажмите Enter: ");
                numInput2 = Console.ReadLine();
            }

            //Пока что просто заглушка
            Console.WriteLine("Число {0}, Основание для преобразования {1}", cleanNum1, cleanNum2);

        }
    }
}
