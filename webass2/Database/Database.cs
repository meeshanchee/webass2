using Microsoft.EntityFrameworkCore;
using webass2.Models;

namespace webass2.Database
{
    public class database : DbContext
    {
        public database(DbContextOptions<database> dbdatabase) : base(dbdatabase)
        {

        }
        public DbSet<orderdetail> orderdetails { get; set; }
    }
}
