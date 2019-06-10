using Domain.Entities;
using System.Data.Entity;

namespace Domain.Concrete
{
    public class BookContext : DbContext
    {
     
        public DbSet<Book> Books { get; set; }
    }
}
