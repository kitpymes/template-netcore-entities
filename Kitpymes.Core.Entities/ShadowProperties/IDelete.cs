// -----------------------------------------------------------------------
// <copyright file="IStatus.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Estado de una entidad para determinar si fue eliminada lógicamente.
    /// </summary>
    public interface IDelete
    {
        /// <summary>
        /// Estado de una propiedad.
        /// </summary>
        public const string IsDelete = nameof(IsDelete);
    }
}
