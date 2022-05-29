using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKnihy.model
{
    internal class ClassicalBook: Book
    {


        private int countPage;
        public ClassicalBook(String nameBook, String authorBook, int ratingBook, DateTime dateCreateBook, int countPage):base(nameBook, authorBook, ratingBook, dateCreateBook, BookTypeEnum.classical)
        {
            
            this.countPage = countPage;
        }


     
    public new String writeBook()
        {

            String text = base.writeBook() + "clascic" + countPage;
            return text;
        }

        public String writeBook(String test)
        {

            return test + " +++++ " + countPage + "---" + authorBook;
        }



    }
}
