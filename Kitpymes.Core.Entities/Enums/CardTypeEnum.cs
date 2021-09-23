// -----------------------------------------------------------------------
// <copyright file="CardTypeEnum.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /*
        Clase de enumeraciones para las tarjetas de débito o crédito EnumerationBaseInt<CardType>
        Contiene la lista de tarjetas de débito o crédito
    */

    /// <summary>
    /// Clase de enumeraciones para las tarjetas de débito o crédito <c>EnumerationBaseInt</c>.
    /// Contiene la lista de tarjetas de débito o crédito.
    /// <list type="bullet">
    ///     <item>
    ///         <term>Amex = 1</term>
    ///         <description>Tarjeta American Express</description>
    ///     </item>
    ///     <item>
    ///         <term>Visa = 2</term>
    ///         <description>Tarjeta Visa</description>
    ///     </item>
    ///     <item>
    ///         <term>MasterCard = 3</term>
    ///         <description>Tarjeta Master Card</description>
    ///     </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todas las tarjetas de débito o crédito.</para>
    /// </remarks>
    public class CardTypeEnum : EnumerationBaseInt<CardTypeEnum>
    {
        /// <summary>
        /// Tarjeta American Express.
        /// <para><strong>Amex</strong> = 1.</para>
        /// </summary>
        public static readonly CardTypeEnum Amex = new (1, "American Express", nameof(Amex));

        /// <summary>
        /// Tarjeta American Visa.
        /// <para><strong>Visa</strong> = 2.</para>
        /// </summary>
        public static readonly CardTypeEnum Visa = new (2, nameof(Visa), nameof(Visa));

        /// <summary>
        /// Tarjeta Master Card.
        /// <para><strong>MasterCard</strong> = 3.</para>
        /// </summary>
        public static readonly CardTypeEnum MasterCard = new (3, "Master Card", nameof(MasterCard));

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CardTypeEnum"/>.
        /// </summary>
        /// <param name="value">Valor de la tarjeta.</param>
        /// <param name="name">Nombre de la tarjeta.</param>
        /// <param name="shortName">Nombre corto de la tarjeta.</param>
        public CardTypeEnum(int value, string name, string shortName)
            : base(value, name, shortName)
        {
            if (Shared.Util.Check.IsRange(1, 3).HasErrors)
            {
                Shared.Util.Check.Throw($"El id {value} ya existe.");
            }
        }

        /// <summary>
        /// Obtiene un valor que indica si la tarjeta es american express.
        /// </summary>
        public bool IsAmex => Name == Amex.Name;

        /// <summary>
        /// Obtiene un valor que indica si la tarjeta es visa.
        /// </summary>
        public bool IsVisa => Name == Visa.Name;

        /// <summary>
        /// Obtiene un valor que indica si la tarjeta es MasterCard.
        /// </summary>
        public bool IsMasterCard => Name == MasterCard.Name;
    }
}
