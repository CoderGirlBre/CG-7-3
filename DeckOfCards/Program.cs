using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("(Standard Deck) Card: ");

            //New deck object.
            Deck deck = new Deck();

            //Draws a card from the deck.
            var card = deck.Draw();

            //Prints the full name of the card that was drawn
            //from the deck to the console.
            Console.WriteLine(card.GetFullName());
            Console.ReadLine();
        }
    }
}
