namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IProduct :
        IProductEditable, IGoods, IArtificialPhysicalObject
    {
    }

    public interface IProduct<T> : IProduct, IEntity<T> { }
}