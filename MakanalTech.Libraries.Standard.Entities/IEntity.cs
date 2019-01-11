using System;

namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Properties of the IEntity should not be exposed for editing via view
    /// models. The intention is to implement common properties of entities
    /// stored in a database.
    /// </summary>
    /// <remarks>https://www.wikidata.org/wiki/Q35120</remarks>
    public interface IEntity : IEntityEditable
    {
        /// <summary>
        /// Designation of who or what created this entity. CreatedBy is a
        /// generic object which when implemented, shares the same type as the
        /// entity Id. The presumption is that an entity (i.e. Person) created
        /// this entity and can be referenced by its Id rather than a simple
        /// string.
        /// </summary>
        object CreatedBy { get; set; }

        /// <summary>
        /// When the entity was created.
        /// </summary>
        DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Unique identifier of the entity. Id is a generic type which can be
        /// implemented using a preferred type (i.e. int, long, Guid).
        /// </summary>
        object Id { get; set; }

        /// <summary>
        /// Designation of who or what modified this entity. ModifiedBy is a
        /// generic object which when implemented, shares the same type as the
        /// entity Id. The presumption is that an entity (i.e. Person) modified
        /// this entity and can be referenced by its Id rather than a simple
        /// string.
        /// </summary>
        object ModifiedBy { get; set; }

        /// <summary>
        /// When the entity was most recently modified.
        /// </summary>
        DateTime ModifiedDateTime { get; set; }

        /// <summary>
        /// Optimistic concurrency token.
        /// </summary>
        /// <remarks>https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/handling-concurrency-with-the-entity-framework-in-an-asp-net-mvc-application#add-an-optimistic-concurrency-property-to-the-department-entity</remarks>
        byte[] Version { get; set; }
    }

    /// <summary>
    /// Implements IEntity with the ability to specify the type for the Id
    /// property.
    /// </summary>
    /// <typeparam name="T">
    /// Type for the Id of the entity (i.e. int, long, Guid)
    /// </typeparam>
    public interface IEntity<T> : IEntity
    {
        /// <summary>
        /// Unique identifier of the entity.
        /// </summary>
        new T Id { get; set; }
    }
}