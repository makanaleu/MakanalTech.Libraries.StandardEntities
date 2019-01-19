using System;

namespace MakanalTech.Libraries.Standard.Entities
{
    public interface IAccessToken : IAccessTokenEditable, IAccessControl
    {
        /// <summary>
        /// Audience the access token is intended for.
        /// </summary>
        string Audience { get; set; }
        
        /// <summary>
        /// Contents of the access token.
        /// </summary>
        string InnerToken { get; set; }

        /// <summary>
        /// Issuer of the access token.
        /// </summary>
        string Issuer { get; set; }

        /// <summary>
        /// Subject or principal of the access token.
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// The type of access token (i.e. 'refresh', 'access', 'auth').
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// When the access token became valid.
        /// </summary>
        DateTime ValidFrom { get; set; }

        /// <summary>
        /// When the access token expires.
        /// </summary>
        DateTime ValidTo { get; set; }
    }

    public interface IAccessToken<T> : IAccessToken, IEntity<T> { }
}