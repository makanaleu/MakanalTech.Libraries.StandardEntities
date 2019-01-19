namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// A system of communication used by a particular country or community.
    /// </summary>
    public abstract class TLanguage<T> : TEntity<T>, ILanguage<T>
    {
        public TLanguage(string appellation) : base(appellation) { }

        /// <summary>
        /// A name used by a group or category of people to refer to themselves
        /// or their language, as opposed to a name given to them by other
        /// groups.
        /// </summary>
        public string Endonym { get; set; }

        /// <summary>
        /// Two-letter code, one per language.
        /// </summary>
        public string ISO6391 { get; set; }

        /// <summary>
        /// Three-letter code, similar to ISO6392T with some codes derived
        /// from English names rather than the endonym.
        /// </summary>
        public string ISO6392B { get; set; }

        /// <summary>
        /// Three-letter code coinciding with ISO6391 of the same language.
        /// </summary>
        public string ISO6392T { get; set; }

        /// <summary>
        /// Same as ISO6392T, but with distinct codes for each variety of an
        /// ISO 639 macrolanguage.
        /// </summary>
        public string ISO6393 { get; set; }

        /// <summary>
        /// A group of languages related through descent from a common
        /// ancestral language or parental language, called the proto-language
        /// of that family.
        /// </summary>
        public string LanguageFamily { get; set; }
    }
}