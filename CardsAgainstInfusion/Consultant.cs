using System;
using System.Collections.Generic;

namespace CardsAgainstInfusion
{
    class Consultant : Player
    {
        List<Card> Hand;

        public void DrawCard(Model.TypeOfCard cardType, int numberOfCards)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard(int cardIndex)
        {

            Card cardToPlay = Hand[cardIndex];
            cardToPlay.PlayedBy = PlayerName;
            Hand.RemoveAt(cardIndex);

            return cardToPlay; 
        }
        int ChooseWhiteCardToPlay(Card blueCard)
        {
            return -666;
        }

        string MakeComment()
        {
            int count = Comments.Count;
            Random random = new Random();
            int randomNumber = random.Next(0, count);

            return Comments[randomNumber];
        }

        public Consultant(List<string> favoriteTags, string playerName, List<string> comments)
        {
            Score = 0;
            WinningCards = new List<Tuple<Card, Card>>();
            FavoriteTags = favoriteTags;
            PlayerName = playerName;
            Comments = comments;
        }
        public int Score { get; set; }
        private List<Tuple<Card,Card>> _winningCards;

        public List<Tuple<Card,Card>> WinningCards
        {
            //TODO break this out to a method
            get { return _winningCards; }
            private set { _winningCards.Add(value[0]); }
        }
         
        public List<string> FavoriteTags { get; set; }
        public string PlayerName { get; set; }
        public List<string> Comments { get; set; }

    }
}
