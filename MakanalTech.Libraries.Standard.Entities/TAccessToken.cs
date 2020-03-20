using System;

namespace MakanalTech.Libraries.Standard.Entities
{
    /// <summary>
    /// Generally used for custom generated tokens such as refresh tokens, or to
    /// provide a meta data object for storage in a database.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TAccessToken<T> : TEntity<T>, IAccessToken<T>
    {
        public TAccessToken(string appellation) : base(appellation)
        {
        }

        /// <summary>
        /// Audience the access token is intended for.
        /// </summary>
        public string? Audience { get; set; }

        /// <summary>
        /// Contents of the access token.
        /// </summary>
        public string? InnerToken { get; set; }

        /// <summary>
        /// Issuer of the access token.
        /// </summary>
        public string? Issuer { get; set; }

        /// <summary>
        /// Subject or principal of the access token.
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// The type of access token (i.e. 'refresh', 'access', 'auth').
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// When the access token became valid.
        /// </summary>
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// When the access token expires.
        /// </summary>
        public DateTime? ValidTo { get; set; }
    }
}