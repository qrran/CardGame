using CardGame;

namespace TestCardGame;


[TestClass]
public class CardTest
{
	//1. test card initialization
	[TestMethod]
	public void CardConstructor_Test()
	{
		Suit suit = Suit.Hearts;
		Rank rank = Rank.Ace;

		Card card = new Card(rank, suit);

		Assert.AreEqual(suit, card.Suit);
		Assert.AreEqual(rank, card.Rank);
		Assert.IsFalse(card.FaceUp);

	}

	//faceUp
	[TestMethod]
	public void FlipOver_Test()
	{
		Suit suit = Suit.Hearts;
		Rank rank = Rank.Ace;

		Card card = new Card(rank, suit);

		Assert.IsFalse(card.FaceUp);

		card.FlipOver();

		Assert.IsTrue(card.FaceUp);

	}

}
