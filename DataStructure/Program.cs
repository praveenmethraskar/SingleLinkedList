﻿using System;

namespace DataStructure
{

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.AddNode(56);
            //l1.AddNode(30);
            l1.AddNode(70);
            l1.Display();

            l1.InserAtParticularPosition(2, 30);
            l1.Display();
            //l1.ReverseList();
            //l1.Display2();
            l1.RemoveFirstNode();
            Console.WriteLine("removed first node");
            l1.Display();
        }

    }
}