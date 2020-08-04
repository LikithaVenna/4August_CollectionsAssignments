using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace DictionaryGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dn = new Dictionary<string, string>();
            dn.Add("Likitha","Raj");
            dn.Add("Jaya", "Krishna");
            dn.Add("Tushara", "Vunnava");
            dn.Add("Hema", "Sree");
            Console.WriteLine("--------Elements in Dictionary------------");
            foreach(KeyValuePair<string,string> d in dn)
            {
                Console.WriteLine("{0}->{1}",d.Key,d.Value);
            }
            Console.WriteLine("------------Using ContainsKey--------------");
            if (dn.ContainsKey("Jaya"))
            {
                Console.WriteLine("Contains the specified key");
            }
            else
            {
                Console.WriteLine("Does not contains the specified key");
            }
            Console.WriteLine("------------Using ContainsValue--------------");
            if (dn.ContainsValue("Lakshmi"))
            {
                Console.WriteLine("Contains the specified Value");
            }
            else
            {
                Console.WriteLine("Doesn't Contains the specified Value");
            }
            Dictionary<string, string>.KeyCollection keyColl = dn.Keys;
            Console.WriteLine("-------------Display only Keys-----------");
            foreach (string s in keyColl)
            {
                Console.WriteLine("{0}", s);
            }
            Dictionary<string, string>.ValueCollection valueColl = dn.Values;
            Console.WriteLine("-------------Display only Values-----------");
            foreach (string s in valueColl )
            {
                Console.WriteLine("{0}", s);
            }
            Console.WriteLine("-----------------Remove Key---------------");
            dn.Remove("Likitha");
            if (!dn.ContainsKey("Likitha"))
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("-------------Count of Dictionary-----------");
            Console.WriteLine(dn.Count());
            Console.ReadLine();

        }
    }
}
