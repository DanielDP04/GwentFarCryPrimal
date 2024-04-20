using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    /// <summary>
    /// Esta clase representa la función de las cartas
    /// </summary>
    public class Faction
    {
        /// <summary>
        /// El nombre de la facción
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// La descripción de la facción
        /// </summary>
        public string Description { get; private set; }

        public Faction(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Faction other = (Faction)obj;
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}