using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class UIPlaceholder : UIElement, IXmlSerializable
    {
        public string AcceptsItems { get; set; }

        public string PlaceholderBehaviour { get; set; }

        public new void ReadXml(System.Xml.XmlReader reader)
        {
            reader.MoveToContent();

            AcceptsItems = reader.GetAttribute(PlaceholderAttributes.AcceptsItems.ToString());
            PlaceholderBehaviour = reader.GetAttribute(PlaceholderAttributes.PlaceholderBehaviour.ToString());

            base.ReadXml(reader);
        }

        public new void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString(PlaceholderAttributes.AcceptsItems.ToString(), AcceptsItems);
            writer.WriteAttributeString(PlaceholderAttributes.PlaceholderBehaviour.ToString(), PlaceholderBehaviour);

            base.WriteXml(writer);
        }

        protected class PlaceholderAttributes : ElementAttributes
        {
            public static readonly PlaceholderAttributes AcceptsItems = new PlaceholderAttributes("AcceptsItems");
            public static readonly PlaceholderAttributes PlaceholderBehaviour = new PlaceholderAttributes("PlaceholderBehaviour");

            public PlaceholderAttributes(string value)
                : base(value)
            {
            }
        }
    }
}