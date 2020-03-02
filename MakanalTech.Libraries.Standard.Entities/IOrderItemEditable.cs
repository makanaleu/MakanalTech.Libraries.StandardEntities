namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IOrderItemEditable : IEntityEditable
    {
        /// <summary>
        /// The delivery related to this order item.
        /// </summary>
        IDelivery Delivery { get; set; }

        /// <summary>
        /// Total discount of the order item.
        /// </summary>
        decimal DiscountAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string DiscountAmountCurrency { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        string DiscountCode { get; set; }

        /// <summary>
        /// Unit price multiplied by Quantity
        /// </summary>
        decimal ExtendedPrice { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string ExtendedPriceCurrency { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        IProduct Item { get; set; }

        /// <summary>
        /// The number of the item within the order.
        /// </summary>
        string ItemNumber { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume
        /// the quantity is one.
        /// </summary>
        decimal Quantity { get; set; }

        /// <summary>
        /// The unit of measure for the quantity (e.g. Each).
        /// </summary>
        string QuantityUnit { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Total of the tax for the order item.
        /// </summary>
        decimal TaxAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string TaxAmountCurrency { get; set; }

        /// <summary>
        /// Final total of the order item.
        /// </summary>
        decimal TotalAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Unit price for a single quantity unit of the item.
        /// </summary>
        decimal UnitPrice { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string UnitPriceCurrency { get; set; }
    }
}