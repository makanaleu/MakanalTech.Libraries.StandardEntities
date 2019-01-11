namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IPerson : IPersonEditable, ISubject, IIndividual, IAgent
    { }

    public interface IPerson<T> : IPerson, IEntity<T> { }
}