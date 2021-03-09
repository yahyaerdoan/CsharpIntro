using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramaworkDemo
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
    }
}
