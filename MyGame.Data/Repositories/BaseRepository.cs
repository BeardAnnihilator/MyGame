using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data.Repositories
{
    internal class BaseRepository
    {
        protected internal IContext Context { get; set; }

        internal BaseRepository(IContext context)
        {
            Context = context;
        }
    }
}
