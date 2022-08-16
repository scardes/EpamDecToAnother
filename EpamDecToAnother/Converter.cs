using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Take a DEC number(cleanNum1) and return a result in a new base (cleanNum2) system
/// </summary>
namespace EpamDecToAnother
{
    public class Converter
    {
        public string ConvertDecTo (int cleanNumOrigin, int cleanNumBase)
        {
            string result = "";
            string innerSymbol = "";
            int tempNumOrigin; 
            int turnover;

            // If we need made a convertation 
            if (cleanNumOrigin >= cleanNumBase) 
            {
                // Make dublicate of cleanNum1 (because we are not allowed to change (cleanNum1) which is compared with (cleanNum2))
                tempNumOrigin = cleanNumOrigin; 
                turnover = cleanNumOrigin;

                // Start converting
                while (turnover >= cleanNumBase)
                {
                    turnover = turnover / cleanNumBase;

                    // Find a innerSymbol - this is the remainder of cleanNum2 
                    // For example: cleanNum1 = 5; cleanNum2 = 2; (turnover = 5/2 = 2). Then innerSymbol = 5 - (2 * 2) = 1 
                    innerSymbol += tempNumOrigin - (turnover * cleanNumBase);

                    // If innerSymbol => 10. We need use a letters from a to j
                    switch (innerSymbol) 
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

                    // Write the innerSymbol at the end of the temporary result. And reset innerSymbol
                    result = innerSymbol + result; 
                    innerSymbol = ""; 
                    tempNumOrigin = turnover;

                    // When all turnovers are complete write the value to the (result)
                    if (cleanNumBase > turnover) 
                    {
                        result = turnover + result;
                    }
                }
            }

            //If we DON`T need convertation (Cause DEC number smaller then Base of new system)
            else 
            { 
                result += cleanNumOrigin; 
            } 

            return result;
        }
    }
}