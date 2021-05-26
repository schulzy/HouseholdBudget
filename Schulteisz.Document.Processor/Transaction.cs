using System;
using System.Collections.Generic;
using System.Text;

namespace Schulteisz.Document.Processor
{
    public class Transaction
    {
        public DateTime BookingDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Partner { get; set; }
        public string CardOwner { get; set; }
        public string CreditorId { get; set; }
        public string RawData { get; set; }
    }
}
