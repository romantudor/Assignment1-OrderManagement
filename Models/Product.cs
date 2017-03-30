using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Product
    {
        public int idproduct { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public int size { get; set; }
        public float price { get; set; }
        public int stock { get; set; }
    }
}
