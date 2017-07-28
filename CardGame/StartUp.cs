using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
   public class StartUp
    {
        public static void Main()
        {
            string playerOneName = Console.ReadLine();
            string playerTwoName = Console.ReadLine();
            Player playerOne = new Player(playerOneName);
            Player playerTwo = new Player(playerTwoName);
            string[] cardSuits = Enum.GetNames(typeof(Suit));
            string[] cardRanks = Enum.GetNames(typeof(Rank));
            List<Card> deck = new List<Card>();
            List<string>cardNames = new List<string>();
            List<string> removed = new List<string>();
            foreach (var suit in cardSuits)
            {
                foreach (var rank in cardRanks)
                {
                    Card card = new Card(rank, suit);
                    deck.Add(card);
                    cardNames.Add(card.ToString());
                }
            }
            
            while (playerOne.Hand.Count!=5)
            {
                string card = Console.ReadLine();
                if (cardNames.Contains(card)&&cardNames.Contains(card))
                {
                    string[] cardTokens = card.Split(new []{" ","of"},StringSplitOptions.RemoveEmptyEntries);
                    string cardRank = cardTokens[0];
                    string cardSuit = cardTokens[1];
                    Card currentCard = new Card(cardRank, cardSuit);
                    playerOne.Hand.Add(currentCard);
                    removed.Add(card);
                    cardNames.Remove(card);
                }
                else
                {
                    if (!removed.Contains(card))
                    {
                        Console.WriteLine("No such card exists.");
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    
                }
                
            }

            while (playerTwo.Hand.Count != 5)
            {
                string card = Console.ReadLine();
                if (cardNames.Contains(card))
                {
                    string[] cardTokens = card.Split(new[] { " ", "of" }, StringSplitOptions.RemoveEmptyEntries);
                    string cardRank = cardTokens[0];
                    string cardSuit = cardTokens[1];
                    Card currentCard = new Card(cardRank, cardSuit);
                    playerTwo.Hand.Add(currentCard);
                    removed.Add(card);
                    cardNames.Remove(card);
                }
                else
                {
                    if (!removed.Contains(card))
                    {
                        Console.WriteLine("No such card exists.");
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
            }
            int firstPlayerResult = playerOne.Hand.Max(c => c.GetCardPower());
            int seconPlayerResult = playerTwo.Hand.Max(c => c.GetCardPower());
           
            if (firstPlayerResult > seconPlayerResult)
            {
                Console.WriteLine($"{playerOne.Name} wins with {playerOne.Hand.Max().Rank} of {playerOne.Hand.Max().Suit}.");
            }
            else
            {
                Console.WriteLine($"{playerTwo.Name} wins with {playerTwo.Hand.Max().Rank} of {playerTwo.Hand.Max().Suit}.");
            }
        }
    }
}
