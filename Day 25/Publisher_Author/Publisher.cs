using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Publishers
    {
        public List<Authors> GetAuthorsByState(string state)
        {
            List<Authors> authors = new List<Authors>();
            if (state == "washington")
            {
                authors.Add(new Authors("Adam", "smith"));
                authors.Add(new Authors("Bob", "Jones"));
                authors.Add(new Authors("Fred", "Baker"));
                authors.Add(new Authors("Bill", "Staples"));

            }
            return authors;
        }
    }
}