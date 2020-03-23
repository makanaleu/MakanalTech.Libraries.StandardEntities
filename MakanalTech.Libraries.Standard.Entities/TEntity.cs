#nullable disable

using System;

namespace MakanalTech.Libraries.Standard.Entities
{
    public abstract class TEntity<T> : IEntity<T>
    {
        private DateTime? createdDateTime;

        private DateTime? modifiedDateTime;

        public TEntity(string appellation)
        {
            Appellation = appellation;
        }

        /// <summary>
        /// An identifying name or title.
        /// </summary>
        public string Appellation { get; set; }

        /// <summary>
        /// Designation of who or what created this entity.
        /// </summary>
        public T CreatedBy { get; set; }

        object IEntity.CreatedBy
        {
            get { return CreatedBy; }
            set { CreatedBy = (T)value; }
        }

        /// <summary>
        /// When the entity was created.
        /// </summary>
        public DateTime CreatedDateTime
        {
            get { return createdDateTime ?? DateTime.UtcNow; }
            set { createdDateTime = value; }
        }

        /// <summary>
        /// Unique identifier of the entity.
        /// </summary>
        public T Id { get; set; }

        object IEntity.Id
        {
            get { return Id; }
            set { Id = (T)Convert.ChangeType(value, typeof(T)); }
        }

        /// <summary>
        /// Designation of who or what modified this entity.
        /// </summary>
        public T ModifiedBy { get; set; }

        object IEntity.ModifiedBy
        {
            get { return ModifiedBy; }
            set { ModifiedBy = (T)value; }
        }

        /// <summary>
        /// Designation of who or what most recently modified this entity.
        /// </summary>
        public DateTime ModifiedDateTime
        {
            get { return modifiedDateTime ?? DateTime.UtcNow; }
            set { modifiedDateTime = value; }
        }

        /// <summary>
        /// Optimistic concurrency token.
        /// </summary>
        public byte[] Version { get; set; }

        public override string ToString()
        {
            return Appellation;
        }
    }
}