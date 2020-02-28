namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IOrderItem : IOrderItemEditable, IFileUnit { }

    public interface IOrderItem<T> : IOrderItem, IEntity<T> { }
}