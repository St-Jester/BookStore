using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStoreClessLibrary;

namespace BookStoreHost
{
    class DataManager : DbContext
    {
        public DataManager() : base("connection1")
        { }

        public DbSet<Genre> genres { get;set;}
        public DbSet<Author> authors { get; set; }
     
        public DbSet<Book> books { get; set; }
    }
}
