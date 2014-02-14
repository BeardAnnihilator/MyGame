using MyGame.Data.Models;
using System.Collections.Generic;

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

        bool IsActive { get; }
    }
}