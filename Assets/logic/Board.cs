using System;
using System.Collections;
using System.Collections.Generic;
using Logic.CardTypes;

namespace Logic
{
    /// <summary>
    /// Esta clase representa el tablero del juego.
    /// </summary>
    public class Board
    {
        public PlayerBoard Player1 { get; private set; }

        public PlayerBoard Player2 { get; private set; }

        /// <summary>
        /// Esta es la lista de cartas climáticas del tablero
        /// </summary>
        public List<ClimateCard> ClimateCards { get; private set; } = new List<ClimateCard>();

        public Board(PlayerBoard player1, PlayerBoard player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        /// <summary>
        /// Devuelve el tablero del jugador con el id dado.
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public PlayerBoard GetPlayerBoard(string playerId)
        {
            if (Player1.PlayerId == playerId)
            {
                return Player1;
            }
            else if (Player2.PlayerId == playerId)
            {
                return Player2;
            }
            return null;
        }

        /// <summary>
        /// Este método agrega una nueva tarjeta de clima al tablero.
        /// Solo se pueden agregar 3 cartas de clima al tablero.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool AddClimateCard(ClimateCard card)
        {
            if (ClimateCards.Count < 3)
            {
                ClimateCards.Add(card);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Este método elimina todas las tarjetas climáticas que coincidan con un predicado
        /// </summary>
        /// <param name="predicate"></param>
        public void RemoveClimateCardsMatchingPredicate(Predicate<ClimateCard> predicate) // RemoveClimateCardsMatchingPredicate(climateCard => True)
        {
            ClimateCards.RemoveAll(predicate);
        }
    }
}