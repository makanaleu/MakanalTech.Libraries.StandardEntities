namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IMessageEditable : IEntityEditable
    {
        /// <summary>
        /// Free-form text of the message.
        /// </summary>
        string? Body { get; set; }
    }
}