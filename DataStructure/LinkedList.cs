using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        Node head;

        public void AddNode(int data)
        {

            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linkedList", node.data);
        }

        public void Display()
        {
            if(head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list Contains: ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Linked List Contains : ");
                Console.ResetColor();
                Node tempnode = head;
                while( tempnode != null )
                {

                    Console.WriteLine(tempnode.data + " ");
                    tempnode = tempnode.Next;
                }
            }
        }

        public void ReverseList()
        {
            Node prev = null, temp = head, next = null;

            while( temp != null )
            {
                next = temp.Next;
                temp.Next = prev;
                prev = temp;
                temp = next;
            }
            head = prev; 
        }

        public void Display2()
        {
            Node temp = head;
            while( (temp != null) )
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.Next;
            }
        }

        public Node InserAtParticularPosition(int position, int data)
        {
            if(position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if(position == 1)
            {
                var newNode = new Node(data);
                newNode.Next = this.head;
                head = newNode;
            }
            else
            {
                while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.Next = this.head.Next;
                        head.Next = node;
                        break;
                    }
                    head = head.Next;
                }
                if(position != 1)
                {
                    Console.WriteLine("posiiton is out of range");
                }
            }
            return head;
        }


        public Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.Next;
            return this.head;
        }

    }
}
