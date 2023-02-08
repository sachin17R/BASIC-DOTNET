using System;//Default APIs
using Entities;//For the Entity class
using Repository;//Repo class
using SampleConApp; //Utilities
namespace Entities
{
   public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int BookStock { get; set; } = 10;

        public void ShallowCopy(Book copy)
        {
            this.BookId = copy.BookId;
            this.BookStock = copy.BookStock;
            this.BookTitle = copy.BookTitle;
            this.Price = copy.Price;
            this.Publisher = copy.Publisher;
            this.Author = copy.Author;
        }

        public Book DeepCopy(Book copy)
        {
            Book book = new Book();
            book.ShallowCopy(copy);
            return book;
        }
    }
}
//datatype [] identifier = new datatype[size]
namespace Repository
{
    class BookRepository
    {
        private Entities.Book[] _books = null;
        private readonly int _size = 0;
        public BookRepository(int size)
        {
            _size = size;
            _books = new Entities.Book[_size];
        }

        public int AddNewBook(Entities.Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = book.DeepCopy(book);
                    return 1;//To exit
                }
            }
            return _size;
        }

        public void UpdateBook(Entities.Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == book.BookId)
                {
                    _books[i].ShallowCopy(book);
                    return;//To exit
                }
            }
            throw new Exception("No book found to update");
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == id)
                {
                    _books[i] = null;
                    return;//To exit
                }
            }
            throw new Exception("No book found to remove");
        }

        public Entities.Book[] FindByAuthor(string author)
        {
            int count = 0;
            foreach (Entities.Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    count += 1;
                }
            }
            Entities.Book[] books = new Entities.Book[count];
            count = 0;
            foreach (Entities.Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }

        public Entities.Book[] FindByTitle(string title)
        {
            int count = 0;
            foreach (Entities.Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    count += 1;
                }
            }
            Entities.Book[] books = new Entities.Book[count];
            count = 0;
            foreach (Entities.Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }
    }
}

namespace UILayer
{
    class UIComponent
    {
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~BOOK STORE MANAGER SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW BOOK------------------------>PRESS 1\nTO UPDATE EXISTING BOOK---------------->PRESS 2\nTO FIND BOOK BY AUTHOR----------------->PRESS 3\nTO FIND BOOK BY TITLE------------------>PRESS 4\nTO DELETE BOOK------------------------->PRESS 5\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

        private static BookRepository repo;

        public static void Run()
        {
            int size = Utilities.GetNumber("Enter the no of Books U need for the Store");
            repo = new BookRepository(size);
            bool processing = true;
            do
            {
                string choice = Utilities.Prompt(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddBookManager();
                    break;
                case "2":
                    UpdateBookManager();
                    break;
                case "3":
                    FindByAutorManager();
                    break;
                case "4":
                    FindByTitleManager();
                    break;
                case "5":
                    DeleteBookManager();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void AddBookManager()
        {
            int Id1 = Utilities.GetNumber("enter the Id of the Book");
            string Title1 = Utilities.Prompt("enter title of the Book");
            string Author1 = Utilities.Prompt("enter the author name");
            string Publisher1 = Utilities.Prompt("enter the publisher name");
            double Price1 = Utilities.GetNumber("enter the price of book");

            Entities.Book books1 = new Entities.Book { BookId = Id1, BookTitle = Title1, Author = Author1, Publisher = Publisher1, Price = Price1 };
            repo.AddNewBook(books1);
            Console.WriteLine("your book is added");
            Utilities.Prompt("press enter to clear the screen");
            Console.Clear();
        }
        private static void UpdateBookManager()
        {
            int Id1 = Utilities.GetNumber("enter the Id of the Book");
            string Title1 = Utilities.Prompt("enter title of the Book");
            string Author1 = Utilities.Prompt("enter the author name");
            string Publisher1 = Utilities.Prompt("enter the publisher name");
            double Price1 = Utilities.GetNumber("enter the price of book");

            Entities.Book books1 = new Entities.Book { BookId = Id1, BookTitle = Title1, Author = Author1, Publisher = Publisher1, Price = Price1 };
            repo.UpdateBook(books1);
            Console.WriteLine("your book is updated");
            Utilities.Prompt("press enter to clear the screen");
            Console.Clear();
        }
        private static void DeleteBookManager()
        {
            int id = Utilities.GetNumber("enter the BookId you want to delete");
            repo.RemoveBook(id);
            Console.WriteLine("your book is Deleted");
            Utilities.Prompt("press enter to clear the screen");
            Console.Clear();
        }
        private static void FindByAutorManager()
        {
            string author = Utilities.Prompt("enter the author name for the Book");
            Entities.Book[] details = repo.FindByAuthor(author);
            foreach (var item in details)
            {
                string content = $"Book id :{item.BookId}\nBook Title :{item.BookTitle}\nBook Price{item.Price}\nBook publisher:{item.Publisher}";
                Console.WriteLine(content);
                Console.WriteLine();
            }
            Console.WriteLine("your Book is founded");
            Utilities.Prompt("press enter to clear the screen");
            Console.Clear();

        }
        private static void FindByTitleManager()
        {
            string Title = Utilities.Prompt("enter the author name for the Book");
            Entities.Book[] details = repo.FindByAuthor(Title);
            foreach (var item in details)
            {
                string content = $"Book id :{item.BookId}\nBook Title :{item.Author}\nBook Price{item.Price}\nBook publisher:{item.Publisher}";
                Console.WriteLine(content);
                Console.WriteLine();
               
            }
            Console.WriteLine("your Book is founded");
            Utilities.Prompt("press enter to clear the screen");
            Console.Clear();
        }

    }
}

namespace TestingApp
{
    using Repository;
    using SampleConApp;
    using System;


    class App
    {
        static void Main(string[] args)
        {
            UILayer.UIComponent.Run();
        }
    }
}
