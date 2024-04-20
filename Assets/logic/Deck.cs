using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 

namespace Logic
{
    /// <summary>
    /// Esta clase representa un deck de cartas
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Esta es la facción del deck
        /// </summary>
        public Faction Faction { get; private set; }

        /// <summary>
        /// Esta es la lista de cartas de la deck
        /// </summary>
        private LinkedList<Card> cards = new LinkedList<Card>();

        public Deck(Faction faction)
        {
            Faction = faction;
        }

        public bool AddCard(Card card)
        {
            if (card.Faction != Faction && card.Faction.Name != "Neutral")
            {
                return false;
            }

            cards.AddLast(card);
            return true;
        }

        /// <summary>
        /// Este método encuentra una carta en el mazo que coincida con el predicado
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public Card FindCard(Predicate<Card> match) // FindCard(card => card.PowerAttack > 10) // Func<Card, bool>
        {
            return cards.FirstOrDefault(card => match(card));
        }

        /// <summary>
        /// Este método encuentra todas las cartas del deck que coinciden con el predicado
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public List<Card> FindAllCards(Predicate<Card> match)
        {
            return cards.Where(card => match(card)).ToList();
        }

        /// <summary>
        /// Este método ordena las cartas del deck de forma aleatoria
        /// </summary>
        public void Shuffle()
        {
            var random = new Random();
            var shuffledCards = cards.OrderBy(card => random.Next()).ToList();
            cards = new LinkedList<Card>(shuffledCards);
        }

        /// <summary>
        /// Este método devuelve la siguiente carta del decj y la retira del deck
        /// </summary>
        /// <returns></returns>
        public Card GetNextCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            var card = cards.First.Value;
            cards.RemoveFirst();
            return card;
        }

        /// <summary>
        /// Este método elimina todas las cartas del deck que coinciden con el predicado.
        /// Esto es útil para los poderes de algunas cartas
        /// </summary>
        /// <param name="match"></param>
        public void RemoveCardsMatchingPredicate(Predicate<Card> match)
        {
            cards = new LinkedList<Card>(cards.Where(card => !match(card)));
        }
    }
}