using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Domain
{
    public class Cash
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<CashTransaction> CashTransactions { get; set; }
    }
}
