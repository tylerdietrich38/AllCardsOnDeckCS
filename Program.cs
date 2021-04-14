using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Card Shuffling");

            Console.WriteLine(" ");

            var cards = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };

            var deck = new List<string>();


            for (var index = 0; index < suits.Count; index++)
            {
                for (var numbersIndex = 0; numbersIndex < cards.Count; numbersIndex++)
                {
                    var fullNumber = ($"{cards[numbersIndex]} of {suits[index]} ");
                    deck.Add(fullNumber);
                }
            }
            foreach (var num in deck)
            {
                Console.WriteLine($"{num}");
            }

            Console.WriteLine("------------------------------------------------");

            var numberOfCards = deck.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);

                var rightCard = deck[rightIndex];

                deck[rightIndex] = deck[leftIndex];

                deck[leftIndex] = rightCard;
            }

            foreach (var num in deck)
            {
                Console.WriteLine($"{num}");
            }


        }
    }
}
