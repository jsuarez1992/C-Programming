namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here
      private List<Book> books;

      public TextInterface()
      {
        this.books = new List<Book>();
      }
      public void Start()
      {
        while (true)
        {
          Console.WriteLine("Input the name of the book, empty stops:");
          string nameRead = Console.ReadLine();
          if (nameRead=="")
          {
            break;
          }

          Console.WriteLine("Input the age recommendation:");
          string ageRec = Console.ReadLine();
          if (ageRec=="")
          {
            break;
          }

          int age = Convert.ToInt32(ageRec);
          this.books.Add(new Book(nameRead,age));
        }
          Console.WriteLine(books.Count + "books in total.\n \n Books:");
          books.Sort();
          foreach(Book ageRec in this.books)
          {
            Console.WriteLine(ageRec);
          }

      }
    }
}
