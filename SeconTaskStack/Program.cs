using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconTaskStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack;
            string sizeOfCollection;
            int number;
            do
            {
                Console.WriteLine("Please enter the size(positive integer) of the Stack.");
                sizeOfCollection = Console.ReadLine();
            } while (!int.TryParse(sizeOfCollection, out number));
            int sizeOfCollectionNumber = Int32.Parse(sizeOfCollection);

            stack = new Stack<int>();

            for (int i = 0; i < sizeOfCollectionNumber; i++)
            {
                Console.WriteLine("Please enter a number: ");
                stack.Push(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nThe contain of the collection is: ");
            for (int i = 0; i < sizeOfCollectionNumber; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}