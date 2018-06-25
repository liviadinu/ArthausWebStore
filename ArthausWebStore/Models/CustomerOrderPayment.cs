using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class CustomerOrderPayment
    {
        public byte[] Timestamp { get; set; }
        public string DocumentId { get; set; }
        public string StoreNo { get; set; }
        public int LineNo { get; set; }
        public decimal PreApprovedAmount { get; set; }
        public decimal FinalisedAmount { get; set; }
        public string TenderType { get; set; }
        public string CardType { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string AuthorisationCode { get; set; }
        public DateTime PreApprovedValidDate { get; set; }
        public string CardOrCustomerNumber { get; set; }
        public string IncomeExpenseAccountNo { get; set; }
        public decimal PreApprovedAmountLcy { get; set; }
        public decimal FinalisedAmountLcy { get; set; }
        public byte LoyaltyPointPayment { get; set; }
    }
}
