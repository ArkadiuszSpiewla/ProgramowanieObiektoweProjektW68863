using System;
namespace ExampleCSV
{
	internal class MenuNauczyciela
	{
        public static void MenuGlowneNauczyciela(string ImiePodane, string HasloPodane)
        {
            string PlikPrzerwy = "Przerwy.csv";
            Console.Clear();
            Console.WriteLine("--- Wybierz co chcesz zrobić: ---");
            Console.WriteLine("1. Dodaj lekcję");
            Console.WriteLine("2. Przerwy");
            Console.WriteLine("3. Wpisz uwagę");
            Console.WriteLine("4. Wpisz ocenę");
            Console.WriteLine("5. Dane osobowe");
            Console.WriteLine("6. Wyloguj się");
            Console.Write("Wybierz opcję: ");
            int choice = int.Parse(Console.ReadLine());

            // Przetwórz wybór
            switch (choice)
            {
                case 1:
                    // Obsługa opcji 1 - dodawanie lekcji
                    Console.Clear();
                    Console.WriteLine("--- Dodawanie lekcji ---\n" +
                        "Podaj numer lekcji: ");
                    int IdLekcji = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nPodaj godzine rozpoczęcia lekcji: ");
                    string LekcjaStart = Console.ReadLine();
                    Console.WriteLine("\nPodaj godzine zakończenia lekcji: ");
                    string LekcjaEnd = Console.ReadLine();
                    CSVMenager.DodawanieLekcjiDoCsv("Przerwy.csv", IdLekcji, LekcjaStart, LekcjaEnd);


                    break;
                case 2:
                    // Obsługa opcji 2 - wyswietlanie przerw
                    Wyswietlanie.WyswietleniePrzerw(PlikPrzerwy);
                    break;
                case 3:
                    // Obsługa opcji 3 - wpisywanie uwag
                    Console.Clear();
                    Console.WriteLine("--- Wpisywanie Uwagi ---\n" +
                        "Podaj Numer Albumu studenta: ");
                    int NumerStudenta = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nWpisz treść uwagi: ");
                    string Tresc = Console.ReadLine();
                    Console.WriteLine("\nPodaj datę: (dd/mm/yyyy)\n");
                    string Data = Console.ReadLine();
                    CSVMenager.DodawanieUwag("Uwagi.csv", NumerStudenta, Tresc, Data);
                    break;
                case 4:
                    // Obsługa opcji 4 - dodawanie ocen
                    Console.Clear();
                    Console.WriteLine("--- Wpisywanie Oceny ---\n" +
                        "Podaj Numer Albumu studenta: ");
                    int NumerStudenta1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nPodaj nazwę przedmiotu: \n" +
                        "(Dostępne: Matematyka , Informatyka , Programowanie , Fizyka, Grafika)");
                    string Kurs = Console.ReadLine();
                    Console.WriteLine("\nPodaj ocenę:");
                    string Ocena = Console.ReadLine();
                    CSVMenager.DodawanieOcen("Oceny.csv", NumerStudenta1, Ocena, Kurs);
                    break;
                case 5:
                    // Obsługa opcji 5 - dane osobowe
                    Console.Clear();
                    Console.WriteLine($"Imię: {ImiePodane}");
                    //WyswietlanieDanychOsobowych(ImiePodane);
                    Wyswietlanie.WyswietlanieDanychOsobowych2(ImiePodane, "Nauczyciele.csv", HasloPodane);
                    break;
                case 6:
                    // Obsługa opcji 6 - wylogowanie
                    Console.Clear();
                    
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}

