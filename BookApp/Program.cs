using System;

namespace BookApp
{
    class Book
    {
        public Content MyCont { get; set; }
        public Title MyTitle { get; set; }
        public Author MyAuthor { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            MyTitle.Show();
            Console.ForegroundColor = ConsoleColor.Cyan;
            MyAuthor.Show();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            MyCont.Show();
        }
        public Book()
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
        }
        public Book(string autName,string bookTitle,string bookContent)
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
            MyCont.BookContent = bookContent;
            MyAuthor.AutName = autName;
            MyTitle.BookName = bookTitle;
        }
    }
    class Title
    {
        public string BookName { get; set; }
        public void Show()
        {
            Console.WriteLine("Название книги: "+BookName);
        }
    }
    class Author
    {
        public string AutName { get; set; }
        public void Show()
        {
            Console.WriteLine("Автор книги: "+AutName);
        }
    }
    class Content
    {
        public string BookContent { get; set; }
        public void Show()
        {
            Console.WriteLine("Содержание книги: "+BookContent);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            Console.WriteLine("Введите название книги и её автора через знак доллара:");
            string[] input = Console.ReadLine().Split('$');
            Console.WriteLine("Введите содержание книги: ");
            string content = Console.ReadLine();
            book = new Book(input[1],input[0],content);
            book.Show();
        }
    }
}
