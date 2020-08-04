using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Hello", "this", "is", "Likitha", "Raj" };
            LinkedList<string> ll = new LinkedList<string>(str);
            LinkedList<string>.Enumerator le = ll.GetEnumerator();
            Console.WriteLine("--------Elements in LinkedList----------");
            while (le.MoveNext())
            {
                Console.Write(" "+le.Current);
            }
            Console.WriteLine("\n");
            Console.WriteLine("---------After Adding element at first-----------");
            ll.AddFirst("Hi");
            foreach(var k in ll)
            {
                Console.Write(" "+k);
            }
            Console.WriteLine("\n");
            Console.WriteLine("---------After Adding element at Last-----------");
            ll.AddLast("How");
            ll.AddLast("are");
            ll.AddLast("you?");
            ll.AddLast("Hello");
            foreach (var l in ll)
            {
                Console.Write(" "+l);
            }
            Console.WriteLine("\n");
            Console.WriteLine("------------First Element in Linked List---------");
            Console.WriteLine(ll.First());
            Console.WriteLine("------------Last Element in Linked List---------");
            Console.WriteLine(ll.Last());
            Console.WriteLine("-------------Find Value----------");
            LinkedListNode<String> f = ll.Find("are");
            Console.WriteLine(f.Value);
            Console.WriteLine("-------------FindLast Value----------");
            LinkedListNode<String> fl =  ll.FindLast("Hello");
            Console.WriteLine(fl.Value);
            Console.WriteLine("----------Adding element after node----------");
            var newNode = ll.AddLast("What");
            ll.AddAfter(newNode, "are");
            foreach(var n in ll)
            { 
                Console.Write(" "+n);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------Adding element before node----------");
            var newNode1 = ll.AddLast("doing?");
            ll.AddBefore(newNode1, "you");
            foreach (var c in ll)
            {
                Console.Write(" "+c);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------Count of Linked List-----------");
            Console.WriteLine(ll.Count());
            Console.WriteLine("----------Remove first element of Linked List--------");
            ll.RemoveFirst();
            foreach(var m in ll)
            {
                Console.Write(" "+m);
            }
            Console.ReadLine();
        }
    }
}
