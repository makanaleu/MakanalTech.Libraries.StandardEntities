namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IDelivery :
        IDeliveryEditable, IService, ITransport, IEconomicActivity
    {
    }

    public interface IDelivery<T> : IDelivery, IEntity<T> { }
}