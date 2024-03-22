using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjetOOP_Hivers_2024.ChildForms.LotoQuebec
{

    


    internal class HistoryHandler
    {
        private const string _filePath = "../../ChildForms/LotoQuebec/History/history.txt";
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;
        private int[] _winningNumbers;
        //private string[] _winningEntries;

        

        public HistoryHandler()
        {
            //constructor for reading the file
        }
        public HistoryHandler(int[] winningNumbers)
        {
            //constructor for writing to the file
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            this._winningNumbers = winningNumbers;
        }


        public void LogWinningEntry()
        {
            string winningNumbers = "";
            foreach (int number in _winningNumbers)
            {
                winningNumbers += number + ";";
            }
            File.AppendAllText(_filePath,
                $"649,{_date.ToShortDateString()}," +
                $"{_time.ToLongTimeString()}," +
                $"{winningNumbers}\n"); // Add a newline

        }

        private string[] ReadWinningEntries()
        {
            if (!File.Exists(_filePath))
            {
                return new string[] { "No entries found" };
            }
            return File.ReadAllLines(_filePath);
        }

        public List<string> PrintWinningEntries()
        {
            List<string> list = new List<string>();
            foreach (string entry in ReadWinningEntries())
            {
                list.Add(FormatString(entry.Split(',')));
            }

            return list;
        }
        //utility
        private string FormatString(string[] splitEntry)
        {
            if (splitEntry.Length == 4)
            {
                return string.Format("{0,10}{1,35}{2,25}{3,30}\n", splitEntry[0], splitEntry[1], splitEntry[2], splitEntry[3]);
            }
            else
            {
                return "Invalid entry\n";
            }
        }
    }
}
