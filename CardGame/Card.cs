using System;

namespace CardGame
{

	public class Card
	{
		Suit suit;
		Rank rank;
		bool faceUp;


		// Properties
		public Suit Suit { get { return suit; } }

		public Rank Rank { get { return rank; } }

		public bool FaceUp { get { return faceUp; } }

		// Constructor
		public Card(Rank rank, Suit suit)
		{
			this.suit = suit;
			this.rank = rank;
			faceUp = false;
		}

		// Method
		public void FlipOver()
		{
			faceUp = true;
		}

	}

}