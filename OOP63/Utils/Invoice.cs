using System;
using System.Text;

namespace OOP63.Utils
{
    public class Invoice
    {
        public string CreateInvoice(int counter)
        {
            TimeSpan timeSpan = TimeSpan.FromDays(7);
            DateTime dateTime = DateTime.Now;
            String today = dateTime.ToString("dd - MMM - yyyy");
            String yearMonth = dateTime.Add(timeSpan).ToString("yyyyMM");
            String day = dateTime.Add(timeSpan).ToString("dddd");
            int dateRoman = Convert.ToInt32(dateTime.Add(timeSpan).ToString("dd"));
            int yearRoman = Convert.ToInt32(dateTime.Add(timeSpan).ToString("yy"));

            return $"Invoice\t= INV/{yearMonth}/{day.Substring(0, 2).ToUpper()}/{NumberToRoman(dateRoman)}/{NumberToRoman(yearRoman)}/{counter + 1}";
        }

        private string NumberToRoman(int number)
        {
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            return result.ToString();
        }
    }
}
