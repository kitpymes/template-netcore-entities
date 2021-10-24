// -----------------------------------------------------------------------
// <copyright file="EntityBaseGuid.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Entidad base para is de tipo Guid.
    /// </summary>
    public abstract class EntityBaseGuid : EntityBase<GuidId>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EntityBaseGuid"/>.
        /// Crea una clave automática.
        /// </summary>
        protected EntityBaseGuid()
            : this(GuidId.Create()) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EntityBaseGuid"/>.
        /// Crea una clave custom.
        /// </summary>
        /// <param name="id">Clave para la entidad.</param>
        protected EntityBaseGuid(GuidId id)
           : base(id) { }
    }
}
