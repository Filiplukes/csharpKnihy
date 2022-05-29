// See https://aka.ms/new-console-template for more information

using cSharpKnihy;
using cSharpKnihy.model;

ClassicalBook rbitov = (ClassicalBook)BookFactory.createNewBook("rbitov zviratek", "King", 5, 352);
Console.WriteLine(rbitov.writeBook());
Console.WriteLine(rbitov.writeBook("asd"));
ElectronicBook elBook = (ElectronicBook)BookFactory.createNewBook("ELk kniha", "test", 5, "nejakaelk");
Console.WriteLine(elBook.writeBook());
PictureBook picBook = (PictureBook)BookFactory.createNewBook("obrazkova", "King", 4, "dospela", 18);
Console.WriteLine(picBook.writeBook());