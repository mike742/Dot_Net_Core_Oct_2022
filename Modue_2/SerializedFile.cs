using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modue_2
{
    internal class SerializedFile : IComparable<SerializedFile>
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public int CompareTo(SerializedFile? other)
        {
            return Size.CompareTo(other.Size);
        }
    }
}
