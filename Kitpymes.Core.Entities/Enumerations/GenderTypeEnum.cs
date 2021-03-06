// -----------------------------------------------------------------------
// <copyright file="GenderTypeEnum.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Entities
{
    /*
       Clase de enumeraciones para los tipo de sexo EnumerationBaseInt<GenderType>
       Contiene la lista de los tipo de sexo
   */

    /// <summary>
    /// Clase de enumeraciones para los tipo de sexo <c>EnumerationBaseInt</c>.
    /// Contiene la lista de los tipo de sexo.
    /// <list type="bullet">
    ///     <item>
    ///         <term>Male = 1</term>
    ///         <description>Sexo masculino</description>
    ///     </item>
    ///     <item>
    ///         <term>Female = 2</term>
    ///         <description>Sexo femenino</description>
    ///     </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todos los tipo de sexo.</para>
    /// </remarks>
    public class GenderTypeEnum : EnumerationBaseInt<GenderTypeEnum>
    {
        /// <summary>
        /// Sexo masculino.
        /// <para><strong>Male</strong> = 1.</para>
        /// </summary>
        public static readonly GenderTypeEnum Male = new (1, nameof(Male), "M");

        /// <summary>
        /// Sexo femenino.
        /// <para><strong>Female</strong> = 2.</para>
        /// </summary>
        public static readonly GenderTypeEnum Female = new (2, nameof(Female), "F");

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GenderTypeEnum"/>.
        /// </summary>
        /// <param name="value">Valor del tipo de sexo.</param>
        /// <param name="name">Nombre del sexo.</param>
        /// <param name="shortName">Nombre corto del sexo.</param>
        public GenderTypeEnum(int value, string name, string shortName)
            : base(value, name, shortName)
        {
            if (Shared.Util.Check.IsRange(1, 2).HasErrors)
            {
                Shared.Util.Check.Throw($"El id {value} ya existe.");
            }
        }

        /// <summary>
        /// Obtiene un valor que indica si el sexo es masculino.
        /// </summary>
        public bool IsMale => Name == Male.Name;

        /// <summary>
        /// Obtiene un valor que indica si el sexo es femenino.
        /// </summary>
        public bool IsFemale => Name == Female.Name;
    }
}
