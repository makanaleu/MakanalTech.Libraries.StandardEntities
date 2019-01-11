namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Template for creating view models that represent the Entity, which can
    /// be edited.
    /// </summary>
    /// <remarks>https://cpratt.co/generic-entity-base-class/</remarks>
    public interface IEntityEditable
    {
        string Appellation { get; set; }
    }
}