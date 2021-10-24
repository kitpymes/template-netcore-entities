// -----------------------------------------------------------------------
// <copyright file="GuidId.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using Kitpymes.Core.Shared;

    /// <summary>
    /// Objeto de valor para id de cadena.
    /// </summary>
    public sealed class GuidId : ValueObjectBase
    {
        private GuidId() { }

        private GuidId(Guid id) => Value = id;

        /// <summary>
        /// Obtiene el id vacio.
        /// </summary>
        public static GuidId Null => new ();

        /// <summary>
        /// Obtiene un valor que indica si el id esta vacio.
        /// </summary>
        public bool IsNull => Value.ToIsNullOrEmpty();

        /// <summary>
        /// Obtiene el valor del id.
        /// </summary>
        public Guid Value { get; private set; }

        /// <summary>
        /// Crea un nuevo id.
        /// </summary>
        /// <returns>GuidId.</returns>
        [return: NotNull]
        public static GuidId Create() => Create(Guid.NewGuid());

        /// <summary>
        /// Crea un nuevo id secuencial.
        /// </summary>
        /// <returns>GuidId.</returns>
        [return: NotNull]
        public static GuidId CreateSecuencial() => Create(NextGuid());

        /// <summary>
        /// Crea un nuevo id.
        /// </summary>
        /// <param name="id">Nuevo id.</param>
        /// <returns>GuidId | ApplicationException.</returns>
        [return: NotNull]
        public static GuidId Create(Guid id) => new (id);

        /// <summary>
        /// Devuelve el id.
        /// </summary>
        /// <returns>string.</returns>
        public override string ToString() => $"{Value}";

        /// <inheritdoc/>
        protected override System.Collections.Generic.IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }

        private static Guid NextGuid()
        {
            var counter = DateTime.UtcNow.Ticks;

            var guidBytes = Guid.NewGuid().ToByteArray();

            var counterBytes = BitConverter.GetBytes(Interlocked.Increment(ref counter));

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            guidBytes[08] = counterBytes[1];
            guidBytes[09] = counterBytes[0];
            guidBytes[10] = counterBytes[7];
            guidBytes[11] = counterBytes[6];
            guidBytes[12] = counterBytes[5];
            guidBytes[13] = counterBytes[4];
            guidBytes[14] = counterBytes[3];
            guidBytes[15] = counterBytes[2];

            return new Guid(guidBytes);
        }
    }
}
