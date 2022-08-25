using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Exams
{
    class Program
    {
        static void Main()
        {
            NodirList<int> list = new NodirList<int>();

            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");
        }
        public class NodirList<T>
        {
            private class Node
            {
                private Node? next;
                public Node? Next 
                { 
                    get { return next; }
                    set { next = value; }
                }
                private T data;
                public T Data
                {
                    get { return data; }
                    set { data = value; }
                }
                public Node(T t)
                {
                    data = t;
                    next = null;
                }
            }
            private Node? head;
            public NodirList()
            {
                head = null;
            }
            public void Add(T t)
            {
                Node item = new Node(t);
                item.Next = head;
                head = item;
            }
            public IEnumerator<T> GetEnumerator()
            {
                Node? current = head;
                while(current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }
        
    }
}





























