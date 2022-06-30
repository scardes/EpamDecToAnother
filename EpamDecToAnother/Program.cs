using System;

namespace EpamDecToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            int cleanNum1;
            int cleanNum2;
            string numInput1;
            string numInput2;

            bool endApp = false;

            // Repeat program, until input key "n" to exit.
            while (!endApp) 
            {
                Console.WriteLine("Convert the DEC number to the number with the base of the new number system (from 2 to 20)\n");

                // Ask the user to type the DEC number.
                Console.Write("Enter a DEC number for converting: ");
                numInput1 = Console.ReadLine();

                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Please enter correct a DEC number for converting: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the base of the new number system.
                Console.Write("Enter base of the new number system (from 2 to 20): ");
                numInput2 = Console.ReadLine();
                
                while (!int.TryParse(numInput2, out cleanNum2))  //Проверка вводят число или нет
                {
                    Console.Write("Please enter correct base of the new number system (from 2 to 20): ");
                    numInput2 = Console.ReadLine();
                }


                while ((cleanNum2 <= 1) || (cleanNum2 > 20)) // Проверка чтобы основание было в пределах нужных нам 
                {
                    Console.Write("Please enter correct base of the new number system. Range need be in [2 - 20] : ");
                    numInput2 = Console.ReadLine();

                    while (!int.TryParse(numInput2, out cleanNum2)) //Проверка вводят число или нет (простите что второй раз), но пока не знаю как это обойти
                    {
                        Console.Write("Please enter correct base of the new number system (from 2 to 20): ");
                        numInput2 = Console.ReadLine();
                    }
                }

                Converter converter = new Converter();
                string result = converter.ConvertDecTo(cleanNum1, cleanNum2);

                Console.WriteLine("\nИтог преобразования {0}", result);
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing
            }
        }
    }
}
