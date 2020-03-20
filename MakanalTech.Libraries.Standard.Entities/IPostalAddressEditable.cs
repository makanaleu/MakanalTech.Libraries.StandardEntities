namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Collection of information that describes the location of a building,
    /// apartment, or other structure.
    /// </summary>
    /// <remarks>https://developers.google.com/maps/documentation/geocoding/intro</remarks>
    public interface IPostalAddressEditable : IEntityEditable
    {
        /// <summary>
        /// An airport.
        /// </summary>
        string? Airport { get; set; }

        /// <summary>
        /// First civil organizational level under Country (e.g. a state)
        /// </summary>
        string? AreaLevel1 { get; set; }

        /// <summary>
        /// Second civil organizational level under Country (e.g. a county)
        /// </summary>
        string? AreaLevel2 { get; set; }

        /// <summary>
        /// Third civil organizational level under Country.
        /// </summary>
        string? AreaLevel3 { get; set; }

        /// <summary>
        /// Fourth civil organizational level under Country.
        /// </summary>
        string? AreaLevel4 { get; set; }

        /// <summary>
        /// Fifth civil organizational level under Country.
        /// </summary>
        string? AreaLevel5 { get; set; }

        /// <summary>
        /// National political entity.
        /// </summary>
        string? Country { get; set; }

        /// <summary>
        /// Typically a place that has not yet been categorised.
        /// </summary>
        string? Establishment { get; set; }

        /// <summary>
        /// Floor of a building address.
        /// </summary>
        string? Floor { get; set; }

        /// <summary>
        /// An intersection of two roads.
        /// </summary>
        string? Intersection { get; set; }

        /// <summary>
        /// An incorporated city or town.
        /// </summary>
        string? Locality { get; set; }

        /// <summary>
        /// Prominent natural feature.
        /// </summary>
        string? NaturalFeature { get; set; }

        /// <summary>
        /// A name neighborhood.
        /// </summary>
        string? Neighborhood { get; set; }

        /// <summary>
        /// A parking lot or parking structure.
        /// </summary>
        string? Parking { get; set; }

        /// <summary>
        /// A named point of interest (e.g. Eiffel Tower).
        /// </summary>
        string? PointOfInterest { get; set; }

        /// <summary>
        /// Postal code used to address postal mail within the Country.
        /// </summary>
        string? PostalCode { get; set; }

        /// <summary>
        /// A grouping of areas such as Locality and Sublocality used for
        /// postal addresses in some countries.
        /// </summary>
        string? PostalTown { get; set; }

        /// <summary>
        /// Specific postal box.
        /// </summary>
        string? PostBox { get; set; }

        /// <summary>
        /// A named location, usually a building or collection of buildings.
        /// </summary>
        string? Premise { get; set; }

        /// <summary>
        /// The room of a building address.
        /// </summary>
        string? Room { get; set; }

        /// <summary>
        /// A named route (i.e. Main Street).
        /// </summary>
        string? Route { get; set; }

        /// <summary>
        /// Precise street address.
        /// </summary>
        string? StreetAddress { get; set; }

        /// <summary>
        /// The precise street number.
        /// </summary>
        string? StreetNumber { get; set; }

        /// <summary>
        /// First sub level under Locality.
        /// </summary>
        string? Sublocality { get; set; }

        /// <summary>
        /// First sub level under Premise.
        /// </summary>
        string? Subpremise { get; set; }

        /// <summary>
        /// Location of a public transit station or stop.
        /// </summary>
        string? TransitStation { get; set; }
    }
}