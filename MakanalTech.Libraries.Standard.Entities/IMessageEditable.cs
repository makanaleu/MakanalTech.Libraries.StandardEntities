namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IMessageEditable : IEntityEditable
    {
        /// <summary>
        /// Free-form text of the message.
        /// </summary>
        string? Body { get; set; }

        /// <summary>
        /// Refers to the name of another entity to which the message is
        /// associated.
        /// </summary>
        string? Reference { get; set; }

        /// <summary>
        /// Refers to the Id of the reference entity to which the message is
        /// associated.
        /// </summary>
        object? ReferenceId { get; set; }

        /// <summary>
        /// Type of message (e.g. warning, errror, success)
        /// </summary>
        string? Type { get; set; }
    }
}