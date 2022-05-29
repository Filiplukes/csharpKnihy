using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpKnihy.model;

namespace cSharpKnihy
{
    internal class BookFactory
    {
        public static Book createNewBook(String nameBook, String authorBook, int ratingBook, int countPage)
        {
            ClassicalBook newBook = null;
            DateTime dateCreateBook = DateTime.Now;
            newBook = new ClassicalBook(nameBook, authorBook, ratingBook, dateCreateBook, countPage);
            return newBook;
        }
        public static Book createNewBook(String nameBook, String authorBook, int ratingBook, String brandBook)
        {
            ElectronicBook newBook = null;
            DateTime dateCreateBook = DateTime.Now;
            newBook = new ElectronicBook(nameBook, authorBook, ratingBook, dateCreateBook, brandBook);
            return newBook;
        }

        public static Book createNewBook(String nameBook, String authorBook, int ratingBook, String typeBook, int age)
        {
            PictureBook newBook = null;         
            DateTime dateCreateBook = DateTime.Now;
            newBook = new PictureBook(nameBook, authorBook, ratingBook, dateCreateBook, typeBook, age);
            return newBook;
        }






    }

    internal class PictrureBook
    {
    }
}
