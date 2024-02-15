using CsvHelper;
using System.Globalization;
using ExampleCSV;

//Scieżki do plików
string PlikUzytkownicy = "Users.csv";
string PlikKursy = "Kursy.csv";
string PlikStudentow = "Studenci.csv";
string PlikPrzerwy = "Przerwy.csv";
string PlikNauczycieli = "Nauczyciele.csv";
string PlikUwag = "Uwagi.csv";
string PlikOcen = "Oceny.csv";

// Zapis danych do pliku CSV
CSVMenager.ZapisUzytkownikow(PlikUzytkownicy);
CSVMenager.ZapisStudentow(PlikStudentow, PlikKursy);
CSVMenager.ZapisPrzerw(PlikPrzerwy);
CSVMenager.ZapisNauczycieli(PlikNauczycieli);
CSVMenager.ZapisKursow(PlikKursy);







Console.WriteLine("Podaj Imie: ");
string ImiePodane = Console.ReadLine();
Console.Write("Podaj hasło: \n");
string HasloPodane = UkrywanieHasla.GetHiddenInput('*');









//Szukanie Nauczyciela oraz Studenta w Systemie
int Nauczyciele = CSVMenager.SzukanieNauczyciela(PlikNauczycieli,ImiePodane, HasloPodane);
int Studenci = CSVMenager.SzukanieStudenta(PlikStudentow, ImiePodane, HasloPodane);










if (Studenci > 0 && Nauczyciele == 0)
{
    // --- System dla studenta ---
    Console.Clear();
    bool exitProgram = false;

    do
    {
        // Wywołaj funkcję menu
        MenuStudenta.MenuGlowneStudenta(ImiePodane, HasloPodane);

        Console.Write("\n--- Aby wrócić, kliknij dowolny przycisk ---\n" +
            "--- Aby wylogować się, kliknij N ---");
        char key = Console.ReadKey().KeyChar;

        // Jeśli użytkownik wybierze 'N', zakończy program
        if (key == 'N' || key == 'n')
        {
            Console.Clear();
            Console.WriteLine("Zostałeś poprawnie wylogowany!\n" +
                "Miłego Dnia!");
            exitProgram = true;
        }

    } while (!exitProgram);

}
else
{
    if(Nauczyciele > 0 && Studenci == 0)
    {
                       // --- System dla nauczyciela ---
        bool exitProgram = false;

        do
        {
            // Wywołaj funkcję menu
            MenuNauczyciela.MenuGlowneNauczyciela(ImiePodane, HasloPodane);

            Console.Write("\nAby wrócić, kliknij dowolny przycisk\n" +
                "\nAby wylogować się, kliknij N ");
            char key = Console.ReadKey().KeyChar;

            // Jeśli użytkownik wybierze 'N', zakończy program
            if (key == 'N' || key == 'n')
            {
                Console.Clear();
                Console.WriteLine("Zostałeś poprawnie wylogowany!\n" +
                    "Miłego Dnia!");
                exitProgram = true;
            }

        } while (!exitProgram);




    }else
    {
        // --- Błędne dane logowania ---
        Console.Clear();
        Console.WriteLine("Nie Znaleziono nikogo o takich danych.\n" +
            "Sprawdź poprawność wprowadzanych i spróbuj ponownie");
    
    }
        
}