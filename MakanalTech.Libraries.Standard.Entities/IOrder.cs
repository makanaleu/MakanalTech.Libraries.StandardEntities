namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IOrder : IOrderEditable, IOccurrence, IIntention { }

    public interface IOrder<T> : IOrder, IEntity<T> { }
}