// -----------------------------------------------------------------------
// <copyright file="Address.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    using System.Diagnostics.CodeAnalysis;
    using Kitpymes.Core.Shared;

    /// <summary>
    /// Objeto de valor para las direcciones.
    /// </summary>
    public sealed class Address : ValueObjectBase
    {
        private Address() { }

        private Address(string street, int number, string postalCode, string city, string state, string country)
        => ChangeStreet(street)
            .ChangeNumber(number)
            .ChangePostalCode(postalCode)
            .ChangeCity(city)
            .ChangeState(state)
            .ChangeCountry(country);

        /// <summary>
        /// Obtiene una direcci�n vacia.
        /// </summary>
        public static Address Null => new Address();

        /// <summary>
        /// Obtiene un valor que indica si la direcci�n esta vacia.
        /// </summary>
        public bool IsNull => Shared.Util.Check.IsNullOrEmpty(Street, City, State, Country, PostalCode).HasErrors;

        /// <summary>
        /// Obtiene la direcci�n.
        /// </summary>
        public string? Street { get; private set; }

        /// <summary>
        /// Obtiene el n�mero.
        /// </summary>
        public int? Number { get; private set; }

        /// <summary>
        /// Obtiene el c�digo postal.
        /// </summary>
        public string? PostalCode { get; private set; }

        /// <summary>
        /// Obtiene la ciudad.
        /// </summary>
        public string? City { get; private set; }

        /// <summary>
        /// Obtiene el estado.
        /// </summary>
        public string? State { get; private set; }

        /// <summary>
        /// Obtiene el pais.
        /// </summary>
        public string? Country { get; private set; }

        /// <summary>
        /// Crea una nueva direcci�n completa.
        /// </summary>
        /// <param name="street">Direcci�n.</param>
        /// <param name="number">N�mero.</param>
        /// <param name="postalCode">C�digo postal.</param>
        /// <param name="city">Ciudad.</param>
        /// <param name="state">Estado.</param>
        /// <param name="country">Pais.</param>
        /// <returns>Address | ApplicationException.</returns>
        [return: NotNull]
        public static Address Create(string street, int number, string postalCode, string city, string state, string country)
        => new Address(street, number, postalCode, city, state, country);

        /// <summary>
        /// Modifica la direcci�n.
        /// </summary>
        /// <param name="street">Direcci�n nueva.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangeStreet(string? street)
        {
            Street = street.ToIsNullOrEmptyThrow(nameof(street));

            return this;
        }

        /// <summary>
        /// Modifica el n�mero de la direcci�n.
        /// </summary>
        /// <param name="number">N�mero nuevo.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangeNumber(int number)
        {
            Number = number.ToIsLessThrow(1, nameof(number));

            return this;
        }

        /// <summary>
        /// Modifica el c�digo postal.
        /// </summary>
        /// <param name="postalCode">C�digo postal nuevo.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangePostalCode(string? postalCode)
        {
            PostalCode = postalCode.ToIsNullOrEmptyThrow(nameof(postalCode));

            return this;
        }

        /// <summary>
        /// Modifica la cuidad.
        /// </summary>
        /// <param name="city">Ciudad nuevo.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangeCity(string? city)
        {
            City = city.ToIsNullOrEmptyThrow(nameof(city));

            return this;
        }

        /// <summary>
        /// Modifica el estado.
        /// </summary>
        /// <param name="state">Estado nuevo.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangeState(string? state)
        {
            State = state.ToIsNullOrEmptyThrow(nameof(state));

            return this;
        }

        /// <summary>
        /// Modifica el pais.
        /// </summary>
        /// <param name="country">Pais nuevo.</param>
        /// <returns>Address.</returns>
        [return: NotNull]
        public Address ChangeCountry(string? country)
        {
            Country = country.ToIsNullOrEmptyThrow(nameof(country));

            return this;
        }

        /// <summary>
        /// Devuelve la direcci�n completa.
        /// </summary>
        /// <returns>"{Street} {Number}, {PostalCode} - {City} {State}, {Country}".</returns>
        public override string ToString() => $"{Street} {Number}, {PostalCode} - {City} {State}, {Country}";

        /// <inheritdoc/>
        protected override System.Collections.Generic.IEnumerable<object?> GetEqualityComponents()
        {
            yield return Street;
            yield return Number;
            yield return PostalCode;
            yield return City;
            yield return State;
            yield return Country;
        }
    }
}
