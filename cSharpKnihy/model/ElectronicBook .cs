using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKnihy.model
{
    internal class ElectronicBook: Book
    {

        private String brandBook;
        public ElectronicBook(String nameBook, String authorBook, int ratingBook, DateTime dateCreateBook, String brandBook)
            :base(nameBook, authorBook, ratingBook, dateCreateBook, BookTypeEnum.electronics)
        {
           
            this.brandBook = brandBook;
        }

       
    public new String writeBook()
        {
            return base.writeBook() + " brand" + brandBook;
        }



    }
}
