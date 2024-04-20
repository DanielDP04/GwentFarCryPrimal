using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    /// <summary>
    /// Esta es la clase base para todas las cartas del juego
    /// </summary>
    public abstract class Card
    {
        /// <summary>
        /// Este es el nombre de la carta
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Esta es una breve descripción de la carta
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// La facción de la carta
        /// </summary>
        public Faction Faction { get; private set; }

        public Card(string name, string description, Faction faction)
        {
            Name = name;
            Description = description;
            Faction = faction;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Card card = (Card)obj;
            return Name == card.Name && Faction == card.Faction;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Faction.GetHashCode();
        }
    }

}