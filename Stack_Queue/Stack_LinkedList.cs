﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Stack_LinkedList
    {
        public Node top;
        
        public void Add(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next=null;
            }
            else
            {
                node.next = top;    
            }
            top= node;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine("Elements = " + temp.data);
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Top Element is = " + top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            while (top != null)
            {
                Console.WriteLine("Deleted Element = " + top.data);
                top = top.next;
            }
        }

    }
}
