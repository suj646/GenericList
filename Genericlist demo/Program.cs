using System;
using System.Collections.Generic;

namespace Genericlist_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> myList = new List<string>();
            myList.Add("Pankaj");
            myList.Add("vishal");
            myList.Add("sujit");


            foreach (string s in myList)
                Console.Write (s.ToString() + " ");

            
            myList.Sort();
            Console.WriteLine("\n After Sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            
            myList.Remove("Pankaj");
            Console.WriteLine("\nRemoving Pankaj");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

           
            myList.Insert(2, "Pankaj");
            Console.WriteLine("\nInserting Pankaj at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}
    