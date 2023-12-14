using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;


namespace WebApplication4
{
    public class DBcontext: DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

    }
}
