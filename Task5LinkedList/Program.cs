using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringLinkedList = new LinkedList<string>();

            stringLinkedList.AddFirst("asd");
            stringLinkedList.AddLast("dsa");
            stringLinkedList.AddLast("dfsdfs");

            LinkedListNode<string> stringNode = stringLinkedList.Find("asd");
            stringLinkedList.AddAfter(stringNode, "XXXX");

            foreach (var i in stringLinkedList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            var intLinkedList = new LinkedList<int>();

            intLinkedList.AddFirst(1);
            intLinkedList.AddLast(2);
            intLinkedList.AddLast(3);

            LinkedListNode<int> intNode = intLinkedList.Find(2);
            intLinkedList.AddAfter(intNode, 4);

            foreach (var i in intLinkedList)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("");

            var doubleLinkedList = new LinkedList<double>();

            doubleLinkedList.AddFirst(1.0);
            doubleLinkedList.AddLast(2.0);
            doubleLinkedList.AddLast(3.0);

            LinkedListNode<double> doubleNode = doubleLinkedList.Find(2.0);
            doubleLinkedList.AddAfter(doubleNode, 2.5);

            foreach (var i in doubleLinkedList)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
