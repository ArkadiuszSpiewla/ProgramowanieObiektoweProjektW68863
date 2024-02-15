using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ExampleCSV

{
    internal class Wyswietlanie
    {
        public static void WyswietleniePrzerw(string PlikPrzerwy)
        {
            using (var reader = new StreamReader(PlikPrzerwy))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Przerwy>().ToList();
                Console.Clear();
                Console.WriteLine("--- Rozkład Dzwonków ---\n");
                foreach (var przerwy in records)
                {
                    Console.WriteLine($"   {przerwy.ID}. | {przerwy.start} |  {przerwy.end}");
                }
            }
        }
                                                             

        public static void WyswietlanieDanychOsobowych(string ImiePodane, string PlikStudentow, string HasloPodane)
        {
            using (var reader = new StreamReader(PlikStudentow))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>().Where(p => p.Imie == ImiePodane && p.Haslo == HasloPodane).ToList();
                Console.Clear();
                Console.WriteLine("--- Dane Osobowe ---\n");
                foreach (var student in records)
                {
                    Console.WriteLine($"Imię: {student.Imie}\nNazwisko: {student.Nazwisko}\nNumer Albumu: {student.numerAlbumu}\nGrupa: {student.Grupa}");
                }
            }
        }

        public static void WyswietlanieDanychOsobowych2(string ImiePodane, string PlikNauczycieli, string HasloPodane)
        {
            using (var reader = new StreamReader(PlikNauczycieli))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Nauczyciel>().Where(p => p.Imie == ImiePodane && p.Haslo == HasloPodane).ToList();
                Console.Clear();
                Console.WriteLine("--- Dane Osobowe ---\n");
                foreach (var nauczyciel in records)
                {
                    Console.WriteLine($"Imię: {nauczyciel.Imie}\nNazwisko: {nauczyciel.Nazwisko}\nStopień: {nauczyciel.Stopien}");
                }
            }
        }

        public static void WyswietlanieUwag(string PlikUwagi, string ImiePodane, string PlikStudentow, string HasloPodane)
        {
            Console.Clear();
            List<Student> uczen;
            using (var uczenreader = new StreamReader(PlikStudentow))
            using (var uczencsv = new CsvReader(uczenreader, CultureInfo.InvariantCulture))
            {
                uczen = uczencsv.GetRecords<Student>().Where(p => p.Imie == ImiePodane && p.Haslo == HasloPodane).ToList();
            }

            List<Uwagi> uwagi;
            using (var uwagireader = new StreamReader(PlikUwagi))
            using (var uwagicsv = new CsvReader(uwagireader, CultureInfo.InvariantCulture))
            {
                uwagi = uwagicsv.GetRecords<Uwagi>().ToList();
            }

            var UwagiUcznia = from studenciak in uczen
                              join uwaga in uwagi on studenciak.numerAlbumu equals uwaga.NumerStudenta
                              where uwaga.NumerStudenta == studenciak.numerAlbumu
                              select new { uwaga.Data, uwaga.TrescUwagi };
            foreach(var wynik in UwagiUcznia)
            {

                Console.WriteLine($"\nData otrzymania: {wynik.Data}\n" +
                    $"Treść: {wynik.TrescUwagi}\n");
                
            }
        }


        public static void WyswietlanieOcen(string PlikOceny, string ImiePodane, string PlikStudentow, string HasloPodane, string WybranyKurs)
        {
            int i = 0;
            Console.Clear();
            List<Student> uczen;
            using (var uczenreader = new StreamReader(PlikStudentow))
            using (var uczencsv = new CsvReader(uczenreader, CultureInfo.InvariantCulture))
            {
                uczen = uczencsv.GetRecords<Student>().Where(p => p.Imie == ImiePodane && p.Haslo == HasloPodane).ToList();
            }

            List<Oceny> oceny;
            using (var ocenyreader = new StreamReader(PlikOceny))
            using (var ocenycsv = new CsvReader(ocenyreader, CultureInfo.InvariantCulture))
            {
                oceny = ocenycsv.GetRecords<Oceny>().ToList();
            }

            var OcenyUcznia = from ocenki in oceny
                              join studenciak in uczen on ocenki.StudentID equals studenciak.numerAlbumu
                              where ocenki.StudentID == studenciak.numerAlbumu && ocenki.Kurs == WybranyKurs
                              select new { ocenki.Kurs, ocenki.Ocena };
            foreach (var wynik in OcenyUcznia)
            {

                Console.WriteLine($"\n {wynik.Kurs}: {wynik.Ocena}");
                i++;
            }
            if(i==0)
            {
                Console.WriteLine("Brak ocen z tego przedmiotu");
            }
        }



        
    }
}
