// -----------------------------------------------------------------------
// <copyright file="Telephone.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    using System.Diagnostics.CodeAnalysis;
    using Kitpymes.Core.Shared;

    /// <summary>
    /// Objeto de valor para tel�fonos.
    /// </summary>
    public sealed class Telephone : ValueObjectBase
    {
        private Telephone() { }

        private Telephone(string? prefix, long number)
        => ChangePrefix(prefix).ChangeNumber(number);

        /// <summary>
        /// Obtiene un tel�fono vacio.
        /// </summary>
        public static Telephone Null => new Telephone();

        /// <summary>
        /// Obtiene un valor que indica si el tel�fono esta vacio.
        /// </summary>
        public bool IsNull => Shared.Util.Check.IsNullOrEmpty(Prefix, Number).HasErrors;

        /// <summary>
        /// Obtiene el prefijo del pais.
        /// </summary>
        public string? Prefix { get; private set; }

        /// <summary>
        /// Obtiene el n�mero.
        /// </summary>
        public long? Number { get; private set; }

        /// <summary>
        /// Crea un nuevo t�lefono.
        /// </summary>
        /// <param name="prefix">Prefijo del pais.</param>
        /// <param name="number">N�mero de t�lefono.</param>
        /// <returns>Telephone | ApplicationException.</returns>
        [return: NotNull]
        public static Telephone Create(string? prefix, long number)
        => new Telephone(prefix, number);

        /// <summary>
        /// Modifica el prefijo del pais.
        /// </summary>
        /// <param name="prefix">Prefijo del pais.</param>
        /// <returns>Telephone.</returns>
        [return: NotNull]
        public Telephone ChangePrefix(string? prefix)
        {
            Prefix = prefix.ToIsNullOrEmptyThrow(nameof(prefix));

            return this;
        }

        /// <summary>
        /// Modifica el n�mero de t�lefono.
        /// </summary>
        /// <param name="number">N�mero de t�lefono.</param>
        /// <returns>Telephone.</returns>
        [return: NotNull]
        public Telephone ChangeNumber(long number)
        {
            Number = number.ToIsLessThrow(1, nameof(number));

            return this;
        }

        /// <summary>
        /// Devuelve el t�lefono completo.
        /// </summary>
        /// <returns>"{Prefix} {Number}".</returns>
        public override string ToString() => $"{Prefix} {Number}";

        /// <inheritdoc/>
        protected override System.Collections.Generic.IEnumerable<object?> GetEqualityComponents()
        {
            yield return Prefix;
            yield return Number;
        }
    }
}
