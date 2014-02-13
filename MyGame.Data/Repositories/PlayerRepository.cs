using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data.Repositories
{
    internal class PlayerRepository : BaseRepository, IRepository<Player>
    {
        private readonly Player _player;
        
        internal PlayerRepository(IContext context): base(context)
        {
            _player = context.Engine.Player;
        }

        public Player Get()
        {
            return _player;
        }

        public void Update(Player entity)
        {
            _player.Id = entity.Id;
            _player.Email = entity.Email;
            _player.FirstName = entity.FirstName;
            _player.LastName = entity.LastName;
            _player.Xp = entity.Xp;
        }
    }
}
