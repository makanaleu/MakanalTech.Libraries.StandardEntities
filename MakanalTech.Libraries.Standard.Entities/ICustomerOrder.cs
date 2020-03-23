namespace MakanalTech.Libraries.Standard.Entities
{
    public interface ICustomerOrder : IOrder { }

    public interface ICustomerOrder<T> : ICustomerOrder, IEntity<T> { }
}