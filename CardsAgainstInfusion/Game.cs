using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsAgainstInfusion
{
    class Game
    {
        static void Main(string[] args)
        {
            #region Blue Cards
            List<Card> blueDeck = new List<Card>()
            {
                new Card(Model.TypeOfCard.Blue, "Whenever I think of rainbows _______", new List<string>()
                {
                     "Colors","Rain","Weather"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "My favorite thing to do after I eat is _______", new List<string>()
                {
                     "Food","Favorites"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "My scrum master bribes me with _______ to pay attention during standup", new List<string>()
                {
                     "Scrum","Bribes","Standup"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "Waiting for developers to finish code is like _______", new List<string>()
                {
                     "Bored","Developers","Jab"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "Being taken over or bought by Avanade is like _______", new List<string>()
                {
                     "Takover","Magic","Orange"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "When I hear Polish I think of _______", new List<string>()
                {
                     "Poland","Pronounciation","Relocation"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "When in doubt, Trump would _______", new List<string>()
                {
                     "Politics","Trump"
                }, String.Empty),
                new Card(Model.TypeOfCard.Blue, "I am Groot!", new List<string>()
                {
                    "I","Am","Groot"

                }, String.Empty)
            };
            #endregion

            #region White Cards
            List<Card> whiteDeck = new List<Card>()
            {
                new Card(Model.TypeOfCard.White, "That's what Batman would do.", new List<string>()
                {
                     "Batman","DC","Justice"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "The cheapest Vodka", new List<string>()
                {
                     "Food",
"Alcohol",
        "Poland"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "A bee drinking six cups of coffee simultaneously", new List<string>()
                {
                     "Animal",
        "Coffee",
        "Food"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "Getting blood from a stone", new List<string>()
                {
                     "Blood",
        "Nature"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "Planned DLC (Downloadable Content)", new List<string>()
                {
                     "Nerd",
        "Technology",
        "Games"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "Drinking from a fire hose", new List<string>()
                {
                        "Drinking",
        "Water",
        "Fire"
                }, String.Empty),
                new Card(Model.TypeOfCard.White,  "Have you tried turning it off and then back on again?", new List<string>()
                {
                     "IT Support",
        "Reboot",
        "Frozen",
        "Works on my machine"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "Superman", new List<string>()
                {
                      "DC",
        "Boy Scout",
        "Hero"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "Trump", new List<string>()
                {
                      "President",
        "Politics",
        "MAGA"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "I am Groot", new List<string>()
                {
                      "I",
        "Am",
        "Groot"
                }, String.Empty),
                new Card(Model.TypeOfCard.White, "My dog could do this", new List<string>()
                {
                      "Family",
        "Pets",
        "Dog"
                }, String.Empty)

            };

            #endregion

            #region Consultants
            List<Player> allConsultants = new List<Player>() {
                new Consultant(new List<string>() { "President", "DC", "Food" }, "Josh the GREAT!", new List<string>() { "Cool", "this is a comment", "howdy" } ),
                new Consultant(new List<string>() { "Technology", "Animals", "Food" }, "The GREAT Anne", new List<string>() { "I'm hungry!", "are you okay?", "what's up" })
            };
            #endregion

            #region Client
            Player client = new Client();
            // TODO: Finish the Client off! :-)
            #endregion
        }
    }
}
