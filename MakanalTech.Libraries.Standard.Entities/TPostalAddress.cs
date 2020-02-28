namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TPostalAddress<T> : TEntity<T>, IPostalAddress<T>
    {
        public TPostalAddress(string appellation) : base(appellation)
        {
        }

        public string Airport { get; set; }
        public string AreaLevel1 { get; set; }
        public string AreaLevel2 { get; set; }
        public string AreaLevel3 { get; set; }
        public string AreaLevel4 { get; set; }
        public string AreaLevel5 { get; set; }
        public string Country { get; set; }
        public string Establishment { get; set; }
        public string Floor { get; set; }
        public string Intersection { get; set; }
        public string Locality { get; set; }
        public string NaturalFeature { get; set; }
        public string Neighborhood { get; set; }
        public string Parking { get; set; }
        public string PointOfInterest { get; set; }
        public string PostalCode { get; set; }
        public string PostalTown { get; set; }
        public string PostBox { get; set; }
        public string Premise { get; set; }
        public string Room { get; set; }
        public string Route { get; set; }
        public string StreetAddress { get; set; }
        public string StreetNumber { get; set; }
        public string Sublocality { get; set; }
        public string Subpremise { get; set; }
        public string TransitStation { get; set; }
        public string Type { get; set; }
    }
}