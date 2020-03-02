namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Change in position of an object over time; a body is said to be in
    /// motion if it changes its position with respect to its immediate
    /// surroundings.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q79782</remarks>
    public interface IMotion : IPhysicalProcess, IChange
    {
    }
}