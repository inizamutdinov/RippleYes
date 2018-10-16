using System;

namespace Dtos
{
    public class AccountDto
    {
        public string account { get; set; }
        public string parent { get; set; }
        public decimal initial_balance { get; set; }
        public string inception { get; set; }
        public int ledger_index { get; set; }
        public string tx_hash { get; set; }
    }
}
