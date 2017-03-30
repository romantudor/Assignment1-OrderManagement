using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class OrderDetails
    {
        public int idorder { get; set; }
        public int idproduct { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public int iduser { get; set; }
        public DateTime orderDate { get; set; }
    }
}
