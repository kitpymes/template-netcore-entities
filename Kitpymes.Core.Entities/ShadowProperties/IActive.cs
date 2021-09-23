// -----------------------------------------------------------------------
// <copyright file="IActive.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Estado de una entidad para determinar si se encuentra activa.
    /// </summary>
    public interface IActive
    {
        /// <summary>
        /// Estado de una propiedad.
        /// </summary>
        public const string IsActive = nameof(IsActive);
    }
}
