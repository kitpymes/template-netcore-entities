// -----------------------------------------------------------------------
// <copyright file="EnumerationBase.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Reflection;
    using Kitpymes.Core.Shared;

    /*
        Clase base de enumeraciones EnumerationBase<TEnum, TValue>
        Contiene las acciones comunes a todas las enumeraciones
    */

    /// <summary>
    /// Clase base de enumeraciones <c>EnumerationBase</c>.
    /// Contiene las acciones comunes a todas las enumeraciones.
    /// </summary>
    /// <typeparam name="TEnum">Tipo de enumeraci�n.</typeparam>
    /// <typeparam name="TValue">Tipo de dato de la clave de la enumeraci�n.</typeparam>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todas las acciones necesarias para las enumeraciones.</para>
    /// </remarks>
    public abstract class EnumerationBase<TEnum, TValue> : INotMapped
        where TEnum : EnumerationBase<TEnum, TValue>
        where TValue : IEquatable<TValue>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EnumerationBase{TEnum, TValue}"/>.
        /// </summary>
        /// <param name="value">Valor de la enumeraci�n.</param>
        /// <param name="name">Nombre de la enumeraci�n.</param>
        /// <param name="shortName">Nombre corto de la enumeraci�n.</param>
        protected EnumerationBase(TValue value, string name, string? shortName = null)
        {
            var enumTypeName = typeof(TEnum).Name;

            Value = value.ToIsNullOrEmptyThrow($"{enumTypeName}-{nameof(value)}");

            Name = name.ToIsNullOrEmptyThrow($"{enumTypeName}-{nameof(name)}");

            ShortName = shortName;
        }

        /// <summary>
        /// Obtiene el nombre de la enumeraci�n.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Obtiene el nombre corto de la enumeraci�n.
        /// </summary>
        public string? ShortName { get; }

        /// <summary>
        /// Obtiene el valor de la enumeraci�n.
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// Verifica que si dos objetos son iguales.
        /// </summary>
        /// <param name="left">Objeto fuente.</param>
        /// <param name="right">Objeto destino.</param>
        /// <returns>true | false.</returns>
        public static bool operator ==(EnumerationBase<TEnum, TValue> left, EnumerationBase<TEnum, TValue> right)
        => left?.Equals(right) ?? false;

        /// <summary>
        /// Verifica que si dos objetos no son iguales.
        /// </summary>
        /// <param name="left">Objeto fuente.</param>
        /// <param name="right">Objeto destino.</param>
        /// <returns>true | false.</returns>
        public static bool operator !=(EnumerationBase<TEnum, TValue> left, EnumerationBase<TEnum, TValue> right)
        => !left?.Equals(right) ?? false;

        /// <inheritdoc/>
        public override string ToString() => Name;

        /// <summary>
        /// Obtiene la lista de una enumeraci�n.
        /// </summary>
        /// <returns>IEnumerable{TEnum}.</returns>
#pragma warning disable CA1000 // No declarar miembros est�ticos en tipos gen�ricos
#pragma warning disable SA1204 // Static elements should appear before instance elements
        public static List<TEnum> GetAll()
#pragma warning restore SA1204 // Static elements should appear before instance elements
#pragma warning restore CA1000 // No declarar miembros est�ticos en tipos gen�ricos
        => typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null)).Cast<TEnum>().ToList();

        /// <summary>
        /// Obtiene una enumeraci�n por su valor.
        /// </summary>
        /// <param name="value">Valor de una enumeraci�n.</param>
        /// <returns>TEnum.</returns>
#pragma warning disable CA1000 // No declarar miembros est�ticos en tipos gen�ricos
        public static TEnum? ToEnum(TValue value)
#pragma warning restore CA1000 // No declarar miembros est�ticos en tipos gen�ricos
        => GetAll().FirstOrDefault(x => x.Value.Equals(value));

        /// <summary>
        /// Obtiene una enumeraci�n por su nombre.
        /// </summary>
        /// <param name="name">Nombre de una enumeraci�n.</param>
        /// <returns>TEnum.</returns>
#pragma warning disable CA1000 // No declarar miembros est�ticos en tipos gen�ricos
        public static TEnum? ToEnum(string? name)
#pragma warning restore CA1000 // No declarar miembros est�ticos en tipos gen�ricos
        => GetAll().FirstOrDefault(x => x.Name == name || x.ShortName == name);

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (EnumerationBase<TEnum, TValue>)obj;

            return Equals(other.Value);
        }

        /// <summary>
        /// Compara si el valor contenido en el campo Value de dos objetos son iguales.
        /// </summary>
        /// <param name="value">Valor a comparar.</param>
        /// <returns>true | false.</returns>
        public bool Equals([AllowNull] TValue value)
        => Value?.Equals(value) ?? false;

        /// <inheritdoc/>
        public override int GetHashCode()
        => (GetType().ToString() + Value).GetHashCode(StringComparison.OrdinalIgnoreCase);
    }
}
