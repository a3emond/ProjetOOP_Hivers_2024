using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter;
using ProjetOOP_Hivers_2024.ChildForms.LotoQuebec;

namespace ProjetOOP_Hivers_2024
{
    public partial class CurrencyConverter : Form
    {
        private List<string> currencyList1;
        private List<string> currencyList2;
        private Dictionary<string, string> symbols;
        private Dictionary<string, Image> currenciesPictures;
        private string _filePath = "../../ChildForms/CurrencyConverter/BinHistory/binHistory.bin";
        public CurrencyConverter()
        {
            
            symbols = new Dictionary<string, string>
            {
                {"USD", "$"},   // US Dollar
                {"EUR", "€"},   // Euro
                {"JPY", "¥"},   // Japanese Yen
                {"GBP", "£"},   // British Pound Sterling
                {"AUD", "A$"},  // Australian Dollar
                {"CAD", "C$"},  // Canadian Dollar
                {"CHF", "CHF"}, // Swiss Franc
                {"CNY", "¥"},   // Chinese Yuan
                {"SEK", "kr"},  // Swedish Krona
                {"NZD", "NZ$"}, // New Zealand Dollar
                {"MXN", "Mex$"},// Mexican Peso
                {"SGD", "S$"},  // Singapore Dollar
                {"HKD", "HK$"}, // Hong Kong Dollar
                {"NOK", "kr"},  // Norwegian Krone
                {"KRW", "₩"},   // South Korean Won
                {"INR", "₹"}    // Indian Rupee
            };
            currenciesPictures = new Dictionary<string, Image>
            {
                {"USD", Image.FromFile("Assets/currencies/USD.jpg")},   // US Dollar
                {"EUR", Image.FromFile("Assets/currencies/EUR.jpg")},   // Euro
                {"JPY", Image.FromFile("Assets/currencies/JPY.jpg")},   // Japanese Yen
                {"GBP", Image.FromFile("Assets/currencies/GBP.jpg")},   // British Pound Sterling
                {"AUD", Image.FromFile("Assets/currencies/AUD.jpg")},  // Australian Dollar
                {"CAD", Image.FromFile("Assets/currencies/CAD.jpg")},  // Canadian Dollar
                {"CHF", Image.FromFile("Assets/currencies/CHF.jpg")}, // Swiss Franc
                {"CNY", Image.FromFile("Assets/currencies/CNY.jpg")},   // Chinese Yuan
                {"SEK", Image.FromFile("Assets/currencies/SEK.jpg")},  // Swedish Krona
                {"NZD", Image.FromFile("Assets/currencies/NZD.jpg")}, // New Zealand Dollar
                {"MXN", Image.FromFile("Assets/currencies/MXN.jpg")},// Mexican Peso
                {"SGD", Image.FromFile("Assets/currencies/SGD.jpg")},  // Singapore Dollar
                {"HKD", Image.FromFile("Assets/currencies/HKD.jpg")}, // Hong Kong Dollar
                {"NOK", Image.FromFile("Assets/currencies/NOK.jpg")},  // Norwegian Krone
                {"KRW", Image.FromFile("Assets/currencies/KRW.jpg")},   // South Korean Won
                {"INR", Image.FromFile("Assets/currencies/INR.jpg")}    // Indian Rupee
            };
            currencyList1 = new List<string>
            {
                "United States Dollar(USD) - $",
                "Euro(EUR) - €",
                "Japanese Yen(JPY) - ¥",
                "British Pound Sterling(GBP) - £",
                "Australian Dollar(AUD) - A$",
                "Canadian Dollar(CAD) - C$",
                "Swiss Franc(CHF) - CHF or Fr.",
                "Chinese Yuan(CNY) - ¥ or 元",
                "Swedish Krona(SEK) - kr",
                "New Zealand Dollar(NZD) - NZ$",
                "Mexican Peso(MXN) - Mex$",
                "Singapore Dollar(SGD) - S$",
                "Hong Kong Dollar(HKD) - HK$",
                "Norwegian Krone(NOK) - kr",
                "South Korean Won(KRW) - ₩",
                "Indian Rupee(INR) - ₹"
            };
            currencyList2 = new List<string>
            {
                "United States Dollar(USD) - $",
                "Euro(EUR) - €",
                "Japanese Yen(JPY) - ¥",
                "British Pound Sterling(GBP) - £",
                "Australian Dollar(AUD) - A$",
                "Canadian Dollar(CAD) - C$",
                "Swiss Franc(CHF) - CHF or Fr.",
                "Chinese Yuan(CNY) - ¥ or 元",
                "Swedish Krona(SEK) - kr",
                "New Zealand Dollar(NZD) - NZ$",
                "Mexican Peso(MXN) - Mex$",
                "Singapore Dollar(SGD) - S$",
                "Hong Kong Dollar(HKD) - HK$",
                "Norwegian Krone(NOK) - kr",
                "South Korean Won(KRW) - ₩",
                "Indian Rupee(INR) - ₹"
            };
            InitializeComponent();
            fromCurrencyBox.DataSource = currencyList1;
            toCurrencyBox.DataSource = currencyList2;
            

        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5,5) ;
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //handle keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void inputBox_KeyUp(object sender, KeyEventArgs e)
        {
            //update output
            if (fromCurrencyBox.SelectedItem.ToString() != "" && toCurrencyBox.SelectedItem.ToString() != "")
            {
                UpdateOutput();
            }
        }

