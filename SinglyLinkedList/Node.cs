using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        public Node Next;
        public object Data;

        public Node(object data) {
            this.Data = data;
            this.Next = null;
        }
    }
}
