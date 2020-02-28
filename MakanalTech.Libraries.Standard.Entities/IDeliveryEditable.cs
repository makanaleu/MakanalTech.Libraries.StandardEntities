using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Process of transporting goods from a source location to a predefined
    /// destination.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q2334804</remarks>
    public interface IDeliveryEditable : IEntityEditable
    {
        /// <summary>
        /// Destination address.
        /// </summary>
        IPostalAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        string DeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        ICollection<IProduct> DeliveryPayload { get; set; }

        /// <summary>
        /// Status of the delivery.
        /// </summary>
        string DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the delivery may arrive.
        /// </summary>
        DateTime ExpectedArrivalFromDateTime { get; set; }

        /// <summary>
        /// The latest date the delivery may arrive.
        /// </summary>
        DateTime ExpectedArrivalUntilDateTime { get; set; }

        /// <summary>
        /// The order the items in this delivery were included in.
        /// </summary>
        object OrderId { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        IPostalAddress OriginAddress { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the
        /// goods producer. Another party (a seller) may offer those services
        /// or goods on behalf of the provider. A provider may also serve as
        /// the seller.
        /// </summary>
        string Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        string TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        Uri TrackingUri { get; set; }
    }
}