using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKnihy.model
{
    internal class PictureBook:Book
    {

        private String typeBook;
        private int age;
        public PictureBook(String nameBook, String authorBook, int ratingBook, DateTime dateCreateBook, String typeBook, int age)
        :base(nameBook, authorBook, ratingBook, dateCreateBook, BookTypeEnum.picture)
        {
            
            this.typeBook = typeBook;
            this.age = age;
        }





    }
}
