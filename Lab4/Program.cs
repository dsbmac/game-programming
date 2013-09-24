using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{   
    /// <summary>
    /// Lab 4 deck program
    /// </summary>
    class Program
    {
        /// <summary>
        /// The standard Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // create a new deck and print the contents of the deck
            Deck deck = new Deck();
            deck.Print();

            // shuffle the deck and print the contents of the deck
            Console.WriteLine("\nShuffling Deck...");
            deck.Shuffle();
            deck.Print();

            // take the top card from the deck and print the card rank and suit
            Console.WriteLine("\nTaking cards from the deck...");
            Card card1 = deck.TakeTopCard();
            Console.WriteLine("Card 1: " + card1.Rank + " " + card1.Suit);

            // take the top card from the deck and print the card rank and suit
            Card card2 = deck.TakeTopCard();
            Console.WriteLine("Card 2: " + card2.Rank + " " + card2.Suit);

        }
    }
}
