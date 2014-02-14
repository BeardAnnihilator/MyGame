using MyGame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Design
{
    public class DesignDataService : IService
    {
        public Data.Models.GameSetting GetSetting()
        {
            throw new NotImplementedException();
        }

        public Data.Models.Player GetPlayer()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Models.Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public Data.Models.Item GetItem(string itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Models.Scene> GetScenes()
        {
            throw new NotImplementedException();
        }

        public Data.Models.Scene GetScene(string sceneId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Models.SubScene> GetSubScenes(string sceneId)
        {
            throw new NotImplementedException();
        }

        public Data.Models.SubScene GetSubScene(string sceneId, string subSceneId)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }
    }
}
