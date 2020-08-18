using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MangaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MangaBook book1 = new MangaBook("Naruto", "Fantasy", 400, "PG-13" );
            MangaBook book2 = new MangaBook("Bleach", "Fantasy", 200, "NC-17" );
            MangaBook book3 = new MangaBook("One Piece", "Pirate", 100, "R" );
            MangaBook book4 = new MangaBook("7DS", "Medieval", 50, "NC-17" );

            ManhwaBook mbook1 = new ManhwaBook("Tower of God", "Tower Climbing", 700, "R");

            book1.PagesCount();
            book2.PagesCount();
            book3.PagesCount();
            book4.PagesCount();
            
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.genre);
            Console.WriteLine(book1.pages);
            Console.WriteLine(book1.Rating);
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.genre);
            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.Rating);
            Console.WriteLine(book3.title);
            Console.WriteLine(book3.genre);
            Console.WriteLine(book1.pages);
            Console.WriteLine(book3.Rating);
            Console.WriteLine("You have created " + MangaBook.bookCount + " Mangas and Manhwa so far");

            Console.WriteLine(mbook1.title);
            Console.WriteLine(mbook1.genre);
            Console.WriteLine(mbook1.Rating);


            Console.Write("Please input the rating for Naruto");
            book1.Rating = Console.ReadLine();
            Console.WriteLine(book1.Rating);
        }
    }
}
