using System;
using System.Collections.Generic;
using System.Text;

namespace MangaConsoleApp
{
    public class Book
    {

        public string title;
        public string genre;
        public int pages;
        private string rating;
        public static int bookCount = 0;

        public Book(string title, string genre, int pages, string rating)
        {
            this.title = title;
            this.genre = genre;
            this.pages = pages;
            this.rating = rating;
            bookCount++;
        }

        public void PagesCount()
        {
            if (pages >= 400)
            {
                Console.WriteLine("is a big Book");
            }
            else
            {
                Console.WriteLine("is a small Book ");
            }
        }  
        

        public string Rating
        {
            get
            {
                return rating;
            }
            set 
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NC-17")
                {
                    rating = value;
                }
                else
                {
                    rating = "NG";
                }
            }
        }
    }
}