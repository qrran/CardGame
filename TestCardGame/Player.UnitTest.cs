namespace TestCardGame;
using CardGame;

[TestClass]
public class PlayerTest
{
	//Test cards on hand
	[TestMethod]
	public void Player_Cards_on_hand_Test()
	{
		Deck deck = new Deck();

		Player player1 = new Player(1);

		Card dealcard = deck.TakeTopCard();
		player1.AddCard(dealcard);

		List<(Rank, Suit)> cardsOnHand = player1.GetCards();

		Card expectedCard = new Card(Rank.Ace, Suit.Clubs);

		Card actualCard = new Card(cardsOnHand[0].Item1, cardsOnHand[0].Item2);

		Assert.AreEqual(expectedCard.Rank, actualCard.Rank);
		Assert.AreEqual(expectedCard.Suit, actualCard.Suit);
	}
	//test add card to player's hand
	[TestMethod]
	public void AddCard_on_hand_Test()
	{
		Deck deck = new Deck();

		Player player1 = new Player(1);

		Card dealcard = deck.TakeTopCard();
		player1.AddCard(dealcard);

		Assert.IsTrue(player1.GetCards().Count == 1);
	}
	//test remove card from player's hand
	[TestMethod]
	public void RemoveCard_on_hand_Test()
	{
		Deck deck = new Deck();
		Player player1 = new Player(1);

		Card dealcard = deck.TakeTopCard();
		player1.AddCard(dealcard);
		Card dealcard2 = deck.TakeTopCard();
		player1.AddCard(dealcard2);
		Assert.IsTrue(player1.GetCards().Count == 2);

		player1.RemoveCard(0);

		Assert.IsTrue(player1.GetCards().Count == 1);
	}

	[TestMethod]
	public void RemoveCard_on_hand_Invalid_Test()
	{
		Deck deck = new Deck();
		Player player1 = new Player(1);

		Card dealcard = deck.TakeTopCard();
		player1.AddCard(dealcard);
		Card dealcard2 = deck.TakeTopCard();
		player1.AddCard(dealcard2);
		Assert.IsTrue(player1.GetCards().Count == 2);

		Assert.ThrowsException<ArgumentException>(() => player1.RemoveCard(2));
	}
	//test if number of card on hand is corrected
	[TestMethod]
	public void NumCards_Test()
	{
		Deck deck = new Deck();
		Player player1 = new Player(1);

		Card dealcard = deck.TakeTopCard();
		player1.AddCard(dealcard);

		Assert.IsTrue(player1.GetCards().Count == 1);
	}

}
