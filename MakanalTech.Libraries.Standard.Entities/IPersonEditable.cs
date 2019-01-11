namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IPersonEditable : IEntityEditable
    {
        string GivenName { get; set; }
    }
}