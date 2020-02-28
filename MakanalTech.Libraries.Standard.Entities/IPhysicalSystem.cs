namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Portion of the physical universe chosen for analysis; everything
    /// outside the system is known as the environment.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q1454986</remarks>
    public interface IPhysicalSystem : ISystem, IConcreteObject, IObjectOfScience
    {
    }
}