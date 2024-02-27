namespace CardGame;

class Program
{
	static void Main(string[] args)
	{
		//Player player1 = new Player(1);
		//Console.WriteLine(player1.NumCards());

		Deck card2 = new Deck();
		card2.Print();
		card2.Cut(4);
		Console.WriteLine("------------------------------\nAfter cut: ");
		card2.Print();
	}
}