using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class Item
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string IconId { get; set; }

        [XmlAttribute]
        public string Description { get; set; }

        [XmlElement]
        public UITemplate ElementTemplate { get; set; }
    }

    public class UITemplate
    {
        [XmlElement("UIElement", typeof(UIElement))]
        [XmlElement("UIPlaceholder", typeof(UIPlaceholder))]
        public UIElement Template { get; set; }
    }
}