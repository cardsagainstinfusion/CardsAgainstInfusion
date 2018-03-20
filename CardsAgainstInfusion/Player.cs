using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardsAgainstInfusion.Model;

/*
Player Interface
Member variables
List<Card> Hand
This is the given players hand of either 5 blue cards, or 5 white cards
Methods(behaviors)
void DrawCard(enum TypeOfCard, int numberOfCards)
Initial use may be CardDraw(TypeOfCard.Blue, 5)
incremental uses would be similar but with only 1 card being drawn.
Card PlayCard(int cardNumber)
Either the Human player(Client) or the AI player(consultant) would choose a card such that the method would 
be called PlayCard(3) to choose the third card in their hand.
*/

namespace CardsAgainstInfusion
{
    interface Player
    {        
        void DrawCard(List<Card> deck, int numberOfCards);

        Card PlayCard(int cardNumber);
    }
}
