using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    /// <summary>
    /// Este enum representa el tipo de ataque que puede realizar una unidad
    /// </summary>
    [Flags] // AttackType value = AttackType.Melee | AttackType.Ranged | AttackType.Siege = 0001 | 0010 | 0100 = 0111
    public enum AttackType // 0001, 0010, 0100
    {// 1 << 0 = 0001, 1 << 1 = 0010, 1 << 2 = 0100
        /// <summary>
        /// Tipo de ataque al cuerpo
        /// </summary>
        Melee = 1 << 0,
        /// <summary>
        /// Ataque a distancia
        /// </summary>
        Ranged = 1 << 1,
        /// <summary>
        /// Ataque de asedio
        /// </summary>
        Siege = 1 << 2
    }
}