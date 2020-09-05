// -----------------------------------------------------------------------
// <copyright file="ExpireSettings.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Security
{
    /*
        Clase para la configuraci�n de la fecha de expiraci�n del token de sesi�n ExpireSettings
        Contiene los m�todos para la configuraci�n de la fecha de expiraci�n del token de sesi�n
    */

    /// <summary>
    /// Clase para la configuraci�n de la fecha de expiraci�n del token de sesi�n <c>ExpireSettings</c>.
    /// Contiene los m�todos para la configuraci�n de la fecha de expiraci�n del token de sesi�n.
    /// </summary>
    /// <remarks>
    /// <para>En esta clase se pueden agregar todos los m�todos para la configuraci�n de la fecha de expiraci�n del token de sesi�n.</para>
    /// </remarks>
    public class ExpireSettings
    {
        private int _days = 30;
        private int _hours = 0;
        private int _minutes = 0;
        private int _seconds = 0;

        /// <summary>
        /// Obtiene o establece el d�a de expiraci�n.
        /// </summary>
        public int? Days
        {
            get => _days;
            set
            {
                if (value.HasValue)
                {
                    _days = value.Value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece la hora de expiraci�n.
        /// </summary>
        public int? Hours
        {
            get => _hours;
            set
            {
                if (value.HasValue)
                {
                    _hours = value.Value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece los minutos de expiraci�n.
        /// </summary>
        public int? Minutes
        {
            get => _minutes;
            set
            {
                if (value.HasValue)
                {
                    _minutes = value.Value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece los segundos de expiraci�n.
        /// </summary>
        public int? Seconds
        {
            get => _seconds;
            set
            {
                if (value.HasValue)
                {
                    _seconds = value.Value;
                }
            }
        }
    }
}
