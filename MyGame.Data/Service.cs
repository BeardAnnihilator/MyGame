using MyGame.Data.Models;
using System;

namespace MyGame.Data
{
    public class Service : IService
    {
        private static IContext _context;
        private static bool _isActive;

        public Service()
        {
            _context = new Context();
        }

        public Models.GameSetting GetSetting()
        {
            var engine = _context.Engine;

            var setting = new GameSetting();
            setting.Id = engine.Id;
            setting.Title = engine.Title;
            setting.GameSpeed = engine.GameSpeed;
            setting.GoogleTrackingCode = engine.GoogleTrackingCode;

            return setting;
        }

        public Models.Player GetPlayer()
        {
            return _context.Engine.Player;
        }

        public Models.Item GetItem(string itemId)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Item> GetItems()
        {
            return _context.Engine.Items;
        }

        public Models.Scene GetScene(string sceneId)
        {
            throw new NotImplementedException(); ;
        }

        public Models.SubScene GetSubScene(string sceneId, string subSceneId)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            _context.Init();
            _isActive = true;
        }

        public void End()
        {
            _isActive = false;
            _context.Dispose();
        }

        public System.Collections.Generic.IEnumerable<Scene> GetScenes()
        {
            return _context.Engine.Scenes;
        }

        public System.Collections.Generic.IEnumerable<SubScene> GetSubScenes(string sceneId)
        {
            throw new NotImplementedException();
        }

        public bool IsActive
        {
            get { return _isActive; }
            private set { _isActive = value; }
        }
    }
}