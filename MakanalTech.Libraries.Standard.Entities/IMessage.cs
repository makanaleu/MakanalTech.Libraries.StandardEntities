namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IMessage : IMessageEditable, IInformation { }

    public interface IMessage<T> : IMessage, IEntity<T> { }
}