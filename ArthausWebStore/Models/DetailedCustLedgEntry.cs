﻿using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class DetailedCustLedgEntry
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public int CustLedgerEntryNo { get; set; }
        public int EntryType { get; set; }
        public DateTime PostingDate { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountLcy { get; set; }
        public string CustomerNo { get; set; }
        public string CurrencyCode { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public int TransactionNo { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal DebitAmountLcy { get; set; }
        public decimal CreditAmountLcy { get; set; }
        public DateTime InitialEntryDueDate { get; set; }
        public string InitialEntryGlobalDim1 { get; set; }
        public string InitialEntryGlobalDim2 { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public byte UseTax { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string VatProdPostingGroup { get; set; }
        public int InitialDocumentType { get; set; }
        public int AppliedCustLedgerEntryNo { get; set; }
        public byte Unapplied { get; set; }
        public int UnappliedByEntryNo { get; set; }
        public decimal RemainingPmtDiscPossible { get; set; }
        public decimal MaxPaymentTolerance { get; set; }
        public string TaxJurisdictionCode { get; set; }
        public int ApplicationNo { get; set; }
        public byte LedgerEntryAmount { get; set; }
    }
}
