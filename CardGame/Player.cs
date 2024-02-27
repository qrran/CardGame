using System;
using System.Collections.Generic;
using System.Linq;
using CardGame;

namespace CardGame
{
	public class Player
	{
		private List<Card> cards = new List<Card>();

		public int ID { get; }

		public Player(int id)
		{
			ID = id;
		}

		public List<(Rank, Suit)> GetCards()
		{
			List<(Rank, Suit)> cardInfoList = new List<(Rank, Suit)>();

			foreach (Card card in cards)
			{
				cardInfoList.Add((card.Rank, card.Suit));
			}

			return cardInfoList;
		}

		public void AddCard(Card card)
		{
			cards.Add(card);
			SortCardsByRank();
		}

		public void RemoveCard(int index)
		{
			if (index >= 0 && index < cards.Count)
			{
				cards.RemoveAt(index);
			}
			else
			{
				throw new ArgumentException("Invalid card location.");
			}
		}

		public int NumCards()
		{
			return cards.Count;
		}

		// sort the card by rank
		public void SortCardsByRank()
		{
			cards = cards.OrderBy(c => c.Rank).ToList();
		}
	}
}
