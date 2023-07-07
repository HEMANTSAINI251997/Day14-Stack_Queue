using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Queue_LinkedList
    {
        Node head = null;
        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("QUEUE IS EMPTY");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine("ELEMENT = " + temp.data);
                temp = temp.next;
            }               
        }
        public void DeQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                while(head != null)
                {
                    Console.WriteLine("Deleted Element = " + head.data);
                    Console.WriteLine("-----------------");
                    head = head.next;
                }

            }
            
        }

    }
}
