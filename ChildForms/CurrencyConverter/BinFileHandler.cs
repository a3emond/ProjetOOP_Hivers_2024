using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter
{
    internal class BinFileHandler
    {
        private string _filePath = "../../ChildForms/CurrencyConverter/BinHistory/binHistory.bin";
        private string _entry;
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;

        public BinFileHandler(string entry)
        {
            _entry = entry;

        }

        public void WriteBinHistory()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(_filePath, FileMode.Append)))
            {
                writer.Write(_entry);
            }
        }



        public List<string> ReadBinHistory()
        {
            List<string> entries = new List<string>();

            if (File.Exists(_filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        entries.Add(reader.ReadString());
                    }
                }
            }

            return FormatCurrencyHistory(entries);
        }


        private List<string> FormatCurrencyHistory(List<string> entries)
        {
            List<string> formattedEntries = new List<string>();
            foreach (var str in entries)
            {
                formattedEntries.Add(string.Format("{0,10}{1,25}{2,25}{3,30}\n",
                    "Exchange",
                    _date.ToShortDateString(),
                    _time.ToLongTimeString(),
                    str
                    ));
            }
            return formattedEntries;
        }
    }
}