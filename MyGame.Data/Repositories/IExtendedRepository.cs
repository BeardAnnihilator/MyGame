using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data.Repositories
{
    internal interface IExtendedRepository<T> : IRepository<T>, IAppendable<T>, IRemoveable<T> where T : class
    {
    }
}
