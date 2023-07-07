using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack_LinkedList stack_LinkedList = new Stack_LinkedList();
            stack_LinkedList.Add(70);
            stack_LinkedList.Add(30);
            stack_LinkedList.Add(56);
            stack_LinkedList.Display();
            Console.WriteLine("-----------------");
            stack_LinkedList.Peek();
            stack_LinkedList.Display();
            Console.WriteLine("-----------------");
            stack_LinkedList.Pop();
            stack_LinkedList.Display();

        }
    }
}
