using System;
using System.Collections.Generic;

namespace Modue_2.DbModel
{
    public partial class OrdersStatus
    {
        public OrdersStatus()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte Id { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
