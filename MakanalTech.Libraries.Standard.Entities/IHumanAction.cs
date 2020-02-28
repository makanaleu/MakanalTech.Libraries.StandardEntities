namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Every human activity led by purposeful motives.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q451967</remarks>
    public interface IHumanAction : IHumanBehavior, IAction, IProcess
    {
    }
}