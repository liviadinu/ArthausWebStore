using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class CustLedgerEntry
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public string CustomerNo { get; set; }
        public DateTime PostingDate { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public decimal SalesLcy { get; set; }
        public decimal ProfitLcy { get; set; }
        public decimal InvDiscountLcy { get; set; }
        public string SellToCustomerNo { get; set; }
        public string CustomerPostingGroup { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string SalespersonCode { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string OnHold { get; set; }
        public int AppliesToDocType { get; set; }
        public string AppliesToDocNo { get; set; }
        public byte Open { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PmtDiscountDate { get; set; }
        public decimal OriginalPmtDiscPossible { get; set; }
        public decimal PmtDiscGivenLcy { get; set; }
        public byte Positive { get; set; }
        public int ClosedByEntryNo { get; set; }
        public DateTime ClosedAtDate { get; set; }
        public decimal ClosedByAmount { get; set; }
        public string AppliesToId { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public int BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public int TransactionNo { get; set; }
        public decimal ClosedByAmountLcy { get; set; }
        public DateTime DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public byte CalculateInterest { get; set; }
        public byte ClosingInterestCalculated { get; set; }
        public string NoSeries { get; set; }
        public string ClosedByCurrencyCode { get; set; }
        public decimal ClosedByCurrencyAmount { get; set; }
        public decimal AdjustedCurrencyFactor { get; set; }
        public decimal OriginalCurrencyFactor { get; set; }
        public decimal RemainingPmtDiscPossible { get; set; }
        public DateTime PmtDiscToleranceDate { get; set; }
        public decimal MaxPaymentTolerance { get; set; }
        public int LastIssuedReminderLevel { get; set; }
        public decimal AcceptedPaymentTolerance { get; set; }
        public byte AcceptedPmtDiscTolerance { get; set; }
        public decimal PmtToleranceLcy { get; set; }
        public decimal AmountToApply { get; set; }
        public string IcPartnerCode { get; set; }
        public byte ApplyingEntry { get; set; }
        public byte Reversed { get; set; }
        public int ReversedByEntryNo { get; set; }
        public int ReversedEntryNo { get; set; }
        public byte Prepayment { get; set; }
        public string PaymentMethodCode { get; set; }
        public string AppliesToExtDocNo { get; set; }
        public string RecipientBankAccount { get; set; }
        public string MessageToRecipient { get; set; }
        public byte ExportedToPaymentFile { get; set; }
        public int DimensionSetId { get; set; }
        public string DirectDebitMandateId { get; set; }
        public string BatchNo { get; set; }
        public string StatementNo { get; set; }
        public string SellToContactNo { get; set; }
    }
}
