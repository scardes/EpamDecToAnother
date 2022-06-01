using System;

namespace EpamDecToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразование DEC числа, на число с основаним новой системы счисления (от 2 до 20)");
            
            bool endApp = false;
            while (!endApp) //Повторять программу пока не получим ключ "n"
            {
                string numInput1 = "";
                string numInput2 = "";
                string result = "";
                string innerSymbol = "";
                int tempNum1 = 0;
                int oborot = 0;

                Console.Write("Введите десятичное число для преобразования, нажмите Enter: ");
                numInput1 = Console.ReadLine();

                int cleanNum1 = 0;
                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Введите правильное десятичное число для преобразования, нажмите Enter: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Введите основание новой системы от 2 до 20, нажмите Enter: ");
                numInput2 = Console.ReadLine();

                int cleanNum2 = 0;
                while (!int.TryParse(numInput2, out cleanNum2))  //Проверка вводят число или нет
                {
                    Console.Write("Введите корректное основание новой системы от 2 до 20, нажмите Enter: ");
                    numInput2 = Console.ReadLine();
                }

                while((cleanNum2 <=1) || (cleanNum2 > 20) ) // Проверка чтобы основание было в пределах нужных нам 
                {
                    Console.Write("Основание новой системы должно быть от [2 до 20] : ");
                    numInput2 = Console.ReadLine();

                    while (!int.TryParse(numInput2, out cleanNum2)) //Проверка вводят число или нет (простите что второй раз), но пока не знаю как это обойти
                    {
                        Console.Write("Введите корректное основание новой системы от 2 до 20, нажмите Enter: ");
                        numInput2 = Console.ReadLine();
                    }
                }

                if (cleanNum1 >= cleanNum2) // Проверяем нужно ли преобразование в новую систему
                {
                    oborot = cleanNum1;
                    tempNum1 = cleanNum1; // tempNum1 - ввел чтобы не мешал основному значению cleanNum1 (который нельзя менять, потому что проверяем с cleanNum2 в начале входа в условие
                    
                    while (oborot >= cleanNum2) // Начинаем преобразование
                    {
                        oborot = oborot / cleanNum2; 
                        innerSymbol += tempNum1 - (oborot * cleanNum2); // Находим символ -> это остаток от деления на cleanNum2 например: 5 - (2 * 2) = 1 (результат и есть это символ)

                        switch (innerSymbol) // Если символ больше 10 переходим на буквы от a до j
                        {
                            case "10": 
                                innerSymbol = "a";
                                break;
                            case "11":
                                innerSymbol = "b";
                                break;
                            case "12":
                                innerSymbol = "c";
                                break;
                            case "13":
                                innerSymbol = "d";
                                break;
                            case "14":
                                innerSymbol = "e";
                                break;
                            case "15":
                                innerSymbol = "f";
                                break;
                            case "16":
                                innerSymbol = "g";
                                break;
                            case "17":
                                innerSymbol = "h";
                                break;
                            case "18":
                                innerSymbol = "i";
                                break;
                            case "19":
                                innerSymbol = "j";
                                break;
                        }

                        result = innerSymbol + result; // Записываем символ в конец строки временного результата
                        innerSymbol = ""; // После записи обнуляем временный сборщик символов
                        tempNum1 = oborot;

                        if (cleanNum2 > oborot) //Когда все обороты завершены записывам значение в Результат
                        {
                            result = oborot + result; // Это конечный результат
                        }
                    }
                }
                else { result += cleanNum1; } //Если преобразование не нужно. Так как Число для преобразования меньше чем основание новой системы

                Console.WriteLine("------------------------\n");
                Console.WriteLine("Итог преобразования {0}", result);
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Нажмите 'n' и Enter чтобы выйти из программы, или введите любое значение и Enter для продолжения работы с программой: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;
        }
    }
}
