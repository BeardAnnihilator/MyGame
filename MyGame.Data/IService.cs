using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Data
{
    public interface IService
    {
        GameSetting GetSetting();
        
        Player GetPlayer();

        IEnumerable<Item> GetItems();

        Item GetItem(string itemId);

        IEnumerable<Scene> GetScenes();

        Scene GetScene(string sceneId);
        
        IEnumerable<SubScene> GetSubScenes(string sceneId);

        SubScene GetSubScene(string sceneId, string subSceneId);

        void Start();

        void End();
    }
}
