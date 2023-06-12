using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Вася Кристина",
                   "Артем Cтепа Игорь",
                   "енот кабан Илья мышка" };

            Console.WriteLine(VowelEndCount(lines));


            Console.ReadKey();
        }

        static int VowelEndCount(string[] lines)
        {
            string text = string.Join(" ", lines);
            string[] words = text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(w => "аеёиоуыэюя".Contains(w.ToLower().Last()));
            return count;
        }

        public static void PrintClientYearMonths(List<Record> records)
        {
            var clientYearMonths = records.GroupBy(r => new { r.ClientID, r.Year })
                .Select(g => new { g.Key.ClientID, g.Key.Year, Months = g.Count() })
                .OrderByDescending(g => g.Year)
                .ThenBy(g => g.ClientID);

            foreach (var clientYearMonth in clientYearMonths)
            {
                Console.WriteLine($"{clientYearMonth.ClientID} {clientYearMonth.Year} {clientYearMonth.Months}");
            }
        }
    }
}
