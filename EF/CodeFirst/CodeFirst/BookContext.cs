using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
   public class BookContext : DbContext
    {
        public BookContext() : base("name = Bookcontext")
        {
            Database.Log = Console.WriteLine;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publishers> publisher { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .MapToStoredProcedures(b => b.Insert(x => x.HasName("insertbook", "dbo"))
                                            .Update(x => x.HasName("updatebook", "dbo"))
                                            .Delete(x => x.HasName("deletebook", "dbo")));
            
        }
    }
}
