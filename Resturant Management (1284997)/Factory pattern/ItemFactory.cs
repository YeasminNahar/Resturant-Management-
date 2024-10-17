using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_
{
    public class ItemFactory : IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new Item();
        }
    }
}
