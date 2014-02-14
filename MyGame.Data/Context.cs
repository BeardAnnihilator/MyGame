using MyGame.Data.Models;
using System.IO;
using System.Xml.Serialization;

namespace MyGame.Data
{
    internal class Context : IContext
    {
        private static GameEngine _engine;

        public GameEngine Engine
        {
            get
            {
                return _engine = _engine == null ? new GameEngine() : _engine;
            }

            private set
            {
                _engine = value;
            }
        }

        public void Init()
        {
            var serializer = new XmlSerializer(typeof(GameEngine));
            using (var reader = new StreamReader(Resources.XmlFileName))
            {
                try
                {
                    var result = serializer.Deserialize(reader) as GameEngine;
                    if (result != null)
                    {
                        Engine = result;
                    }
                    else
                    {
                        System.Console.WriteLine("Failed initializing data from XML");
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine("Failed initializing data from xml with exception:\n " + ex.Message);
                }
            }
        }

        public void Dispose()
        {
            _engine = null;
        }
    }
}