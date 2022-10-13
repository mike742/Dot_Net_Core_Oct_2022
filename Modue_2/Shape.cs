using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modue_2
{
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Rectangle))]
    public class Shape
    {
        [XmlElement]
        public virtual string Name { get; }
        [XmlElement]
        public virtual string Color { get; set; }
        [XmlElement]
        public virtual double Area { get; }
    }
}
