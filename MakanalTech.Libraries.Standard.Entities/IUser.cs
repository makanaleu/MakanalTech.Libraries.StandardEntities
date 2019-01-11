namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IUser : IUserEditable, IPerson
    {
    }

    public interface IUser<T> : IUser, IPerson<T>
    {
    }
}