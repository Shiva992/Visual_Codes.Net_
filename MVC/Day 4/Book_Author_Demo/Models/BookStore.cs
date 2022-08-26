using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Book_Author_Demo.Models;


namespace Book_Author_Demo.Models
{
   
        public class BookStore : DbContext
        {
            public BookStore() : base("BookStore")
            {

            }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Book> Books { get; set; }
        }

    }
