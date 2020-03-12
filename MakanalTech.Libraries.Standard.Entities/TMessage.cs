namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Discrete unit of communication intended by the source for consumption
    /// by some recipient or group of recipients.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TMessage<T> : TEntity<T>, IMessage<T>
    {
        public TMessage(string appellation) : base(appellation)
        {
        }

        public string Body { get; set; }
    }
}