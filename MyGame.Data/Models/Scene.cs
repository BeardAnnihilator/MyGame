using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class Scene
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string Title { get; set; }

        [XmlArray("SubScenes")]
        [XmlArrayItem("SubScene")]
        public List<SubScene> SubScenes { get; set; }
    }
}