using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Models;

namespace LibraryApp
{
     class Library
    {
        //create a list called book
       private List<Book> Books;
       private List<Journal> Journals;
       private List<Film> Films;
       public Library()
       {
        Books = new List<Book>();
        Journals = new List<Journal>();
        Films = new List<Film>();
       }
       public void AddBook(IList<Book> booksToAdd)
       {
          Books.AddRange(booksToAdd);

       }
       public void AddBook(Book booksToAdd)
       {
          Books.Add(booksToAdd);

       }
       public void AddJournal(IList<Journal> journalsToAdd)
      {
          Journals.AddRange(journalsToAdd);
      }
       public void AddJournal(Journal journalsToAdd)
      {
          Journals.Add(journalsToAdd);
      }
        public void AddFilm(IList<Film> filmsToAdd)
       {
          Films.AddRange(filmsToAdd);

       }
          public void AddFilm(Film filmsToAdd)
       {
          Films.Add(filmsToAdd);

       }
        /// <summary>
        /// Lists all the books available in the library.
        /// </summary>
         public void ListAllBooks()
         {

             Console.ForegroundColor = ConsoleColor.Yellow;
                for (var i =0; i< Books.Count ; i++)
                {
                    Console.WriteLine($"{i+1}. {Books[i]. ToString()}");
                }
            Console.ResetColor();
         }
          public void ListAllJournals()

         {
            Console.ForegroundColor = ConsoleColor.DarkRed;
                for (var i =0; i< Journals.Count ; i++)
                {
                    Console.WriteLine($"{i+1}. {Journals[i]. ToString()}");
                }
            Console.ResetColor();
         }
          public void ListAllFilms()
         {  
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (var i =0; i< Films.Count ; i++)
                {
                    Console.WriteLine($"{i+1}. {Films[i]. ToString()}");
                }
            Console.ResetColor();
         }
    }
}