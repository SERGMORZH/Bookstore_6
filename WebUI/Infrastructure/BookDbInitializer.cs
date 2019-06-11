using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Domain.Concrete;
using Domain.Entities;

namespace WebUI.Infrastructure
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            IList<Book> defaultBooks = new List<Book>();

            defaultBooks.Add(new Book { Name = "Язык программирования", Author = "Троелсен", Price = 499m });
            defaultBooks.Add(new Book { Name = "С#", Author = "Уотсон", Price = 149m });
            defaultBooks.Add(new Book { Name = "Асинхронное программирование", Author = "Эелсен", Price = 199m });

            db.Books.AddRange(defaultBooks);

            base.Seed(db);
        }
    }
}