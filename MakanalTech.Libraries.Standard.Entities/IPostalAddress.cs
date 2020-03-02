namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IPostalAddress : IPostalAddressEditable, IPersonalData, IName, IAddress { }

    public interface IPostalAddress<T> : IPostalAddress, IEntity<T> { }  
}