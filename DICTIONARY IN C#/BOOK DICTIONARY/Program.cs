using System;
using System.Collections.Generic;


namespace Exercise004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
            Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
            books.Add(senseAndSensibility.name, senseAndSensibility);
            books.Add(prideAndPrejudice.name, prideAndPrejudice);

            PrintValues(books);
            Console.WriteLine("-- -- -- --");
            PrintValueIfNameContains(books, "prejud");
        }

        public static void PrintValues(Dictionary< string, Book > dictionary)
        {
           foreach (KeyValuePair<string, Book> kv in dictionary)
           {
             Console.WriteLine(kv.Value.ToString());
           }

        }
        public static void PrintValueIfNameContains(Dictionary< string, Book > dictionary, string text)
        {

            foreach (KeyValuePair<string, Book> item in dictionary)
            {
                if (item.Value.name.ToLower().Contains(text) || item.Value.name.Contains(text))
                {
                  Console.WriteLine(item.Value);
                }
            }


        }
    }
}
