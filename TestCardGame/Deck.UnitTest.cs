using CardGame;
namespace TestCardGame;

[TestClass]
public class DeckTest
{
	//1. test deck initialization
	[TestMethod]
	public void DeckConstructor_Test()
	{
		Deck deck = new Deck();

		Assert.AreEqual(52, deck.GetCards.Count);
		Assert.IsFalse(deck.Empty);

		deck.ClearDeck();
		Assert.IsTrue(deck.Empty);
	}
	//2. test Cut()
	[TestMethod]
	public void CutInvalid_Test()
	{
		Deck deck = new Deck();

		Assert.ThrowsException<ArgumentException>(() => deck.Cut(53));
	}

	//Cut()
	[TestMethod]
	public void CutValid_Test()
	{
		Deck deck = new Deck();
		List<Card> originalCards = deck.GetCards;


		deck.Cut(1);
		List<Card> cardsAfterCut = deck.GetCards;

		//Use the same deck to test cut result!!!

		foreach (Card card in originalCards)
		{
			Assert.IsTrue(cardsAfterCut.Contains(card));
		}

	}

	//Shuffle()
	[TestMethod]
	public void Shuffle_Test()
	{
		Deck deck = new Deck();
		List<Card> originalOrder = deck.GetCards;

		deck.Shuffle();
		List<Card> shuffledOrder = deck.GetCards;

		foreach (Card card in originalOrder)
		{
			Assert.IsTrue(shuffledOrder.Contains(card));
		}
	}
	//TakeTopCard()
	[TestMethod]
	public void TakeTopCard_Test()
	{
		Deck deck = new Deck();
		Card topcard = deck.TakeTopCard();

		string expectedOutput = "Ace Clubs";
		string actualOutput = topcard.Rank + " " + topcard.Suit;

		Assert.AreEqual(expectedOutput, actualOutput);
		Assert.IsTrue(deck.GetCards.Count == 51);
	}
}

