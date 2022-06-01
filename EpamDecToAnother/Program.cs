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
            string result = "";
            string innerSymbol = "";
            string innerResult = "";
            int tempNum1 = 0;
            int oborot = 0;

            Console.Write("Введите десятичное число для преобразования, нажмите Enter: ");
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

            if (cleanNum1 >= cleanNum2) // Проверяем нужно ли преобразование в новую систему
            {
                oborot = cleanNum1;
                tempNum1 = cleanNum1;
                while (oborot >= cleanNum2)
                {
                    
                    if (oborot >= cleanNum2)
                    {
                        oborot = oborot / cleanNum2;
                        innerSymbol += tempNum1 - (oborot * cleanNum2);
                        innerResult = innerSymbol + innerResult;
                        tempNum1 = oborot;
                        
                        if (cleanNum2 > oborot)
                        {
                            result = oborot + innerResult;
                            innerSymbol = "";
                        }
                        else
                        {
                            result = innerResult;
                            innerSymbol = "";
                        }
                    }
                }
            }
            else { result += cleanNum1; } //Если преобразование не нужно. Так как Число для преобразования меньше чем основание новой системы

            Console.WriteLine("________________________");
            Console.WriteLine("Итог преобразования {0}", result);

            
        }
    }
}
