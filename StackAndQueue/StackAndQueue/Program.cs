using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedListStackcs stack = new LinkedListStackcs();
            LinkedListQueue queue = new LinkedListQueue();

            while (flag)
            {
                Console.WriteLine("\n1.Linkedlist Stack push,\n2.Linkedlist Stack pop,\n3.Linkedlist Enqueue");
                Console.WriteLine("choose the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Pop();
                        stack.Display();
                        break;
                    case 3:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        stack.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }  
    }
}
