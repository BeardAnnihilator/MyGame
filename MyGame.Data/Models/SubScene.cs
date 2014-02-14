using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class SubScene
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string Title { get; set; }

        [XmlArray]
        [XmlArrayItem("UIPlaceholder", typeof(UIPlaceholder))]
        [XmlArrayItem("UIElement", typeof(UIElement))]
        public List<UIElement> UIElements { get; set; }
    }
}