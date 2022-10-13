using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modue_2
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string Color { get; set; }
        public override string Name => this.GetType().Name;
        public override double Area => Width * Height;
    }
}
