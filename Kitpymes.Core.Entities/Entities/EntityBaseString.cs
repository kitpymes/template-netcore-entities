// -----------------------------------------------------------------------
// <copyright file="EntityBaseString.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Entidad base para is de tipo string.
    /// </summary>
    public abstract class EntityBaseString : EntityBase<StringId>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EntityBaseString"/>.
        /// Crea una clave automática.
        /// </summary>
        protected EntityBaseString()
            : this(StringId.Create()) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EntityBaseString"/>.
        /// Crea una clave custom.
        /// </summary>
        /// <param name="id">Clave para la entidad.</param>
        protected EntityBaseString(StringId id)
           : base(id) { }
    }
}
