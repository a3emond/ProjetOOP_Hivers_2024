using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter
{
    internal class Conversion
    {
        private Dictionary<string, decimal> exchangeRates;

        

        public Conversion()
        {
            // Initialize exchange rates
            exchangeRates = new Dictionary<string, decimal>
            {
                {"USD", 1m},       // US Dollar
                {"EUR", 0.85m},    // Euro
                {"JPY", 111.35m},  // Japanese Yen
                {"GBP", 0.73m},    // British Pound Sterling
                {"AUD", 1.31m},    // Australian Dollar
                {"CAD", 1.25m},    // Canadian Dollar
                {"CHF", 0.92m},    // Swiss Franc
                {"CNY", 6.45m},    // Chinese Yuan
                {"SEK", 8.42m},    // Swedish Krona
                {"NZD", 1.41m},    // New Zealand Dollar
                {"MXN", 20.31m},   // Mexican Peso
                {"SGD", 1.36m},    // Singapore Dollar
                {"HKD", 7.77m},    // Hong Kong Dollar
                {"NOK", 9.09m},    // Norwegian Krone
                {"KRW", 1186.31m}, // South Korean Won
                {"INR", 75.10m}    // Indian Rupee
                
            };
        }

        public decimal Convert(decimal amount, string fromCurrency, string toCurrency)
        {
            if (!exchangeRates.ContainsKey(fromCurrency) || !exchangeRates.ContainsKey(toCurrency))
            {
                throw new ArgumentException("Currency not supported");
            }

            decimal fromRate = exchangeRates[fromCurrency];
            decimal toRate = exchangeRates[toCurrency];

            // Perform the conversion
            decimal result = (amount / fromRate) * toRate;

            return result;
        }
    }
}
