using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace ExampleCSV
{




    public class CSVMenager
    {
        public static void ZapisUzytkownikow(string PlikUzytkownicy)
        {
            List<Person> uzytkownicy = new List<Person>
    {
            new Person { Imie = "Jan", Nazwisko = "Nowak", Haslo = "Jan123"},
            new Person { Imie = "Alicja", Nazwisko = "Zając", Haslo = "Alicja123"},
            new Person { Imie = "Bartek", Nazwisko = "Kowalski", Haslo = "Bartek123"},
            new Person { Imie = "Arek", Nazwisko = "Spiewla", Haslo = "Arek123"},
            new Person { Imie = "Krzysztof", Nazwisko = "Kot", Haslo = "Krzysztof123"},
            new Person { Imie = "Rafał", Nazwisko = "Dąbrowski", Haslo = "Rafał123"},
            new Person { Imie = "Piotr", Nazwisko = "Kaczmarek", Haslo = "Piotr123"},
            new Person { Imie = "Joanna", Nazwisko = "Zielińska", Haslo = "Joanna123"},
            new Person { Imie = "Tomasz", Nazwisko = "Woźniak", Haslo = "Tomasz123"},
            new Person { Imie = "Julia", Nazwisko = "Lewandowska", Haslo = "Julia123"},
            new Person { Imie = "John", Nazwisko = "Doe", Haslo = "John123"},
            new Person { Imie = "Alice", Nazwisko = "Smith", Haslo = "Alice123"},
            new Person { Imie = "Janusz", Nazwisko = "Nowak", Haslo = "Janusz123"},
            new Person { Imie = "Marcin", Nazwisko = "Kot", Haslo = "Marcin123"},
            new Person { Imie = "Ryszard", Nazwisko = "Wielki", Haslo = "Ryszard123"}

        };

            using (var writer = new StreamWriter(PlikUzytkownicy))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(uzytkownicy);
            }

            
        }
        public static void ZapisStudentow(string PlikStudentow, string PlikKursy)
          
        {

            
            List<Student> studenci = new List<Student>
    {
            new Student { Imie = "Jan", Nazwisko = "Nowak", Haslo = "Jan123" , numerAlbumu = 11111, Grupa = 1},
            new Student { Imie = "Alicja", Nazwisko = "Zając", Haslo = "Alicja123" , numerAlbumu = 22222, Grupa = 1 },
            new Student { Imie = "Bartek", Nazwisko = "Kowalski", Haslo = "Bartek123" , numerAlbumu = 33333, Grupa = 1},
            new Student { Imie = "Arek", Nazwisko = "Spiewla", Haslo = "Arek123" , numerAlbumu = 68863, Grupa = 1},
            new Student { Imie = "Krzysztof", Nazwisko = "Kot", Haslo = "Krzysztof123" , numerAlbumu = 44444 , Grupa = 1},
            new Student { Imie = "Rafał", Nazwisko = "Dąbrowski", Haslo = "Rafał123" , numerAlbumu = 55555 , Grupa = 2},
            new Student { Imie = "Piotr", Nazwisko = "Kaczmarek", Haslo = "Piotr123" , numerAlbumu = 66666 , Grupa = 2},
            new Student { Imie = "Joanna", Nazwisko = "Zielińska", Haslo = "Joanna123" , numerAlbumu = 77777 , Grupa = 2},
            new Student { Imie = "Tomasz", Nazwisko = "Woźniak", Haslo = "Tomasz123" , numerAlbumu = 88888 , Grupa = 2},
            new Student { Imie = "Julia", Nazwisko = "Lewandowska", Haslo = "Julia123" , numerAlbumu = 99999, Grupa = 2}

        };

            using (var writer = new StreamWriter(PlikStudentow))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(studenci);
            }
            

            
        }

        public static void ZapisNauczycieli(string PlikNauczycieli)
        {
            List<Nauczyciel> nauczyciele = new List<Nauczyciel>
    {
            new Nauczyciel { Imie = "John", Nazwisko = "Doe", Haslo = "John123" , Stopien = "Stażysta"},
            new Nauczyciel { Imie = "Alice", Nazwisko = "Smith", Haslo = "Alice123" , Stopien = "Stażysta"},
            new Nauczyciel { Imie = "Janusz", Nazwisko = "Nowak", Haslo = "Janusz123" , Stopien = "Kontraktowy"},
            new Nauczyciel { Imie = "Marcin", Nazwisko = "Kot", Haslo = "Marcin123" , Stopien = "Mianowany"},
            new Nauczyciel { Imie = "Ryszard", Nazwisko = "Wielki", Haslo = "Ryszard123" , Stopien = "Dyplomowany"}


        };

            using (var writer = new StreamWriter(PlikNauczycieli))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(nauczyciele);
            }

            
        }

        public static void ZapisPrzerw(string PlikPrzerwy)
        {
            List<Przerwy> przerwy = new List<Przerwy>
            {
            new Przerwy { ID = 1, start = "08.00" , end = "08.45" },
            new Przerwy { ID = 2, start = "08.55" , end = "09.40" },
            new Przerwy { ID = 3, start = "09.50" , end = "10.35" },
            new Przerwy { ID = 4, start = "10.45" , end = "11.30" },
            new Przerwy { ID = 5, start = "11.40" , end = "12.25" },
            new Przerwy { ID = 6, start = "12.45" , end = "13.30" },
            new Przerwy { ID = 7, start = "13.45" , end = "14.30" },
            new Przerwy { ID = 8, start = "14.40" , end = "15.25" },
            new Przerwy { ID = 9, start = "15.35" , end = "16.20" }
            };

            using (var writer = new StreamWriter(PlikPrzerwy))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(przerwy);
            }

            
        }
        


        public static void ZapisKursow(string PlikKursy)
        {
            List<Kursy> kursy = new List<Kursy>
            {
            new Kursy {IdKursu = 1, NazwaKursu = "Matematyka" },
            new Kursy {IdKursu = 2, NazwaKursu = "Fizyka" },
            new Kursy {IdKursu = 3, NazwaKursu = "Informatyka" },
            new Kursy {IdKursu = 4, NazwaKursu = "Programowanie"},
            new Kursy {IdKursu = 5, NazwaKursu = "Grafika"}
            };

            using (var writer = new StreamWriter(PlikKursy))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(kursy);
            }


        }


        public static int SzukanieNauczyciela(string PlikNauczycieli, string ImiePodane, string Haslo)
        {
            int x = 0;
            using (var reader = new StreamReader(PlikNauczycieli))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Nauczyciel>().Where(p => p.Imie.Contains(ImiePodane) && p.Haslo == Haslo).ToList();

                
                foreach (var nauczyciele in records)
                {
                    //Console.WriteLine($"Imię: {person.Imie}, Nazwisko: {person.Nazwisko}, Haslo: {person.Haslo}, Rola: {person.Rola}");
                    x++;
                }
            }
            return x;
        }
        public static void KursyTest(string PlikKursy)
        {
            using (var reader = new StreamReader(PlikKursy))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Kursy>().ToList();

                foreach(var kursy in records)
                {
                    Console.WriteLine($"Nazwa kursu: {kursy.NazwaKursu}");
                }
            }
        }

        public static int SzukanieStudenta(string PlikStudentow, string ImiePodane, string Haslo)
        {
            int y = 0;
            using (var reader = new StreamReader(PlikStudentow))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>().Where(p => p.Imie.Contains(ImiePodane) && p.Haslo == Haslo).ToList();

                
                foreach (var studenci in records)
                {
                    
                    y++;
                }
            }
            return y;
        }

        public static void DodawanieLekcjiDoCsv(string SciezkaPliku, int Id, string start, string end)
        {
            List<Przerwy> ExistingList = CSVMenagerHelpers.ReadDataFromCsv(SciezkaPliku);

            List<Przerwy> NowaLekcja = new List<Przerwy>
            {
            new Przerwy { ID = Id, start = start , end = end }
            };
            ExistingList.AddRange(NowaLekcja);
            CSVMenagerHelpers.WriteDataToCsv(SciezkaPliku, ExistingList);
            Console.Clear();
            Console.WriteLine("Lekcja została poprawnie dodana!\n");
        }

        public static void DodawanieUwag(string SciezkaPliku, int NumerUcznia, string Tresc, string Data)
        {
            List<Uwagi> ExistingList = CSVMenagerHelpers.ReadDataFromCsvUwagi(SciezkaPliku);

            List<Uwagi> NowaUwaga = new List<Uwagi>
            {
            new Uwagi { NumerStudenta = NumerUcznia, TrescUwagi = Tresc, Data = Data }
            };
            ExistingList.AddRange(NowaUwaga);
            CSVMenagerHelpers.WriteDataToCsvUwagi("Uwagi.csv", ExistingList);
            Console.Clear();
            Console.WriteLine("Uwaga została poprawnie dodana!\n");
        }

        public static void DodawanieOcen(string SciezkaPliku, int NumerUcznia, string Ocena, string NazwaKursu)
        {
            List<Oceny> ExistingList = CSVMenagerHelpers.ReadDataFromCsvOceny(SciezkaPliku);

            List<Oceny> NowaOcena = new List<Oceny>
            {
            new Oceny { Kurs = NazwaKursu, StudentID = NumerUcznia, Ocena = Ocena }
            };
            ExistingList.AddRange(NowaOcena);
            CSVMenagerHelpers.WriteDataToCsvOceny("Oceny.csv", ExistingList);
            Console.Clear();
            Console.WriteLine("Ocena została poprawnie dodana!\n");
        }

        /*public static void DodawanieOcen(string ImiePodane, string HasloPodane, string PlikStudentow, string PlikOcen, string PlikKursow)
        {
            List<Student> studenci;
            using (var studencireader = new StreamReader(PlikStudentow))
            using (var studencicsv = new CsvReader(studencireader, CultureInfo.InvariantCulture))
            {
                studenci = studencicsv.GetRecords<Student>().ToList();
            }

            List<Oceny> oceny;
            using (var ocenyreader = new StreamReader(PlikOcen))
            using (var ocenycsv = new CsvReader(ocenyreader, CultureInfo.InvariantCulture))
            {
                oceny = ocenycsv.GetRecords<Oceny>().ToList();
            }
            Console.WriteLine("Podaj numer albumu studenta: ");
            int NumerAlbumuStudenta = int.Parse(Console.ReadLine());

            Student WybranyStudent = studenci.FirstOrDefault(p => p.numerAlbumu == NumerAlbumuStudenta);
            if(WybranyStudent != null)
            {
                Console.WriteLine($"Wybrano studenta: {WybranyStudent.Imie} {WybranyStudent.Nazwisko}");
            }
        }*/



























    }
}
