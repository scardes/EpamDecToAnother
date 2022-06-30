using System;
using System.Collections.Generic;
using System.Text;

namespace EpamDecToAnother
{
    class Converter
    {
        public string ConvertDecTo (int cleanNum1, int cleanNum2)
        {
            string result = "";
            string innerSymbol = "";
            int tempNum1;
            int oborot;

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

            return result;
        }
    }
}
