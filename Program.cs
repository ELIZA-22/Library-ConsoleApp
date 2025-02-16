using System.Reflection;
using LibraryApp.Models;

namespace LibraryApp;

class Program
{
    public static Library  library = new Library();
    static void Main(string[] args)
    {
        Initialize(); 
        LibraryFrontDesk();
        
    }
    static void Initialize()
    {

        library = new Library();
        library.AddBook(new List<Book>(){
            new Book (
                title: "Things fall apart",
                author:"Chinua Achebe"
        ),  
            new Book (
                title: "Ralia the sugargirl",
                author:"Oyekanmi"
        
        )
        });
        library.AddJournal(new List<Journal>(){
            new Journal(
                publishedBy :"Bloomberg", 
                datePublished: DateTime.Parse("01/01/2024"),
                title: "The future of finance",
                author:"chisom oke"
        ),  
            new Journal (
                publishedBy :"NY Times", 
                datePublished: DateTime.Parse("01/08/2024"),
                title: "The world after covid",
                author:"Sundra Kobe"
        
        )
        });
        library.AddFilm(new List<Film>(){
            new Film(
                title: "ori",
                storageType: StorageType.DVD,
                producedby:"Muyiwa Ademola "
        ),  
            new Film (
                title: "Fantasy reel",
                storageType: StorageType.CD,
                producedby:"George Bush"
        
        )
        });
    }

    static void LibraryFrontDesk()
    {
        Console.WriteLine("Welcome to Dev library \n  The following are the options available in the library \n" );
        Console.WriteLine("Options\n Enter 1 to view list of books\n Enter 2 to view list of Journals\n Enter 3 to view list of film \n" );
        var optionSelected = Console.ReadLine();
        if(optionSelected == "1")
        {  library.ListAllBooks();
            Console.WriteLine("The following are the books available in the library \n" );
        }
        else if(optionSelected == "2")
        {  library.ListAllJournals();
            Console.WriteLine("The following are the Journals available in the library \n" );
        }
        else if(optionSelected == "3")
        {  library.ListAllFilms();
            Console.WriteLine("The following are the films available in the library \n" );
        }
        else
        {
            Console.WriteLine("Invalid option selected \n" );
        }
       
       
    }
}
