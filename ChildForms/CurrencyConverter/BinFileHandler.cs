using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter
{
    internal class BinFileHandler : IHistoryHandler
    {
        private string _filePath = "../../ChildForms/CurrencyConverter/BinHistory/binHistory.bin";
        private string _entry;
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;

        public BinFileHandler(string entry)
        {
            _entry = entry;

        }

        public void Write()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(_filePath, FileMode.Append)))
            {
                writer.Write(FormatEntry(_entry));
            }
        }



        public string[] Read()
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

            return entries.ToArray();
        }


        private string FormatEntry(string entry)
        {
            
                entry = string.Format("{0,10}{1,25}{2,25}{3,30}\n",
                    "Exchange",
                    _date.ToShortDateString(),
                    _time.ToLongTimeString(),
                    entry
                    );
            
            return entry;
        }
    }
}