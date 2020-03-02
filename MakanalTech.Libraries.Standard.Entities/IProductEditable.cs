using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Anything that can be offered to a market.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q2424752</remarks>
    public interface IProductEditable : IEntityEditable
    {
        /// <summary>
        /// The brand associated with a product or service, or the brand
        /// maintained by an organization or business person.
        /// </summary>
        string Brand { get; set; }

        /// <summary>
        /// A collection of categories for the item. Greater signs or slashes
        /// can be used to informally indicate a category hierarchy.
        /// </summary>
        ICollection<string> Categories { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        decimal Depth { get; set; }

        /// <summary>
        /// The depth unit of measure.
        /// </summary>
        string DepthUnit { get; set; }

        /// <summary>
        /// A Global Trade Item Number (GTIN). GTINs identify trade items,
        /// including products and services, using numeric identification
        /// codes. The gtin property generalizes the earlier gtin8, gtin12,
        /// gtin13, and gtin14 properties. The GS1 digital link specifications
        /// express GTINs as URLs. A correct gtin value should be a valid GTIN,
        /// which means that it should be an all-numeric string of either 8,
        /// 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a
        /// string. The numeric component should also have a valid GS1 check
        /// digit and meet the other rules for valid GTINs.
        /// </summary>
        string GTIN { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer
        /// refers. The GTIN-12 is the 12-digit GS1 Identification Key composed
        /// of a U.P.C. Company Prefix, Item Reference, and Check Digit used to
        /// identify trade items.
        /// </summary>
        string GTIN12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer
        /// refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13.
        /// Former 12-digit UPC codes can be converted into a GTIN-13 code by
        /// simply adding a preceeding zero.
        /// </summary>
        string GTIN13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer
        /// refers.
        /// </summary>
        string GTIN14 { get; set; }

        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer
        /// refers. This code is also known as EAN/UCC-8 or 8-digit EAN.
        /// </summary>
        string GTIN8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        decimal Height { get; set; }

        /// <summary>
        /// The height unit of measure.
        /// </summary>
        string HeightUnit { get; set; }

        /// <summary>
        /// A textual description of the condition of the product or service,
        /// or the products or services included in the offer.
        /// </summary>
        string ItemCondition { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        string Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton,
        /// paper.
        /// </summary>
        string Material { get; set; }

        /// <summary>
        /// The model of the product.
        /// </summary>
        string Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product
        /// to which the offer refers.
        /// </summary>
        string MPN { get; set; }

        /// <summary>
        /// Indicates the NATO stock number (nsn) of a Product.
        /// </summary>
        string NSN { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        DateTime ProductionDateTime { get; set; }

        /// <summary>
        /// The date the item was purchased by the current owner.
        /// </summary>
        DateTime PurchaseDateTime { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple
        /// products).
        /// </summary>
        ICollection<IProduct> RelatedTo { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to
        /// distinguish the exact variant of a product.
        /// </summary>
        DateTime ReleaseDateTime { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple
        /// products).
        /// </summary>
        ICollection<IProduct> SimilarTo { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier
        /// for a product or service, or the product to which the offer refers.
        /// </summary>
        string SKU { get; set; }

        /// <summary>
        /// The weight of the item.
        /// </summary>
        decimal Weight { get; set; }

        /// <summary>
        /// The weight unit of measure.
        /// </summary>
        string WeightUnit { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        decimal Width { get; set; }

        /// <summary>
        /// The width unit of measure.
        /// </summary>
        string WidthUnit { get; set; }
    }
}