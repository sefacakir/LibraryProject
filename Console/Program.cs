using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Author author = new Author() { Name = "Aziz Nesin" };
            Category category = new Category() { Name = "Roman" };
            Book story = new Book() { Name = "Zübük", CategoryId = 1, AuthorId = 1,NumberOfPages = 100};

            
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //categoryManager.Add(category);

            AuthorManager authorManager = new AuthorManager(new AuthorDal());
            //authorManager.Add(author);
            var authors = authorManager.GetAll();

            BookManager bookManager = new BookManager(new BookDal());
            var books = bookManager.GetAll();
            foreach (var book in books)
            {
                System.Console.WriteLine(book.Name);
            }*/

            System.Console.WriteLine("Test");

        }
    }
}
