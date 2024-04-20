using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logic;

namespace Logic.CardTypes
{
    public class LeaderCard : Card
    {
        public LeaderCard(string name, string description, Faction faction) : base(name, description, faction)
        {
        }
    }
}
