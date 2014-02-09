using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class UIBase
    {
        //public virtual string Id { get; set; }

        
        //public virtual string ItemId { get; set; }

        
        //public virtual bool IsDraggable { get; set; }

        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string ItemId { get; set; }

        [XmlAttribute]
        public bool IsDraggable { get; set; }

    }
}
