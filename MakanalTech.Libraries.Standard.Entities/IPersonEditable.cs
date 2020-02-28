namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IPersonEditable : IEntityEditable
    {
        /// <summary>
        /// Name typically used to differentiate people from the same family,  
        /// clan, or other social group who have a common last name.
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Q202444</remarks>
        string GivenName { get; set; }

        /// <summary>
        /// Part of a naming scheme for individuals, used in many cultures
        /// worldwide.
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Q101352</remarks>
        string FamilyName { get; set; }

        /// <summary>
        /// Additional given name.
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Q245025</remarks>
        string MiddleName { get; set; }

        /// <summary>
        /// Person's preferred short name (i.e. Christopher => Chris).
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Property:P1813</remarks>
        string ShortName { get; set; }

        /// <summary>
        /// Full name based on NameFormat.
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Q82799</remarks>
        string Name { get; set; }

        /// <summary>
        /// General format of a personal name based on culture.
        /// </summary>
        /// <remarks>https://www.wikidata.org/wiki/Q45846961</remarks>
        /// <example>'{first} {last}'</example>
        string NameFormat { get; set; }
    }
}