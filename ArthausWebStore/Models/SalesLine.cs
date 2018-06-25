﻿using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class SalesLine
    {
        public byte[] Timestamp { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public int LineNo { get; set; }
        public string SellToCustomerNo { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string PostingGroup { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Quantity { get; set; }
        public decimal OutstandingQuantity { get; set; }
        public decimal QtyToInvoice { get; set; }
        public decimal QtyToShip { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCostLcy { get; set; }
        public decimal Vat { get; set; }
        public decimal LineDiscount { get; set; }
        public decimal LineDiscountAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountIncludingVat { get; set; }
        public byte AllowInvoiceDisc { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal UnitsPerParcel { get; set; }
        public decimal UnitVolume { get; set; }
        public int ApplToItemEntry { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string CustomerPriceGroup { get; set; }
        public string JobNo { get; set; }
        public string WorkTypeCode { get; set; }
        public byte RecalculateInvoiceDisc { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal QtyShippedNotInvoiced { get; set; }
        public decimal ShippedNotInvoiced { get; set; }
        public decimal QuantityShipped { get; set; }
        public decimal QuantityInvoiced { get; set; }
        public string ShipmentNo { get; set; }
        public int ShipmentLineNo { get; set; }
        public decimal Profit { get; set; }
        public string BillToCustomerNo { get; set; }
        public decimal InvDiscountAmount { get; set; }
        public string PurchaseOrderNo { get; set; }
        public int PurchOrderLineNo { get; set; }
        public byte DropShipment { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int VatCalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int AttachedToLineNo { get; set; }
        public string ExitPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxCategory { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatClauseCode { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string VatProdPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal OutstandingAmountLcy { get; set; }
        public decimal ShippedNotInvoicedLcy { get; set; }
        public int Reserve { get; set; }
        public string BlanketOrderNo { get; set; }
        public int BlanketOrderLineNo { get; set; }
        public decimal VatBaseAmount { get; set; }
        public decimal UnitCost { get; set; }
        public byte SystemCreatedEntry { get; set; }
        public decimal LineAmount { get; set; }
        public decimal VatDifference { get; set; }
        public decimal InvDiscAmountToInvoice { get; set; }
        public string VatIdentifier { get; set; }
        public int IcPartnerRefType { get; set; }
        public string IcPartnerReference { get; set; }
        public decimal Prepayment { get; set; }
        public decimal PrepmtLineAmount { get; set; }
        public decimal PrepmtAmtInv { get; set; }
        public decimal PrepmtAmtInclVat { get; set; }
        public decimal PrepaymentAmount { get; set; }
        public decimal PrepmtVatBaseAmt { get; set; }
        public decimal PrepaymentVat { get; set; }
        public int PrepmtVatCalcType { get; set; }
        public string PrepaymentVatIdentifier { get; set; }
        public string PrepaymentTaxAreaCode { get; set; }
        public byte PrepaymentTaxLiable { get; set; }
        public string PrepaymentTaxGroupCode { get; set; }
        public decimal PrepmtAmtToDeduct { get; set; }
        public decimal PrepmtAmtDeducted { get; set; }
        public byte PrepaymentLine { get; set; }
        public decimal PrepmtAmountInvInclVat { get; set; }
        public decimal PrepmtAmountInvLcy { get; set; }
        public string IcPartnerCode { get; set; }
        public decimal PrepmtVatAmountInvLcy { get; set; }
        public decimal PrepaymentVatDifference { get; set; }
        public decimal PrepmtVatDiffToDeduct { get; set; }
        public decimal PrepmtVatDiffDeducted { get; set; }
        public int DimensionSetId { get; set; }
        public decimal QtyToAssembleToOrder { get; set; }
        public decimal QtyToAsmToOrderBase { get; set; }
        public string JobTaskNo { get; set; }
        public int JobContractEntryNo { get; set; }
        public string DeferralCode { get; set; }
        public DateTime ReturnsDeferralStartDate { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public byte Planned { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal QuantityBase { get; set; }
        public decimal OutstandingQtyBase { get; set; }
        public decimal QtyToInvoiceBase { get; set; }
        public decimal QtyToShipBase { get; set; }
        public decimal QtyShippedNotInvdBase { get; set; }
        public decimal QtyShippedBase { get; set; }
        public decimal QtyInvoicedBase { get; set; }
        public DateTime FaPostingDate { get; set; }
        public string DepreciationBookCode { get; set; }
        public byte DeprUntilFaPostingDate { get; set; }
        public string DuplicateInDepreciationBook { get; set; }
        public byte UseDuplicationList { get; set; }
        public string ResponsibilityCenter { get; set; }
        public byte OutOfStockSubstitution { get; set; }
        public string OriginallyOrderedNo { get; set; }
        public string OriginallyOrderedVarCode { get; set; }
        public string CrossReferenceNo { get; set; }
        public string UnitOfMeasureCrossRef { get; set; }
        public int CrossReferenceType { get; set; }
        public string CrossReferenceTypeNo { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public byte SpecialOrder { get; set; }
        public string SpecialOrderPurchaseNo { get; set; }
        public int SpecialOrderPurchLineNo { get; set; }
        public byte CompletelyShipped { get; set; }
        public DateTime RequestedDeliveryDate { get; set; }
        public DateTime PromisedDeliveryDate { get; set; }
        public string ShippingTime { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public DateTime PlannedDeliveryDate { get; set; }
        public DateTime PlannedShipmentDate { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public byte AllowItemChargeAssignment { get; set; }
        public decimal ReturnQtyToReceive { get; set; }
        public decimal ReturnQtyToReceiveBase { get; set; }
        public decimal ReturnQtyRcdNotInvd { get; set; }
        public decimal RetQtyRcdNotInvdBase { get; set; }
        public decimal ReturnRcdNotInvd { get; set; }
        public decimal ReturnRcdNotInvdLcy { get; set; }
        public decimal ReturnQtyReceived { get; set; }
        public decimal ReturnQtyReceivedBase { get; set; }
        public int ApplFromItemEntry { get; set; }
        public string BomItemNo { get; set; }
        public string ReturnReceiptNo { get; set; }
        public int ReturnReceiptLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public byte AllowLineDisc { get; set; }
        public string CustomerDiscGroup { get; set; }
        public string StoreNo { get; set; }
        public string CurrentCustPriceGroup { get; set; }
        public string CurrentStoreGroup { get; set; }
        public string Division { get; set; }
        public string OfferNo { get; set; }
        public string PromotionNo { get; set; }
        public string AllocPlanPurcOrderNo { get; set; }
        public string VendorNo { get; set; }
        public decimal ShippedNotInvLcyNoVat { get; set; }
        public int LineDiscountCalculation { get; set; }
        public int Subtype { get; set; }
        public string PriceDescription { get; set; }
    }
}
