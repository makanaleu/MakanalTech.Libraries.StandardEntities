namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Series of events which occur over an extended period of time.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q3249551</remarks>
    public interface IProcess : IOccurrence, IChange, ISeries
    {
    }
}