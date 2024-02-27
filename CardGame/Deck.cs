using System;

namespace CardGame
{
	public class Deck
	{
		private List<Card> cards = new List<Card>();

		// Create constructor
		public Deck()
		{
			foreach (Rank rank in Enum.GetValues(typeof(Rank)))
			{
				foreach (Suit suit in Enum.GetValues(typeof(Suit))) //convert to array
				{
					cards.Add(new Card(rank, suit));
				}
			}
		}

		// Properties

		public List<Card> GetCards { get { return cards; } }

		public bool Empty { get { return cards.Count == 0; } }

		//Methods
		public void Cut(int location)
		{
			if (location < 0 || location >= cards.Count)
			{
				throw new ArgumentException("Invalid location.");
			}

			List<Card> topHalf = cards.GetRange(0, location).ToList();
			List<Card> bottomHalf = cards.GetRange(location, cards.Count - location).ToList();


			ClearDeck();

			// reconstruct the deck 
			cards.AddRange(bottomHalf);
			cards.AddRange(topHalf);
		}

		public void Print()
		{
			if (cards.Count >= 1)
			{
				foreach (Card card in cards)
				{
					Console.WriteLine(card.Rank + " " + card.Suit);
				}
			}
			else
			{
				throw new ArgumentException("No cards in the deck.");
			}
		}

		public void ClearDeck()
		{
			cards.Clear();
		}

		public void Shuffle()
		{
			Random rng = new Random();
			int n = cards.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				Card value = cards[k];
				cards[k] = cards[n];
				cards[n] = value;
			}
		}

		public Card TakeTopCard()
		{
			if (cards.Count > 0)
			{
				Card topCard = cards[0];
				cards.RemoveAt(0); // Remove the top card from the list
				return topCard;
			}
			else
			{
				throw new InvalidOperationException("No card in the deck.");
			}
		}
	}

}