using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthElementFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.pushElement(5);
            linkedlist.pushElement(15);
            linkedlist.pushElement(52);
            linkedlist.pushElement(51);
            linkedlist.pushElement(56);

            linkedlist.printNthFromEnd(2);
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class LinkedList
    {
        public Node head;

        public void pushElement(int newdata)
        {
            Node newNode = new Node(newdata);

            newNode.next = head;

            head = newNode;

        }

        public void printNthFromEnd(int n)
        {
            int length = 0;
            Node tempNode = head;

            //loop through linkedlist and find the length
            while (tempNode != null)
            {
                tempNode = tempNode.next;
                length++;
            }

            if (length < n) return;

            tempNode = head;

            //loop through list and 
            for (int i = 1; i < length - n + 1; i++)
            {
                tempNode = tempNode.next;
            }

            Console.WriteLine(tempNode.data);
        }

    }


}
