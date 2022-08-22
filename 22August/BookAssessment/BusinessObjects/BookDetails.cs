using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class BookDetails
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Aurthor { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
    }
}
