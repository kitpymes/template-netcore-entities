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
    ///         <description>Subscripción gratis</description>
    ///     </item>
    ///     <item>
    ///         <term>Silver = 2</term>
    ///         <description>Subscripción plata</description>
    ///     </item>
    ///     <item>
    ///         <term>Gold = 3</term>
    ///         <description>Subscripción oro</description>
    ///     </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todas las subscripciones.</para>
    /// </remarks>
    public class SubscriptionEnum : EnumerationBaseInt<SubscriptionEnum>
    {
        /// <summary>
        /// Subscripción gratis.
        /// <para><strong>Free</strong> = 1.</para>
        /// </summary>
        public static readonly SubscriptionEnum Free = new (1, nameof(Free));

        /// <summary>
        /// Subscripción plata.
        /// <para><strong>Silver</strong> = 2.</para>
        /// </summary>
        public static readonly SubscriptionEnum Silver = new (2, nameof(Silver));

        /// <summary>
        /// Subscripción oro.
        /// <para><strong>Gold</strong> = 3.</para>
        /// </summary>
        public static readonly SubscriptionEnum Gold = new (3, nameof(Gold));

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SubscriptionEnum"/>.
        /// </summary>
        /// <param name="value">Valor de la subscripción.</param>
        /// <param name="name">Nombre de la subscripción.</param>
        public SubscriptionEnum(int value, string name)
            : base(value, name)
        {
            if (Shared.Util.Check.IsRange(1, 3).HasErrors)
            {
                Shared.Util.Check.Throw($"El id {value} ya existe.");
            }
        }

        /// <summary>
        /// Obtiene un valor que indica si la subscripción es gratis.
        /// </summary>
        public bool IsFree => Name == Free.Name;

        /// <summary>
        /// Obtiene un valor que indica si la subscripción es plata.
        /// </summary>
        public bool IsSilver => Name == Silver.Name;

        /// <summary>
        /// Obtiene un valor que indica si la subscripción es gold.
        /// </summary>
        public bool IsGold => Name == Gold.Name;
    }
}