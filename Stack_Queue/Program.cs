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
            Queue_LinkedList queue_LinkedList = new Queue_LinkedList();           
            while (true)
            {
                Console.WriteLine("WELCOME");
                Console.WriteLine("Press 1 for Stack ");
                Console.WriteLine("Press 2 for Queue");
                Console.WriteLine("Enter the Choice");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        
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
                        break;
                    case 2:
                       
                        queue_LinkedList.Enqueue(70);
                        queue_LinkedList.Enqueue(30);
                        queue_LinkedList.Enqueue(56);
                        queue_LinkedList.Display();
                        Console.WriteLine("-----------------");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
               
            }

        }
    }
}
