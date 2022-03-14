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
            Author author = new Author() { Name = "Aziz Nesin" };
            Category category = new Category() { Name = "Roman" };
            Book story = new Book() { Name = "Zübük", CategoryId = 1, AuthorId = 1,NumberOfPages = 100};

            
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            AuthorManager authorManager = new AuthorManager(new AuthorDal());
            BookManager bookManager = new BookManager(new BookDal());

            var items = categoryManager.GetAll();
            foreach (var item in items)
            {
                System.Console.WriteLine(items.Count + item.Name);
            }

        }
    }
}
