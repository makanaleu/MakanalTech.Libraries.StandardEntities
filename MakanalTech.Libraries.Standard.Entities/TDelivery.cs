using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TDelivery<T> : TEntity<T>, IDelivery<T>
    {
        public TDelivery(string appellation) : base(appellation)
        {
        }

        public IPostalAddress DeliveryAddress { get; set; }
        public string DeliveryMethod { get; set; }
        public ICollection<IProduct> DeliveryPayload { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime ExpectedArrivalFromDateTime { get; set; }
        public DateTime ExpectedArrivalUntilDateTime { get; set; }
        public object OrderId { get; set; }
        public IPostalAddress OriginAddress { get; set; }
        public string Provider { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientPerson { get; set; }
        public string RecipientPhone { get; set; }
        public string TrackingNumber { get; set; }
        public Uri TrackingUri { get; set; }
    }
}