using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public partial class Account
    {
        public Guid Id { get; set; }
        public int AccountType { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly DueDate { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Balance { get; set; }
        public string UserId { get; set; }
    }
}
