using System;
using System.Collections;
using System.Collections.Generic;
using Logic.BoardClasses;
using Logic.CardTypes;

namespace Logic
{
    /// <summary>
    /// Esta clase representa la parte del tablero de juego de un jugador.
    /// Cada jugador tiene 3 filas en las que jugar a las cartas.
    /// </summary>
    public class PlayerBoard
    {
        /// <summary>
        /// El ID del jugador que posee este tablero.
        /// </summary>
        public string PlayerId { get; private set; }

        /// <summary>
        /// Este es el mazo del jugador
        /// </summary>
        public Deck Deck { get; private set; }

        /// <summary>
        /// Este es el cementerio del jugador. Todas las cartas que se destruyen se colocan aquí.
        /// </summary>
        public Deck Graveyard { get; private set; }

        /// <summary>
        /// Esta propiedad representa la carta de líder del jugador.
        /// </summary>
        public LeaderCard LeaderCard { get; set; }

        /// <summary>
        /// La fila que corresponde al tipo de ataque cuerpo a cuerpo.
        /// </summary>
        public RowBattleField MeleeRow { get; private set; }

        /// <summary>
        /// La fila que corresponde al tipo de ataque a distancia.
        /// </summary>
        public RowBattleField RangedRow { get; private set; }

        /// <summary>
        /// La fila que corresponde al tipo de ataque de asedio.
        /// </summary>
        public RowBattleField SiegeRow { get; private set; }

        public PlayerBoard(string playerId, Deck deck)
        {
            PlayerId = playerId;
            Deck = deck;
            MeleeRow = new RowBattleField(AttackType.Melee);
            RangedRow = new RowBattleField(AttackType.Ranged);
            SiegeRow = new RowBattleField(AttackType.Siege);
        }

        /// <summary>
        /// Devuelve la fila que corresponde al tipo de ataque.
        /// </summary>
        /// <param name="attackType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public RowBattleField GetRow(AttackType attackType)
        {
            switch (attackType)
            {
                case AttackType.Melee:
                    return MeleeRow;
                case AttackType.Ranged:
                    return RangedRow;
                case AttackType.Siege:
                    return SiegeRow;
                default:
                    throw new ArgumentOutOfRangeException(nameof(attackType), attackType, null);
            }
        }

        public bool AddCardToRow(UnityCard card, AttackType attackType)
        {
            switch (attackType)
            {
                case AttackType.Melee:
                    return MeleeRow.AddCard(card);
                case AttackType.Ranged:
                    return RangedRow.AddCard(card);
                case AttackType.Siege:
                    return SiegeRow.AddCard(card);
                default:
                    throw new ArgumentOutOfRangeException(nameof(attackType), attackType, null);
            }
        }
    }
}