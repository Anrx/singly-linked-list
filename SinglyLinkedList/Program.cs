using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddFirst("first node");
            linkedList.AddLast("last node");
            linkedList.Print();
            object popped = linkedList.Pop();
            Console.WriteLine("Pop: "+popped);
            linkedList.Print();
            linkedList.AddLast("second node");
            linkedList.AddLast("third node");
            linkedList.Print();
            int index = linkedList.Search("second node");
            Console.WriteLine("second node is stored at index: " + index);
            linkedList.Insert("before second node", index);
            linkedList.Print();
            Console.ReadLine();
        }
    }
}
