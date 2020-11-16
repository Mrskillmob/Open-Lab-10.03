using System;

namespace Open_Lab_10._00
{
    public class Book
    {
        string title;
        int pages;
        string category;
        string author;
        int releaseDate;    


        public int Release
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1450 || value > 2021)
                {
                    releaseDate = -1;

                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public int pag
        {
            get
            {
                return pages;
            }
            set
            {
                if(value <0)
                {
                    pages = -1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string nazov
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string kat
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string aut
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            Book LOTR = new Book();
            LOTR.aut = "Tolkien";
            LOTR.kat = "Fantasy";
            LOTR.nazov = "Lord of The Rings";
            LOTR.pag = 200;
            LOTR.Release = 1499;

            Console.WriteLine("Book " + LOTR.nazov + " was written in " + LOTR.Release + " and has " + LOTR.pag +" pages.");
            Console.WriteLine("It was written by: " + LOTR.aut + " and its category is " + LOTR.kat + ".");



        }

    }







}
