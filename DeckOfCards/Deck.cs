using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck
    {
        private Random _random; //Random variable created for later use.
        public Card[] Cards { get; set; } //An array of cards created. (Property array)
        
        public Deck()
        {
            //Variable set to new random to draw a card later.
            _random = new Random();

            //Creating a standard deck of cards.
            Cards = new Card[52]; //Object

            //Counter started as the deck is filled.
            int counter = 0;

            //Looping through face values.
            for (int i = 2; i <= 14; i++)
            {
                //Assigning face values.
                string faceValue;
                if (i < 11) faceValue = i.ToString();
                else if (i == 11) faceValue = "Jack";
                else if (i == 12) faceValue = "Queen";
                else if (i == 13) faceValue = "King";
                else faceValue = "Ace";

                //Looping through suits.
                for (int j = 1; j <= 4; j++)
                {
                    //Assigning suits.
                    string suit;
                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "Spades";
                    else suit = "Clubs";

                    //Counter used to say one card is made up of 
                    //a face value and suit.
                    Cards[counter] = new Card //object
                    {
                        FaceValue = faceValue,
                        Suit = suit

                    };
                    counter++;
                }
            }
        }
        //New method created that draws a random card 
        //and prints it.
        public Card Draw()
        {
            var number = _random.Next(Cards.Length);
            return Cards[number];
        }
    }
}





