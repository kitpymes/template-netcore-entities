// -----------------------------------------------------------------------
// <copyright file="EntityBaseGuidSequencial.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Entidad base para is de tipo Guid.
    /// </summary>
    public abstract class EntityBaseGuidSequencial : EntityBase<GuidId>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EntityBaseGuidSequencial"/>.
        /// Crea una clave automática.
        /// </summary>
        protected EntityBaseGuidSequencial()
            : base(GuidId.CreateSecuencial()) { }
    }
}
