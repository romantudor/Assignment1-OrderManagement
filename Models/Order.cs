using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Order
    {
        public int idOrder { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public DateTime delivery {get;set;}
        public string status { get; set; }

       
    }
}
