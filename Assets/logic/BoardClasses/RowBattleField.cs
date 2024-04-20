using System;
using System.Collections;
using System.Collections.Generic;
using Logic;
using Logic.CardTypes;

namespace Logic.BoardClasses
{
    /// <summary>
    /// Esta clase representa una fila en el campo de batalla de un jugador en la que se colocan las cartas.
    /// </summary>
    public class RowBattleField
    {
        /// <summary>
        /// Esta propiedad representa el tipo de ataque de la fila. Solo las cartas con este tipo de ataque se pueden colocar en esta fila.
        /// </summary>
        public AttackType AttackType { get; private set; }

        private List<UnityCard> cards = new List<UnityCard>();

        /// <summary>
        /// Esta es la versión de solo lectura de las tarjetas de la fila.
        /// </summary>
        public IReadOnlyList<UnityCard> Cards => cards;

        /// <summary>
        /// Esta es la tarjeta de aumento real en la fila. Es nulo si no hay ninguna tarjeta de aumento en la fila.
        /// </summary>
        public IncreaseCard ActualIncreaseCard { get; set; }

        public RowBattleField(AttackType attackType)
        {
            AttackType = attackType;
        }

        /// <summary>
        /// Devuelve True si hay una tarjeta de aumento en la fila.
        /// </summary>
        /// <returns></returns>
        public bool IsThereAIncreaseCard()
        {
            return ActualIncreaseCard != null;
        }

        /// <summary>
        /// Este método agrega una nueva tarjeta a la fila. Devuelve True si la tarjeta se agregó correctamente, False en caso contrario.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool AddCard(UnityCard card)
        {
            if ((card.AttackType & AttackType) != 0) // 0011 & 0010 = 0010
            {
                cards.Add(card);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Este método elimina una tarjeta de la fila. Devuelve True si la tarjeta se retiró correctamente, False en caso contrario.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool RemoveCard(UnityCard card)
        {
            return cards.Remove(card);
        }

        /// <summary>
        /// Este método devuelve la primera tarjeta que coincide con un predicado
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public UnityCard FindCard(Predicate<UnityCard> match)
        {
            return cards.Find(match);
        }

        /// <summary>
        /// Este método devuelve la lista de todas las tarjetas de esta fila que coinciden con el predicado especificado
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public List<UnityCard> FindAllCards(Predicate<UnityCard> match)
        {
            return cards.FindAll(match);
        }

    }
}