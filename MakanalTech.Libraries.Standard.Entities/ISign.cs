namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Semiotic concept; object, quality, event, or entity whose presence or
    /// occurrence indicates the probable presence or occurrence of something
    /// else; includes words, punctuation, expressions, gestures, notices, road
    /// signs, symbols, pictures, etc.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q3695082</remarks>
    public interface ISign : IAbstractObject, IKnowledge, IInformation
    {
    }
}