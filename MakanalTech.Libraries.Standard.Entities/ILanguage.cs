namespace MakanalTech.Libraries.Standard.Entities
{
    public interface ILanguage : ILanguageEditable, ILanguoid { }

    public interface ILanguage<T> : ILanguage, IEntity<T> { }
}