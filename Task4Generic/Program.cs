using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("ASD");
            list.Add("DSA");
            list.Add("SASD");

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
