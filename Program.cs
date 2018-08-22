using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("ASS", "Asstronomical Asses");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>()
                {
                    ("ASS", 3, 4.15),
                    ("GM", 5, 6000),
                    ("CAT", 4, 8.99),
                    ("ASS", 5, 7.57),
                    ("GM", 6, 9000),
                    ("CAT", 2, 3.99)
                };

            Dictionary<string, double> totals = new Dictionary<string, double>();

                foreach ((string ticker, int shares, double price) item in purchases)
                {
                    if (totals.ContainsKey(stocks[item.ticker])) {
                        totals[stocks[item.ticker]] += item.shares * item.price;
                    } else {
                        totals[stocks[item.ticker]] = item.shares * item.price;
                    }
                };

            foreach (KeyValuePair<string, double> item in totals)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            };
        }
    }
}
