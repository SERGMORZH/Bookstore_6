using System.Collections.Generic;
using Domain.Entities;
using Domain.Abstract;

namespace Domain.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        BookContext context = new BookContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }

        public List<Book> PagedBooks(int pageNumber)
        {
            return null;


        }
        public void SaveBook(Book book)
        {
            if (book.BookId == 0)
                context.Books.Add(book);
            else
            {
                Book dbEntry = context.Books.Find(book.BookId);
                if (dbEntry != null)
                {
                    dbEntry.Name = book.Name;
                    dbEntry.Author = book.Author;
                    dbEntry.Description = book.Description;
                    dbEntry.Price = book.Price;
                    dbEntry.Category = book.Category;
                }
            }
            context.SaveChanges();

        }
    }
}


