// -----------------------------------------------------------------------
// <copyright file="IJsonWebTokenService.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Security
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    /*
        Interfaz para el token de sesi�n IJsonWebTokenService
        Contiene las firmas para el token de sesi�n
    */

    /// <summary>
    /// Interfaz para el token de sesi�n <c>IJsonWebTokenService</c>.
    /// Contiene las firmas para el token de sesi�n.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las firmas para el token de sesi�n.</para>
    /// </remarks>
    public interface IJsonWebTokenService
    {
        /// <summary>
        /// Codifica el token de sesi�n.
        /// </summary>
        /// <param name="claims">Lista de informaci�n a codificar.</param>
        /// <param name="headers">Lista de valores a codificar.</param>
        /// <returns>(string Token, string Expire) | ApplicationException: si la lista de claims es nula o no contiene valores.</returns>
        (string Token, string Expire) Encode(IList<Claim> claims, Dictionary<string, object>? headers = null);

        /// <summary>
        /// Decodifica el token de sesi�n.
        /// </summary>
        /// <param name="token">Clave de sesi�n.</param>
        /// <returns>Dictionary{string, object} | ApplicationException: si el token es nulo o vacio.</returns>
        Dictionary<string, object> Decode(string? token);

        /// <summary>
        /// Codifica el token de sesi�n.
        /// </summary>
        /// <param name="claims">Lista de informaci�n a codificar.</param>
        /// <param name="headers">Lista de valores a codificar.</param>
        /// <returns>(string Token, string Expire) | ApplicationException: si la lista de claims es nula o no contiene valores.</returns>
        Task<(string Token, string Expire)> EncodeAsync(IList<Claim> claims, Dictionary<string, object>? headers = null);

        /// <summary>
        /// Decodifica el token de sesi�n.
        /// </summary>
        /// <param name="token">Clave de sesi�n.</param>
        /// <returns>Dictionary{string, object} | ApplicationException: si el token es nulo o vacio.</returns>
        Task<Dictionary<string, object>> DecodeAsync(string? token);
    }
}