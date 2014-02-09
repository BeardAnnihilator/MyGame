using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    [XmlRoot]
    public class GameEngine
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string Title { get; set; }

        [XmlAttribute]
        public int GameSpeed { get; set; }

        [XmlAttribute]
        public string GoogleTrackingCode { get; set; }

        [XmlElement]
        public Player Player { get; set; }

        [XmlArray]
        [XmlArrayItem(typeof(Item))]
        public List<Item> Items { get; set; }

        [XmlArray]
        [XmlArrayItem(typeof(Scene))]
        public List<Scene> Scenes { get; set; }
    }
}