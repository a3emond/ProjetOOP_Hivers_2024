using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter
{
    internal class XmlFileHandler
    {
        private string _filePath = "../../ChildForms/TemperatureConverter/XmlHistory/history.xml";
        private string _entry;
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;

        public XmlFileHandler(string entry)
        {
            _entry = entry;
        }

        public void WriteHistory()
        {
            XmlDocument doc = new XmlDocument();

            if (!File.Exists(_filePath))
            {
                // Create new document if file doesn't exist
                XmlElement root = doc.CreateElement("History");
                doc.AppendChild(root);
                doc.Save(_filePath); // Save the new document immediately
            }

            // Load existing document
            doc.Load(_filePath);

            // Create new entry
            XmlElement entry = doc.CreateElement("Entry");
            entry.SetAttribute("date", _date.ToShortDateString());
            entry.SetAttribute("time", _time.ToLongTimeString());
            entry.InnerText = _entry;

            // Add new entry to document
            doc.DocumentElement.AppendChild(entry);

            // Save document
            doc.Save(_filePath);
        }
    

        public List<string> ReadHistory()
        {
            List<string> entries = new List<string>();

            if (File.Exists(_filePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(_filePath);

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string date = node.Attributes["date"].Value;
                    string time = node.Attributes["time"].Value;
                    string entry = node.InnerText;

                    entries.Add(string.Format("{0,10}{1,35}{2,25}{3,30}\n",
                        "Convert",
                        date,
                        time,
                        entry
                    ));
                }
            }

            return entries;
        }
        //just for showing that I am able to do it
        public void  WriteHistoryWithTxtFiles()
        {
            // Convert XML to text
            string xmlText = File.ReadAllText(_filePath);
            string textFilePath = _filePath.Replace(".xml", ".txt");
            File.WriteAllText(textFilePath, xmlText);

            // Append new entry to text file
            string newEntry = string.Format("<Entry date=\"{0}\" time=\"{1}\">{2}</Entry>",
                _date.ToShortDateString(),
                _time.ToLongTimeString(),
                _entry);
            File.AppendAllText(textFilePath, newEntry);

            // Convert text back to XML
            string updatedText = File.ReadAllText(textFilePath);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(updatedText);
            doc.Save(_filePath);
        }
    }
}
