using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_.Repository_pattern
{
    public class ItemRepository : IRepository
    {
        private readonly Dictionary<int, Item> _items = new Dictionary<int, Item>();
        private int _presentId = 1;
        public void Create(IEntity entity)
        {
            var item = entity as Item;
            item.Itemno = _presentId;
            _items[item.Itemno] = item;

        }
        public IEntity Read(int id)
        {
            _items.TryGetValue(id, out var item);
            return item;

        }
        public void Update(IEntity entity)
        {
            var item = entity as Item;
            _items[item.Itemno] = item;
        }
        public void Delete(int id)
        {
            _items.Remove(id);
        }
    }
}
