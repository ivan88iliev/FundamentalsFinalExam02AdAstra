using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FundamentalsFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //FundamentalsFinalExam02AdAstra

            string inputText = Console.ReadLine();

            string pattern = @"(\||#)([A-za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,4}|10000)\1";

            Regex regexPattern = new Regex(pattern);


            var matches = regexPattern.Matches(inputText);  //Groups: 2 = ProductName, 3 = ExpirationDate, 4 = Kcal
            int totalCalories = matches.Select(x => int.Parse(x.Groups[4].ToString())).Sum();


            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2]}, Best before: {item.Groups[3]}, Nutrition: {item.Groups[4]}");
            }

            //
        }
    }
}
