using System;
using System.Collections.Generic;

namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TProduct<T> : TEntity<T>, IProduct<T>
    {
        public TProduct(string appellation) : base(appellation)
        {
        }

        public string Brand { get; set; }
        public ICollection<string> Categories { get; set; }
        public string Color { get; set; }
        public decimal Depth { get; set; }
        public string DepthUnit { get; set; }
        public string GTIN { get; set; }
        public string GTIN12 { get; set; }
        public string GTIN13 { get; set; }
        public string GTIN14 { get; set; }
        public string GTIN8 { get; set; }
        public decimal Height { get; set; }
        public string HeightUnit { get; set; }
        public string ItemCondition { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public string Model { get; set; }
        public string MPN { get; set; }
        public string NSN { get; set; }
        public DateTime ProductionDateTime { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public ICollection<IProduct> RelatedTo { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public ICollection<IProduct> SimilarTo { get; set; }
        public string SKU { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public decimal Width { get; set; }
        public string WidthUnit { get; set; }
    }
}
