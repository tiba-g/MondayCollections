using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskOrganizesArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList stringArrayList;
            string sizeOfCollection;
            int number;
            do
            {
                Console.WriteLine("Please enter the size(positive integer) of the ArrayList.");
                sizeOfCollection = Console.ReadLine();
            } while (!int.TryParse(sizeOfCollection, out number));
            int sizeOfCollectionNumber = Int32.Parse(sizeOfCollection);

            stringArrayList = new ArrayList();

            for (int i = 0; i < sizeOfCollectionNumber; i++)
            {
                Console.WriteLine("Please enter a string: ");
                stringArrayList.Add(Console.ReadLine());
            }
            stringArrayList.Sort();
            Console.WriteLine("\nThe contain of the collection is: ");
            for (int i = 0; i < sizeOfCollectionNumber; i++)
            {
                Console.WriteLine(stringArrayList[i]);
            }
            Console.ReadLine();
        }
    }
}
