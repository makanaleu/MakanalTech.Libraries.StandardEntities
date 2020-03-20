using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TCustomerOrder<T> : TEntity<T>, IOrder<T>
    {
        public TCustomerOrder(string appellation) : base(appellation)
        {
        }

        public IPostalAddress BuyerAddress { get; set; } = null!;
        public IPerson BuyerPerson { get; set; } = null!;
        public decimal CancelledAmount { get; set; }
        public string? CancelledAmountCurrency { get; set; }
        public object? ConfirmationNumber { get; set; }
        public decimal DiscountAmount { get; set; }
        public string? DiscountCode { get; set; }
        public string? DiscountCurrency { get; set; }
        public DateTime? EarliestDeliveryDateTime { get; set; }
        public DateTime? EarliestShipDateTime { get; set; }
        public DateTime? EstimatedDeliveryDateTime { get; set; }
        public ICollection<IDelivery> OrderDeliveries { get; set; } = null!;
        public DateTime? OrderedDateTime { get; set; }
        public ICollection<IOrderItem> OrderItems { get; set; } = null!;
        public string? OrderStatus { get; set; }
        public string? OrderType { get; set; }
        public string? PaymentMethod { get; set; }
        public object? PurchaseOrderNumber { get; set; }
        public DateTime? RequestedShipDateTime { get; set; }
        public DateTime? RequiredDeliveryTime { get; set; }
        public bool RushIndicator { get; set; }
        public IPerson SalesPerson { get; set; } = null!;
        public string? Seller { get; set; }
        public IPostalAddress SellerAddress { get; set; } = null!;
        public IPerson SellerPerson { get; set; } = null!;
        public decimal SubTotalAmount { get; set; }
        public string? SubTotalAmountCurrency { get; set; }
        public decimal TaxAmount { get; set; }
        public string? TaxAmountCurrrency { get; set; }
        public decimal TotalAmount { get; set; }
        public string? TotalAmountCurrency { get; set; }

    }
}