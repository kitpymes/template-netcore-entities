// -----------------------------------------------------------------------
// <copyright file="INotVisible.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /// <summary>
    /// Propiedad para entidades que no queremos que se muestren al usuario.
    /// </summary>
    public interface INotVisible
    {
        /// <summary>
        /// Propiedad de seguimiento.
        /// </summary>
        public const string IsNotVisible = nameof(IsNotVisible);
    }
}
