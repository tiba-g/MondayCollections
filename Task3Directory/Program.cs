using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number that you would like to convert: ");
            string input = Console.ReadLine();
            var numbers = new Dictionary<string, string>();

            numbers.Add("0", "zero");
            numbers.Add("1", "one");
            numbers.Add("2", "two");
            numbers.Add("3", "three");
            numbers.Add("4", "four");
            numbers.Add("5", "five");
            numbers.Add("6", "six");
            numbers.Add("7", "seven");
            numbers.Add("8", "eight");
            numbers.Add("9", "nine");
            
            foreach (KeyValuePair<String, string> item in numbers)
            {
                if (input.Contains(item.Key))
                {
                    input = input.Replace(item.Key, item.Value.ToString());
                }
            }
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}
