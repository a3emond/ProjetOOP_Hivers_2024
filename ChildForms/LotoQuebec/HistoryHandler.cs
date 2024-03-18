using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetOOP_Hivers_2024.ChildForms.LotoQuebec
{
    internal class HistoryHandler
    {
        private const string _filePath = "../../ChildForms/LotoQuebec/History/history.txt";
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;
        private int[] _winningNumbers;
        private string[] _winningEntries;

        

        public HistoryHandler()
        {
            //constructor for reading the file
        }
        public HistoryHandler(int[] winningNumbers)
        {
            //constructor for writing to the file
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
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
                $"649,{_date.ToShortDateString()},{_time.ToShortTimeString()},{winningNumbers}");
        }

        private string[] ReadWinningEntries()
        {
            return File.ReadAllLines(_filePath);
        }

        public void PrintWinningEntries()
        {
            foreach (string entry in ReadWinningEntries())
            {
                entry.Split(',');// a terminer...........
            }
        }

    }
}
