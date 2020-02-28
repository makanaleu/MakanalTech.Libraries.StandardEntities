namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Singular aggregation of substance(s) such as matter or radiation, with
    /// overall properties such as mass, position or momentum.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q223557</remarks>
    public interface IPhysicalObject : IConcreteObject, IPhysicalSystem
    {
    }
}