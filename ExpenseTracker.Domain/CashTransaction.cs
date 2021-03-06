using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Domain
{
    public class CashTransaction
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int TransactionType { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
