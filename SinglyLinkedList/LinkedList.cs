using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList() {
            Head = null;
        }

        public void Print() {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data+ ", ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void AddFirst(object data) {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(object data) {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = new Node(data);
            }
        }

        public object Pop() {
            if (Head == null)
                throw new Exception("No elements in list");
            else {
                Node element = Head;
                Head = Head.Next;
                return element.Data;
            } 
        }

        public int Search(object o)
        {
            int index = 0;
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Data.Equals(o))
                    return index;
                else
                { 
                    current = current.Next;
                    index++;
                }
            }
            return -1;
        }

        public void Insert(object data,int i) {
            Node newNode = new Node(data);
            if (i == 0)
            {                
                newNode.Next = Head;
                Head = newNode;
            }
            else if (Head == null)
                throw new IndexOutOfRangeException();

            Node previous = null;
            Node current = Head;
            int currentIndex = 0;
            while (currentIndex!=i) {
                if (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                    currentIndex++;
                }
                else {
                    throw new IndexOutOfRangeException();
                }
            }
            previous.Next = newNode;
            newNode.Next = current;
        }
    }
}
