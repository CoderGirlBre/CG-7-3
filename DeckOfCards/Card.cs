using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    //New public class created to make accessible throughout the whole code.
    public class Card
    {
        //The card's properties.
        public string FaceValue { get; set; }
        public string Suit { get; set; }

        //New method created to print the full card name.
        public string GetFullName()
        {
            return $"{FaceValue} of {Suit}";
        }
    }
}
