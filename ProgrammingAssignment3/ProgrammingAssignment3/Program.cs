using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Blackjack game
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // game variables
            Deck myDeck = new Deck();
            BlackjackHand playerHand = new BlackjackHand("Player");
            BlackjackHand dealerHand = new BlackjackHand("Dealer");
            BlackjackHand[] playerHands = { playerHand, dealerHand };

            // welcome message
            Console.WriteLine("Get ready to play Blackjack");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            // start dealing
            myDeck.Shuffle();
            foreach (BlackjackHand hand in playerHands)
            {
                for (int i = 0; i < 2; i++)
                {
                    hand.AddCard(myDeck.TakeTopCard());
                }
            }

            // display cards
            playerHand.ShowAllCards();
            dealerHand.ShowFirstCard();
            showHands(playerHands, false);

            // player option
            playerHand.HitOrNot(myDeck);

            // show all cards
            dealerHand.ShowAllCards();
            showHands(playerHands, true);
        }

        /// <summary>
        /// displays hands with boolean option to show the score
        /// takes a BlackjackHand[] and Boolean and displays the hand
        /// </summary>
        /// <param name="playerHands"></param>
        /// <param name="showScore"></param>
        static void showHands(BlackjackHand[] playerHands, Boolean showScore)
        {
            // display hands
            foreach (BlackjackHand hand in playerHands)
            {
                Console.WriteLine();
                hand.Print();
            }

            // optional score display
            if (showScore)
            {
                Console.WriteLine();
                Console.WriteLine("Scores");
                Console.WriteLine("Player: " + playerHands[0].Score);
                Console.WriteLine("Dealer: " + playerHands[1].Score);
            }
        }
    }
}
