using System;
using System.Collections.Generic;

namespace CardsAgainstInfusion
{
    class Client : Player
    {
        List<Card> Hand;

        /// <summary>
        /// DrawCard adds the specified number of blue cards to the client's hand from the deck of blue cards
        /// </summary>
        /// <param name="blueDeck">The deck of cards to draw from</param>
        /// <param name="numberOfCards">The number of cards being drawn from the deck</param>
        public void DrawCard(List<Card> blueDeck, int numberOfCards)
        {
            //Verify that the number of cards you're asking for is less than the contents of the deck
            if(numberOfCards <= blueDeck.Count)
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    Hand.Add(blueDeck[0]);
                    blueDeck.RemoveAt(0);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Plays the specified card from the client's hand determined by card index
        /// </summary>
        /// <param name="cardNumber">The index of the card to play</param>
        /// <returns></returns>
        public Card PlayCard(int cardNumber)
        {
            if ((cardNumber <= Hand.Count) && (cardNumber > 0))
            {
                Card cardToPlay = Hand[cardNumber-1];
                Hand.Remove(cardToPlay);

                return cardToPlay;
            }
            else
            {
                throw new ArgumentException("Invalid Card Index");
            }
        }
    }
}
