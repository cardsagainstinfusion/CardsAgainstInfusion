using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardsAgainstInfusion.Model;

namespace CardsAgainstInfusion
{
    class Card
    {
        public Card(TypeOfCard color, string cardText, List<string> tags, string playedBy)
        {
            Color = color;
            CardText = cardText;
            Tags = tags;
            PlayedBy = playedBy;
        }
        public TypeOfCard Color { get; set; }
        public string CardText { get; set; }
        private List<string> _tags;

        public List<string> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public string PlayedBy { get; set; }
    }
}
//*enum TypeOfCard
//Blue
//White
//*string CardText
//This is the text related to the type of card(e.g: White has a word or words, Blue has an incomplete sentence)
//*List<string> Tags
//This is a list of words associated with the white cards.
//Blue cards will have an empty list.
//*string PlayedBy
//The name of the AI who played this card so we know who to give credit to when it is chosen as the winner.
//Placeholder for storing metrics - TBD