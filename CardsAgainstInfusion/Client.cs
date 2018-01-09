using System;
using System.Collections.Generic;

namespace CardsAgainstInfusion
{
    class Client : Player
    {
        List<Card> Hand;

        public void DrawCard(Model.TypeOfCard cardType, int numberOfCards)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard(int cardNumber)
        {
            if ((cardNumber <= Hand.Count) && (cardNumber > 0))
            {
                Card cardToPlay = Hand[cardNumber-1];
                Hand.Remove(cardToPlay);

                return cardToPlay;
            } else
            {
                //TODO: investigate what the best exception type to throw
                throw new ArgumentException();
            }
        }
    }
}
