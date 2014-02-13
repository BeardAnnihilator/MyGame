using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data.Repositories
{
    internal interface IRemoveable<T> where T : class
    {
        void Remove(T entity);
    }
}
