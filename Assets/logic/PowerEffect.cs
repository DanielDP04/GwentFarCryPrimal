using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logic;

namespace Logic
{
    /// <summary>
    /// Esta es la clase base para todos los efectos de poder de las cartas
    /// </summary>
    public abstract class PowerEffect
    {
        /// <summary>
        /// Este método se llama cuando se activa el efecto de potencia.
        /// Un poder no es otra cosa que un código que se ejecuta cuando se juega la carta.
        /// El código se ejecuta en la clase board. Esto es por flexibilidad
        /// </summary>
        /// <param name="board">El tablero en el que se va a aplicar el efecto</param>
        /// <param name="playerId">El jugador que está llamando el efecto</param>
        /// <param name="callinCard">La carta que está llamando al efecto</param>
        /// <param name="attackType">El tipo de ataque que se está realizando</param>
        public abstract void ActivatePowerEffect(Board board, string playerId, Card callinCard, AttackType attackType);
    }
}
