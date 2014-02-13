using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data.Repositories
{
    internal class GameSettingRepository : BaseRepository , IRepository<GameSetting>
    {
        private readonly GameSetting _setting;

        public GameSettingRepository(IContext context) : base(context)
        {
            var engine = Context.Engine;

            _setting = new GameSetting();
            _setting.Id = engine.Id;
            _setting.Title = engine.Title;
            _setting.GameSpeed = engine.GameSpeed;
            _setting.GoogleTrackingCode = engine.GoogleTrackingCode;
        }

        public GameSetting Get()
        {
            return _setting;
        }

        public void Update(GameSetting entity)
        {
            _setting.Id = entity.Id;
            _setting.Title = entity.Title;
            _setting.GameSpeed = entity.GameSpeed;
            _setting.GoogleTrackingCode = entity.GoogleTrackingCode;
        }
    }
}
