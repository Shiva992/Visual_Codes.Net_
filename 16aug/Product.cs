﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement

{//object of product table
    public class Product
    { 
        
        public  int ProductID { get; set; }
        public string ProductName { get; set; }
        public  int Price { get; set; }
        public int CategoryID { get; set; }

    }
    
}
