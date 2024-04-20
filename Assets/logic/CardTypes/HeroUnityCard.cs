using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logic;

namespace Logic.CardTypes
{
    public class HeroUnityCard : UnityCard
    {
        public HeroUnityCard(string name, string description, Faction faction, AttackType attackType, int power) : base(name, description, faction, attackType, power)
        {
        }
    }
}
