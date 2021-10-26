﻿// -----------------------------------------------------------------------
// <copyright file="UserSession.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Propiedades de la sesión del usuario.
    /// </summary>
    public abstract class UserSession<TId>
    {
        /// <summary>
        /// Obtiene o establece el id.
        /// </summary>
        public TId Id { get; set; } = default!;

        /// <summary>
        /// Obtiene o establece el email.
        /// </summary>
        public string Email { get; set; } = default!;

        /// <summary>
        /// Obtiene o establece el rol.
        /// </summary>
        public string Role { get; set; } = default!;

        /// <summary>
        /// Obtiene o establece los permisos.
        /// </summary>
        public IEnumerable<string> Permissions { get; set; } = default!;
    }
}
