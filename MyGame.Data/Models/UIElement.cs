using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class UIElement : IXmlSerializable
    {
        public string Id { get; set; }

        public string ItemId { get; set; }

        public bool IsDraggable { get; set; }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            reader.MoveToContent();

            Id = reader.GetAttribute(ElementAttributes.Id.ToString());

            ItemId = reader.GetAttribute(ElementAttributes.ItemId.ToString());

            bool isDraggable;
            bool.TryParse(reader.GetAttribute(ElementAttributes.IsDraggable.ToString()), out isDraggable);
            IsDraggable = isDraggable;

            reader.ReadStartElement();
        }

        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString(ElementAttributes.Id.ToString(), Id);
            writer.WriteAttributeString(ElementAttributes.ItemId.ToString(), ItemId);
            writer.WriteAttributeString(ElementAttributes.IsDraggable.ToString(), IsDraggable.ToString());
        }

        protected class ElementAttributes
        {
            public static readonly ElementAttributes Id = new ElementAttributes("Id");
            public static readonly ElementAttributes ItemId = new ElementAttributes("ItemId");
            public static readonly ElementAttributes IsDraggable = new ElementAttributes("IsDraggable");

            public override string ToString()
            {
                return Value;
            }

            protected ElementAttributes(string value)
            {
                this.Value = value;
            }

            public string Value { get; private set; }
        }
    }
}