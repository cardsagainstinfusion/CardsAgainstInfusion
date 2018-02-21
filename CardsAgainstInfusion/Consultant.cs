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
            // most common behaviour:
            // 1. match tags - compare blue card tag with the tags on each white card
            var tagMatchList = new List<Card>();

            foreach (var whiteCard in Hand)
            {
                foreach (var tag in whiteCard.Tags)
                {
                    if (blueCard.Tags.Contains(tag))
                    {
                        tagMatchList.Add(whiteCard);
                        break;
                    }
                }
            }
            // 2. if we have no matches randomly select card
            if (tagMatchList.Count == 0)
            {
                // pick a random card
                return new Random().Next(0, 4);
            }

            // 3. if one card matches choose that card
            if (tagMatchList.Count == 1)
            {
                // find the index of the matching card and return it.
                return Hand.IndexOf(tagMatchList[0]);
            }
            // 4. if more then one card matches - compare those cards to our favorites list.
            var favoriteTagsMatchList = new List<Card>();

            if (tagMatchList.Count > 1)
            {
                foreach (var whiteCard in tagMatchList)
                {
                    foreach (var tag in whiteCard.Tags)
                    {
                        if (FavoriteTags.Contains(tag))
                        {
                            favoriteTagsMatchList.Add(whiteCard);
                            break;
                        }
                    }
                }
            }
            // 4.1 if there are no matches to the favorites list, pick a random card from the subset
            if (favoriteTagsMatchList.Count == 0)
            {
                // random card of the matches
                var indexOfCardToPick = new Random().Next(favoriteTagsMatchList.Count);
                // find the index of the randomly selected card
                var cardToPick = favoriteTagsMatchList[indexOfCardToPick];
                return Hand.IndexOf(cardToPick);
            }
            // 4.2 if there is one match choose it from the subset
            if (favoriteTagsMatchList.Count == 1)
            {
                return Hand.IndexOf(favoriteTagsMatchList[0]);
            }

            // 4.3 if there are more than one pick the first one.
            // we could change this to grab the last or random element
            return Hand.IndexOf(favoriteTagsMatchList[0]);
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
        private List<Tuple<Card, Card>> _winningCards;

        public List<Tuple<Card, Card>> WinningCards
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