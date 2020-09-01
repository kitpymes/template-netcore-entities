// -----------------------------------------------------------------------
// <copyright file="SubscriptionEnum.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /*
       Clase de enumeraciones de subscripciones EnumerationBaseInt<Subscription>
       Contiene la lista de subscripciones
    */

    /// <summary>
    /// Clase de enumeraciones de subscripciones <c>EnumerationBaseInt</c>.
    /// Contiene la lista de subscripcione.
    /// <list type="bullet">
    ///     <item>
    ///         <term>Free = 1</term>
    ///         <description>Subscripci�n gratis</description>
    ///     </item>
    ///     <item>
    ///         <term>Silver = 2</term>
    ///         <description>Subscripci�n plata</description>
    ///     </item>
    ///     <item>
    ///         <term>Gold = 3</term>
    ///         <description>Subscripci�n oro</description>
    ///     </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todas las subscripciones.</para>
    /// </remarks>
    public class SubscriptionEnum : EnumerationBaseInt<SubscriptionEnum>
    {
        /// <summary>
        /// Subscripci�n gratis.
        /// </summary>
        public static readonly SubscriptionEnum Free = new SubscriptionEnum(1, nameof(Free));

        /// <summary>
        /// Subscripci�n plata.
        /// </summary>
        public static readonly SubscriptionEnum Silver = new SubscriptionEnum(2, nameof(Silver));

        /// <summary>
        /// Subscripci�n oro.
        /// </summary>
        public static readonly SubscriptionEnum Gold = new SubscriptionEnum(3, nameof(Gold));

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SubscriptionEnum"/>.
        /// </summary>
        /// <param name="value">Valor de la subscripci�n.</param>
        /// <param name="name">Nombre de la subscripci�n.</param>
        private SubscriptionEnum(int value, string name)
            : base(value, name) { }

        /// <summary>
        /// Obtiene un valor que indica si la subscripci�n es gratis.
        /// </summary>
        public bool IsFree => Name == Free.Name;

        /// <summary>
        /// Obtiene un valor que indica si la subscripci�n es plata.
        /// </summary>
        public bool IsSilver => Name == Silver.Name;

        /// <summary>
        /// Obtiene un valor que indica si la subscripci�n es gold.
        /// </summary>
        public bool IsGold => Name == Gold.Name;
    }
}