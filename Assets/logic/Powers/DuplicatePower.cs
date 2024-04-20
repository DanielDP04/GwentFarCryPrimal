using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logic;
using Logic.BoardClasses;
using Logic.CardTypes;

namespace Logic.Powers
{
    /// <summary>
    /// Esta es la clase base para todos los efectos de poder de las cartas
    /// </summary>
    public class DuplicatePower : PowerEffect
    {
        public override void ActivatePowerEffect(Board board, string playerId, Card callinCard, AttackType attackType)
        {
            // Obtener el tablero de jugador
            PlayerBoard playerBoard = board.GetPlayerBoard(playerId);

            // ClimateCard climateCard = (ClimateCard)playerBoard.Deck.FindCard(card => card is ClimateCard && card.Name == "Rain");

            // Obtener la fila en la que se encuentra la tarjeta
            RowBattleField row = playerBoard.GetRow(attackType);

            // Lanza la carta a la carta de Unity
            UnityCard unityCard = callinCard as UnityCard;

            // Encuentra todas las cartas con el mismo nombre
            List<UnityCard> allCards = row.FindAllCards((card => card.Name == unityCard.Name));

            // Modifica el poder de todas las cartas con el mismo nombre
            foreach (UnityCard card in allCards)
            {
                card.ModifyBasePower(power => power * allCards.Count);
            }
        }
    }
}
