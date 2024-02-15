using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSV
{
    internal class UkrywanieHasla
    {
        public static string GetHiddenInput(char maskChar)
        {
            string input = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Jeśli wpisano znak inny niż Enter, dodaj go do wprowadzonych danych
                if (key.Key != ConsoleKey.Enter)
                {
                    input += key.KeyChar;
                    Console.Write(maskChar); // Wyświetl maskujący znak na ekranie
                }
            } while (key.Key != ConsoleKey.Enter);

            return input;
        }
    }
}
