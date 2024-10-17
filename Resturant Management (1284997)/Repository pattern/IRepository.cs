using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_.Repository_pattern
{
    public interface IRepository
    {
        void Create(IEntity entity);
        IEntity Read(int id);
        void Update(IEntity entity);
        void Delete(int id);

    }
}
