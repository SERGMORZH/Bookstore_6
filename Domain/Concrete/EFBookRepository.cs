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
    }
}


