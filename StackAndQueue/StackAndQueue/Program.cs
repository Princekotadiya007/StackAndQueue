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

            while (flag)
            {
                Console.WriteLine("\n1.Linkedlist Stack push,\n2.Linkedlist Stack pop");
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
                }
            }
        }  
    }
}
