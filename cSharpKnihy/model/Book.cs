using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpKnihy.model;

namespace cSharpKnihy
{
    public abstract class Book: BoookInterface
    {

    protected String nameBook;
    protected String authorBook;
    protected int ratingBook;
    protected BookTypeEnum bookType;
    protected DateTime dateCreateBook;


    public Book(string nameBook, String authorBook, int ratingBook, DateTime dateCreateBook, BookTypeEnum bookType)
    {
        this.nameBook = nameBook;
        this.authorBook = authorBook;
        this.ratingBook = ratingBook;
        this.dateCreateBook = dateCreateBook;
        this.bookType = bookType;
    }


    public String writeBook()
    {

        return nameBook + "," + authorBook + "," + ratingBook + "," + dateCreateBook + "," + bookType;

    }

    public void addBook()
    {

    }


    public Book getBook()
    {
        return null;
    }


    public void updateBook()
    {


    }
}
}
