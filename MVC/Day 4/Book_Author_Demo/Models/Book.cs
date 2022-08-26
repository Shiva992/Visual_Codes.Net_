using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Author_Demo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}