using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        #region collpse

        static void Main(string[] args)
        {// creating a hash table
            Hashtable hashme = new Hashtable();
            hashme.Add(12,79);
            hashme.Add(13, "welcome");
            hashme.Add(1, "consumer");
            hashme.Add(7, "woven");
            hashme.Add(2, "cooperative");
            hashme.Add(9, 79);
            //iterating through the array list elements
            foreach (DictionaryEntry i in hashme)
            {
                Console.WriteLine("Key: {0}, Value :{1}",i.Key,i.Value);
            }

            //creating an array Lits
            ArrayList sr = new ArrayList() { 12, "names","true", 78,"forester"};

            // adding an element to our created Arraylist
        #endregion
            sr.Add(12);
            Tuple<int, string, int, string> names = new Tuple<int, string, int, string>(30, "steve", 78, "my name");
            Console.WriteLine(names.Item1);
            foreach (object s in sr)
            {


                Console.WriteLine("{0}",s);
            }
            // Rememeber the general class we created // Generate.cs
            General<int, string> objg = new General<int, string>();
            int num = objg.add(12);
            string name = objg.val="my name";
            Console.WriteLine(name);
            Console.WriteLine(num);
      
            // adding elements to a list
            List <int> ls = new List <int>();
            ls.Add(12);
            ls.Add(127);
            ls.Add(142); 
            ls.Add(312);
            ls.Insert(3, 70);
            //printing elements in a list on the screen
           Console.WriteLine(ls.Contains(70));
            foreach (int s in ls)
            {
                Console.WriteLine("value at {0} is {1}", ls.IndexOf(s), s);
            }
         // creating a new list
            List<int> nul = new List<int>();
           
            nul.AddRange(ls);
            
            nul.Add(78);
            nul.Add(708);
            nul.Add(878);
            nul.Add(1278);
            nul.Remove(4);
            // iterating through the list elements
            foreach (int n in nul)
            {
                Console.WriteLine("value at {0} is {1}", ls.IndexOf(n), n);
            }

            //Creating a dictionary
            Console.WriteLine("------------Dictionary---------------");
            Dictionary<int, string> mydefs = new Dictionary<int, string>();
            mydefs.Add(1, "Nairobi");
            mydefs.Add(3, "Mombasa");
            mydefs.Add(2, "Kisumu");
            mydefs.Add(4, "Naikuru");
                mydefs.Add(5, "kericho");
            //iterating through the elements in the dictionary
                foreach (KeyValuePair<int,string> s in mydefs)
                {
                    Console.WriteLine("key {0}: Value{1}",s.Key,s.Value);
                }
            //creating a sorted List
                SortedList<int, string> mdefs = new SortedList<int, string>();
                mdefs.Add(1, "Nairobi");
                mdefs.Add(3, "Mombasa");
                mdefs.Add(2, "Kisumu");
                mdefs.Add(4, "Naikuru");
                mdefs.Add(5, "kericho");
                Console.WriteLine("------------Sorted List---------------");
                foreach (KeyValuePair<int, string> s in mdefs)
                {
                    Console.WriteLine("key {0}: Value{1}", s.Key, s.Value);
                }
               // Console.WriteLine(mydefs.Contains("Kajiao"));
        
               Console.ReadKey();
            }
        }
    }

