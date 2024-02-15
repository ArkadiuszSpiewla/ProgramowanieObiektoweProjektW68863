using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using ExampleCSV;

internal static class CSVMenagerHelpers
{
        
        



    public static List<Przerwy> ReadDataFromCsv(string SciezkaDoPrzerw)
    {
        using (var reader = new StreamReader(SciezkaDoPrzerw))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Przerwy>().ToList();
        }
    }

        public static void WriteDataToCsv(string SciezkaDoPrzerw, List<Przerwy> przerwy)
        {
            using (var writer = new StreamWriter(SciezkaDoPrzerw))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(przerwy);
            }
        }



    public static List<Uwagi> ReadDataFromCsvUwagi(string SciezkaDoUwag)
    {
        using (var reader = new StreamReader(SciezkaDoUwag))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Uwagi>().ToList();
        }
    }

    public static void WriteDataToCsvUwagi(string SciezkaDoUwag, List<Uwagi> uwagi)
    {
        using (var writer = new StreamWriter(SciezkaDoUwag))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(uwagi);
        }
    }

    public static List<Oceny> ReadDataFromCsvOceny(string SciezkaDoOcen)
    {
        using (var reader = new StreamReader(SciezkaDoOcen))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Oceny>().ToList();
        }
    }

    public static void WriteDataToCsvOceny(string SciezkaDoOcen, List<Oceny> oceny)
    {
        using (var writer = new StreamWriter(SciezkaDoOcen))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(oceny);
        }
    }
}