using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// An order is a confirmation of a transaction, which can contain multiple
    /// line items.
    /// </summary>
    /// <remarks>https://schema.org/Order</remarks>
    public interface IOrderEditable : IEntityEditable
    {
        /// <summary>
        /// The buyer address for the order.
        /// </summary>
        IPostalAddress BuyerAddress { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        IPerson BuyerPerson { get; set; }

        /// <summary>
        /// The total of any amounts cancelled from the order.
        /// </summary>
        decimal CancelledAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string CancelledAmountCurrency { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been
        /// received.
        /// </summary>
        object ConfirmationNumber { get; set; }

        /// <summary>
        /// Any discount applied to an Order. Usually applies to the order
        /// total rather than a specific order item.
        /// </summary>
        decimal DiscountAmount { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        string DiscountCode { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string DiscountCurrency { get; set; }

        /// <summary>
        /// Earliest date which an order may be delivered.
        /// </summary>
        DateTime EarliestDeliveryDateTime { get; set; }

        /// <summary>
        /// Earliest date which an order may be shipped.
        /// </summary>
        DateTime EarliestShipDateTime { get; set; }

        /// <summary>
        /// The delivery of the parcel(s) related to this order.
        /// </summary>
        ICollection<IDelivery> OrderDeliveries { get; set; }

        /// <summary>
        /// Date order was placed.
        /// </summary>
        DateTime OrderedDateTime { get; set; }

        /// <summary>
        /// A collection of the items, services, and fees on the order.
        /// </summary>
        ICollection<IOrderItem> OrderItems { get; set; }

        /// <summary>
        /// The current status of the order.
        /// </summary>
        string OrderStatus { get; set; }

        /// <summary>
        /// Type of order (i.e. Sale, Purchase, Work, etc.)
        /// </summary>
        string OrderType { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the
        /// order.
        /// </summary>
        string PaymentMethod { get; set; }

        /// <summary>
        /// Reference to a purchase order related to this order.
        /// </summary>
        object PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Requested date which an order should be shipped.
        /// </summary>
        DateTime RequestedShipDateTime { get; set; }

        /// <summary>
        /// Required date which an order must be delivered. A guarantee may be
        /// associated with the delivery time frame.
        /// </summary>
        DateTime RequiredDeliveryTime { get; set; }

        /// <summary>
        /// Indicates the order should be rushed.
        /// </summary>
        bool RushIndicator { get; set; }

        /// <summary>
        /// Party to which the order total amount is attributed as a sale.
        /// </summary>
        IPerson SalesPerson { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the
        /// services / goods. A seller may also be a provider.
        /// </summary>
        string Seller { get; set; }

        /// <summary>
        /// The seller address for the order.
        /// </summary>
        IPostalAddress SellerAddress { get; set; }

        /// <summary>
        /// Party selling or providing the contents of the order.
        /// </summary>
        IPerson SellerPerson { get; set; }

        /// <summary>
        /// The total amount from all order lines before order level amounts
        /// are applied (i.e. order discounts, taxes, shipping fee, etc.).
        /// </summary>
        decimal SubTotalAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string SubTotalAmountCurrency { get; set; }

        /// <summary>
        /// The total amount of taxes for the order.
        /// </summary>
        decimal TaxAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string TaxAmountCurrrency { get; set; }

        /// <summary>
        /// The total amount of the order (a.k.a. grand total).
        /// </summary>
        decimal TotalAmount { get; set; }

        /// <summary>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker
        /// symbol for cryptocurrencies e.g. "BTC".
        /// </summary>
        string TotalAmountCurrency { get; set; }
    }
}