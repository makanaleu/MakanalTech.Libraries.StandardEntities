namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Person who interacts with a system, typically through an interface,
    /// to extract some functional benefit.
    /// </summary>
    public abstract class TUser<T> : TPerson<T>, IUser<T>
    {
        public TUser(string appellation) : base(appellation)
        {
        }
    }
}