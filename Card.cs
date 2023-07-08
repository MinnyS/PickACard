using System;
namespace PickACard
{
	public class Card
	{
		// Properties
		public readonly CardSuit Suit;
		public readonly CardRank Rank;

		// Constructor for specifying suit and rank
		public Card(CardSuit suit, CardRank rank)
		{
			Suit = suit;
			Rank = rank;
		}

		// Constructor for picking random Suit and Rank
		public Card()
		{
			Suit = CardPicker.RandomSuit();
			Rank = CardPicker.RandomRank();
		}

		// ToString method
        public override string ToString()
        {
			return Rank + " of " + Suit;
        }
    }
}

