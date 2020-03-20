namespace MakanalTech.Libraries.Standard.Entities
{
    public interface ILanguageEditable : IEntityEditable
    {
        /// <summary>
        /// A group of languages related through descent from a common
        /// ancestral language or parental language, called the proto-language
        /// of that family.
        /// </summary>
        string? LanguageFamily { get; set; }

        /// <summary>
        /// A name used by a group or category of people to refer to themselves
        /// or their language, as opposed to a name given to them by other
        /// groups.
        /// </summary>
        string? Endonym { get; set; }

        /// <summary>
        /// Two-letter code, one per language.
        /// </summary>
        string? ISO6391 { get; set; }

        /// <summary>
        /// Three-letter code coinciding with ISO6391 of the same language.
        /// </summary>
        string? ISO6392T { get; set; }

        /// <summary>
        /// Three-letter code, similar to ISO6392T with some codes derived
        /// from English names rather than the endonym.
        /// </summary>
        string? ISO6392B { get; set; }

        /// <summary>
        /// Same as ISO6392T, but with distinct codes for each variety of an
        /// ISO 639 macrolanguage.
        /// </summary>
        string? ISO6393 { get; set; }
    }
}