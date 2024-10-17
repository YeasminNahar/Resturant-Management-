using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_
{
    public interface IEntity
    {
        int Itemno { get; set; }
        string ItemName { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        DateTime CreateDate { get; set; }
        String Supplier_Name { get; set; }
        string Email { get; set; }
    }
}
