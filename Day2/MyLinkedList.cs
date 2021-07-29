using System;
using System.Collections.Generic;

namespace Day2
{
    public class MyLinkedList
    {
        public static void LinkedListDemo()
        {
            // Linkedlists cannot take in values directly. It takes in nodes which takes in the values
            
            LinkedList<int> llist = new LinkedList<int>{};
            LinkedListNode<int> Firstnode = llist.AddFirst(2);

            var c = Firstnode.Value;
            var newFirstNode = new LinkedListNode<int>(5);

            llist.AddBefore(Firstnode,newFirstNode);
            var y = llist.First.Value;

            var LastNode = new LinkedListNode<int>(6);
            llist.AddLast(LastNode);

            var b = llist.Last.Value;

            // llist.Remove(Firstnode);
            // llist.Find(2);

            foreach (var item in llist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
        }
    }
}
