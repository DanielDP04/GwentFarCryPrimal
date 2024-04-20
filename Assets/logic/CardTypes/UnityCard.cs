using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logic;
using System;

namespace Logic.CardTypes
{
    public class UnityCard : Card
    {
        /// <summary>
        /// Los tipos de ataques que puede realizar esta carta.
        /// Esto se utiliza para determinar en qué filas se puede colocar la tarjeta.
        /// </summary>
        public AttackType AttackType { get; private set; }

        private int basePowerAttack;

        ///<summary>
        /// El poder de la tarjeta
        /// </summary>
        public int PowerAttack { get; private set; }

        /// <summary>
        /// Este es el efecto de poder de esta carta.
        /// Si es nula, entonces esta carta no tiene efecto de poder.
        /// </summary>
        public PowerEffect PowerEffect { get; private set; }

        public UnityCard(string name, string description, Faction faction, AttackType attackType, int power) : base(name, description, faction)
        {
            AttackType = attackType;
            basePowerAttack = power;
            PowerAttack = power;
        }

        /// <summary>
        /// Devuelve True si la carta tiene un efecto de poder.
        /// </summary>
        /// <returns></returns>
        public bool HasPowerEffect()
        {
            return PowerEffect != null;
        }

        /// <summary>
        /// Modifique el ataque base mediante esta función. Un ejemplo será -> ModifyBasePower(x => x * 2)
        /// </summary>
        /// <param name="modifier"></param>
        public void ModifyBasePower(Func<int, int> modifier)
        {
            PowerAttack = modifier(basePowerAttack);
        }
    }
}
