using System;
using System.Collections.Generic;

namespace Modue_2.DbModel
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public sbyte Id { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
