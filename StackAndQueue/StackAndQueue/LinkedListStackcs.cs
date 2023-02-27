using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListStackcs
    {
        public Node top;

        //Push the data in stack
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        //Pop method to delete element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible ");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        //display the data of stack
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
