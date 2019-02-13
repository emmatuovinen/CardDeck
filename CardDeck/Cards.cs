using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Cards
    {
        // Creating an array of all cards in a deck
        string[] Deck = new string[] { "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH", "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS" };

        // Creating an instance of a pseudo-random number generator
        Random random = new Random();

        public void Shuffle()
        {
            // looping through the array of cards 
            for (int i = Deck.Length; i > 1;)
            {
                int randomCardIndex = random.Next(i--); //auxiliary variable for a random index of a card
                string card = Deck[i];                  //here the variable called card is assigned with the next value in line of the array
                Deck[i] = Deck[randomCardIndex];        //and then that card's index is changed into the random index
                Deck[randomCardIndex] = card;           //which is then looked up from the array and card gets reassigned

            }

            // and lastly, here the deck is printed out on the console in that particular random order
            foreach (var card in Deck)
            {
                Console.Write(card + ", ");
            }
        }
    }
}
