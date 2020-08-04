using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace SortedListGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Hello");
            sl.Add(2, "Good");
            sl.Add(3, "Morning");
            sl.Add(4, "Likitha");
            foreach(KeyValuePair<int,string> s in sl) // We can also use var
            {
                Console.WriteLine("{0} => {1}",s.Key,s.Value);
            }
            IList<string> il = sl.Values;
            Console.WriteLine("All the values are------------");
            foreach(var i in il)
            {
                Console.WriteLine(i);
            }
            IList<int> ilk = sl.Keys;
            Console.WriteLine("All the Keys are------------");
            foreach (var i in ilk)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count of the sorted list is--------");
            Console.WriteLine(sl.Count);
            Console.WriteLine("Remove at index 0-----------");
            sl.RemoveAt(0);
            IEnumerator ie = sl.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            Console.ReadLine();
           
        }
    }
}
