namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TOrderItem<T> : TEntity<T>, IOrderItem<T>
    {
        public TOrderItem(string appellation) : base(appellation)
        {
        }

        public IDelivery Delivery { get; set; } = null!;
        public decimal DiscountAmount { get; set; }
        public string? DiscountAmountCurrency { get; set; }
        public string? DiscountCode { get; set; }
        public decimal ExtendedPrice { get; set; }
        public string? ExtendedPriceCurrency { get; set; }
        public IProduct Item { get; set; } = null!;
        public string? ItemNumber { get; set; }
        public decimal Quantity { get; set; }
        public string? QuantityUnit { get; set; }
        public string? Status { get; set; }
        public decimal TaxAmount { get; set; }
        public string? TaxAmountCurrency { get; set; }
        public decimal TotalAmount { get; set; }
        public string? TotalAmountCurrency { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UnitPriceCurrency { get; set; }
    }
}