using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_
{
    internal class Item : IEntity
    {
        public int Itemno { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public String Supplier_Name { get; set; }
        public string Email { get; set; }
    }
}
