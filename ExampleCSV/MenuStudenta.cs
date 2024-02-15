using System;
namespace ExampleCSV
{
	internal class MenuStudenta
	{
        public static void MenuGlowneStudenta(string ImiePodane, string HasloPodane)
        {
            string PlikPrzerwy = "Przerwy.csv";
            Console.Clear();
            Console.WriteLine("--- Wybierz co chcesz zrobić: ---");
            Console.WriteLine("1. Dane osobowe");
            Console.WriteLine("2. Przerwy");
            Console.WriteLine("3. Uwagi");
            Console.WriteLine("4. Oceny");
            Console.WriteLine("5. Wyloguj się");
            Console.Write("Wybierz opcję: ");
            int choice = int.Parse(Console.ReadLine());

            // Przetwórz wybór
            switch (choice)
            {
                case 1:
                    // Obsługa opcji 1 - dane osobowe
                    Console.Clear();
                    Console.WriteLine($"Imię: {ImiePodane}");
         
                    Wyswietlanie.WyswietlanieDanychOsobowych(ImiePodane, "Studenci.csv", HasloPodane);
                    break;
                case 2:
                    // Obsługa opcji 2 - przerwy
                    Wyswietlanie.WyswietleniePrzerw(PlikPrzerwy);
                    break;
                case 3:
                    // Obsługa opcji 3 - uwagi
                    Wyswietlanie.WyswietlanieUwag("Uwagi.csv", ImiePodane, "Studenci.csv", HasloPodane);
                    break;
                case 4:
                    // Obsługa opcji 4 - oceny
                    Console.Clear();
                    Console.WriteLine("Podaj przedmiot: \n" +
                        "(Dostępne: Matematyka , Informatyka , Programowanie , Fizyka, Grafika)");
                    string WybranyKurs = Console.ReadLine();
                    Wyswietlanie.WyswietlanieOcen("Oceny.csv", ImiePodane, "Studenci.csv", HasloPodane, WybranyKurs);
                    break;
                case 5:
                    // Obsługa opcji 6 - wylogowanie
                    Console.Clear();

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");

                    break;
            }
        }
    }
}

