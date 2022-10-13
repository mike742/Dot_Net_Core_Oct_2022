using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modue_2
{
    public class Square : Shape
    {
        public double Size { get; set; }
        public override string Color { get; set; }
        public override string Name => this.GetType().Name;
        public override double Area => Size * Size;
    }
}
