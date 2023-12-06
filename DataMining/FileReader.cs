using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace DataMining
{
    public class FileReader
    {
        public static List<Stock> ReadData(string filePath, int percentFromInputData)
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Stock>();

                    stocks.AddRange(records);
                }

                int countRecords = stocks.Count * percentFromInputData / 100;

                var result = new List<Stock>(stocks);

                for (int i = stocks.Count - 1; i > countRecords; i--)
                {
                    result.RemoveAt(result.Count - 1);
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка чтения файла: " + ex.Message);
            }

            return stocks;
        }
    }
}
