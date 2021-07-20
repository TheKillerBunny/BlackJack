using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deck, Hand, Card, Dealer and Player

            var cards = CreateCards();
            var deck = CreateShuffledDeck(cards);

            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
        }

        static List<Card> CreateCards()
        {

            var suits = new List<string> { "♣", "♥", "♦", "♣" };
            var ranks = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            var cards = new List<Card> { };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    var card = new Card();
                    card.Rank = rank;
                    card.Suit = suit;

                    cards.Add(card);
                }
            }
            return cards;
        }

        static Stack<Card> CreateShuffledDeck(List<Card> cards)
        {
            var rng = new Random();
            var deck = new Stack<Card>();


            //------- do all this till the original list is empty
                //------ generate a random number that's in the index's of the cards
                //------ get the card at that number
                //------ remove the card from the original list at that index
                //------ push the card onto the stack

            while(cards.Count > 0)
            {
                int RandomIndex = rng.Next(0, cards.Count);
                var card = cards[RandomIndex];
                cards.RemoveAt(RandomIndex);
                deck.Push(card);
            }
            return deck;
        }
    }
}
