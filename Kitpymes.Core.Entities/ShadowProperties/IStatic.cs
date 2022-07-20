// -----------------------------------------------------------------------
// <copyright file="IStatic.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Estado de una entidad para determinar si no se puede eliminar.
    /// </summary>
    public interface IStatic
    {
        /// <summary>
        /// Propiedad por defecto.
        /// </summary>
        public const string IsStatic = nameof(IsStatic);
    }
}
