using System;
using System.Collections.Generic;

namespace Modue_2.DbModel
{
    public partial class OrdersTaxStatus
    {
        public OrdersTaxStatus()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte Id { get; set; }
        public string TaxStatusName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
