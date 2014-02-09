using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyGame.Data.Models
{
    public class Player
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string FirstName { get; set; }

        [XmlAttribute]
        public string LastName { get; set; }

        [XmlAttribute]
        public string Email { get; set; }

        [XmlAttribute]
        public decimal Xp { get; set; }
    }
}
