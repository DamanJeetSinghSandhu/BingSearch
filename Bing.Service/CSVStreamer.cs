using System;
using System.Collections.Generic;
using System.IO;

namespace Bing.Service
{
    public class CSVStreamer : ICSVStreamer
    {
        public List<string[]> GetCsvFromFile()
        {
            var records = new List<string[]>();

            using (var fileStream = new FileStream("C:\\Users\\FF\\source\\repos\\BingeSearch\\Bing.Service\\Untitled spreadsheet - Sheet1.csv", FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(fileStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    records.Add(line.Split(','));
                }
            }

            return records;
        }
    
    }
}
