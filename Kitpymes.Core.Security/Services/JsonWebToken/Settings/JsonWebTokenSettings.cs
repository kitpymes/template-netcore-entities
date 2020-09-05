// -----------------------------------------------------------------------
// <copyright file="JsonWebTokenSettings.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Security
{
    using System;
    using System.Text;
    using System.Text.Json.Serialization;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.IdentityModel.Tokens;

    /*
        Clase para la configuraci�n del token de sesi�n JsonWebTokenSettings
        Contiene las propiedades para la configuraci�n del token de sesi�n
    */

    /// <summary>
    /// Clase para la configuraci�n del token de sesi�n <c>JsonWebTokenSettings</c>.
    /// Contiene las propiedades para la configuraci�n del token de sesi�n.
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todas las propiedades para la configuraci�n del token de sesi�n.</para>
    /// </remarks>
    public class JsonWebTokenSettings
    {
        private bool _enabled = false;
        private string _key = "DDF3620A-4539-4EBF-A18E-0D0C435D44D2";
        private string _authenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        private string _challengeScheme = JwtBearerDefaults.AuthenticationScheme;
        private bool _requireExpirationTime = true;

        /// <summary>
        /// Obtiene los par�metros para las validaciones del token de sesi�n.
        /// </summary>
        [JsonIgnore]
        public TokenValidationParameters TokenValidationParameters => new TokenValidationParameters
        {
            ValidateIssuerSigningKey = !string.IsNullOrWhiteSpace(Key),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key)),

            ValidateIssuer = !string.IsNullOrWhiteSpace(ValidIssuer),
            ValidIssuer = ValidIssuer,

            ValidateAudience = !string.IsNullOrWhiteSpace(ValidAudience),
            ValidAudience = ValidAudience,

            ValidateLifetime = !(LifetimeValidator is null),
            LifetimeValidator = LifetimeValidator,

            // Tiempo de caducidad del b�fer, el tiempo efectivo total es igual al tiempo m�s el tiempo de caducidad de Jwt. Si no est� configurado, el valor predeterminado es 5 minutos.
            ClockSkew = TimeSpan.FromSeconds(30),

            RequireExpirationTime = _requireExpirationTime,
        };

        /// <summary>
        /// Obtiene o establece la validaci�n del token de sesi�n.
        /// </summary>
        [JsonIgnore]
        public LifetimeValidator LifetimeValidator { get; set; } = (before, expires, token, param) => expires > DateTime.UtcNow;

        /// <summary>
        /// Obtiene o establece la configuraci�n del tiempo de expiraci�n del token de sesi�n.
        /// </summary>
        public ExpireSettings Expire { get; set; } = new ExpireSettings();

        /// <summary>
        /// Obtiene o establece un valor que indica si se habilita el servicio del token de sesi�n.
        /// </summary>
        public bool? Enabled
        {
            get => _enabled;
            set
            {
                if (value.HasValue)
                {
                    _enabled = value.Value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece la audiencia del token de sesi�n.
        /// </summary>
        public string? ValidAudience { get; set; }

        /// <summary>
        /// Obtiene o establece el emisor del token de sesi�n.
        /// </summary>
        public string? ValidIssuer { get; set; }

        /// <summary>
        /// Obtiene o establece la clave unica.
        /// </summary>
        public string? Key
        {
            get => _key;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _key = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el esquema de autenticaci�n.
        /// </summary>
        public string? AuthenticateScheme
        {
            get => _authenticateScheme;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _authenticateScheme = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el esquema de desafio.
        /// </summary>
        public string? ChallengeScheme
        {
            get => _challengeScheme;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _challengeScheme = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece un valor que indica si los tokens deben tener un valor de 'caducidad'.
        /// </summary>
        public bool? RequireExpirationTime
        {
            get => _requireExpirationTime;
            set
            {
                if (value.HasValue)
                {
                    _requireExpirationTime = value.Value;
                }
            }
        }
    }
}