        private void fromCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update output
            if (fromCurrencyBox.SelectedItem != null && toCurrencyBox.SelectedItem != null &&
                fromCurrencyBox.SelectedItem.ToString() != "" && toCurrencyBox.SelectedItem.ToString() != "")
            {
                UpdateOutput();
            }
            //update currency input symbol
            if (fromCurrencyBox.SelectedItem != null)
            { 
                var currencyCode = GetCurrencyCode(fromCurrencyBox.SelectedItem.ToString());
                var symbol = GetSymbol(currencyCode);
                inputSymbol.Text = symbol;
                fromPictureBox.Image = currenciesPictures[currencyCode];
            }
        }

        private void toCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update output
            if (fromCurrencyBox.SelectedItem != null && toCurrencyBox.SelectedItem != null &&
                fromCurrencyBox.SelectedItem.ToString() != "" && toCurrencyBox.SelectedItem.ToString() != "")
            {
                UpdateOutput();
            }
            //update currency output symbol
            if (toCurrencyBox.SelectedItem != null)
            {
                var currencyCode = GetCurrencyCode(toCurrencyBox.SelectedItem.ToString());
                var symbol = GetSymbol(currencyCode);
                outputSymbol.Text = symbol;
                toPictureBox.Image = currenciesPictures[currencyCode];
            
                outputSymbol.Text = symbol;
            }

        }
        //utility functions
        public string GetSymbol(string currencyCode)
        {
            if (!string.IsNullOrEmpty(currencyCode))
            {
                if (!symbols.ContainsKey(currencyCode))
                {
                    return "$";
                }

                return symbols[currencyCode];
            }

            return "$";
        }

        public string GetCurrencyCode(string selectedCurrency)
        {
            if (selectedCurrency == "")
            {
                return "USD";
            }
            return selectedCurrency.Substring(selectedCurrency.IndexOf('(') + 1, 3);
        }

        public void UpdateOutput()
        {
            //update output
            if (inputBox.Text == "")
            {
                Result.Text = "";
                return;
            }

            if (decimal.TryParse(inputBox.Text, out decimal amount))
            {
                Conversion conversion = new Conversion();
                decimal convertedAmount = conversion.Convert(amount,
                    GetCurrencyCode(fromCurrencyBox.SelectedItem.ToString()),
                    GetCurrencyCode(toCurrencyBox.Text));
                Result.Text = convertedAmount.ToString("0.00");
            }
            else
            {
                Result.Text = "Invalid input";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string input = GetCurrencyCode(fromCurrencyBox.SelectedItem.ToString()) + ": " + inputBox.Text;
            string output = GetCurrencyCode(toCurrencyBox.SelectedItem.ToString()) + ": " + Result.Text;
            var history = new BinFileHandler($"From {input} to {output}");
            history.WriteBinHistory();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(
                "Exchange", "Date", "time", "Conversion", _filePath);
            customMessageBox.ShowDialog();
        }
    }
}
