using System;
namespace PickACard
{
	public static class CardPicker
	{
		// Random number generator field.
		private static Random random = new Random(); // Initialize random number generator.
		
		// Method to return a specific number of randomly selected cards.
		public static Card[] PickSomeCards(int numberOfCards)
		{
			// Declare and initialize array for randomly selected cards.
			Card[] pickedCards = new Card[numberOfCards];

			// Add randomly selected cards to array.
			for(int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = new Card(); // Pick a card and add it to the array.
			}
			
			// Return array of randomly selected cards.
			return pickedCards;
		}

		// Method to return a randomly selected rank.
		public static CardRank RandomRank()
		{
			int randomNumber = random.Next(1, 14); // Generate random number.
			CardRank rank = (CardRank)randomNumber; // Identify rank associated with number.
			return rank; // Return rank.
		}

		// Method to return a randomly selected suit.
		public static CardSuit RandomSuit()
		{
			int randomNumber = random.Next(1, 5); // Generate random number.
			CardSuit suit = (CardSuit) randomNumber; // Identify suit associated with number.
			return suit; // Return suit.
		}
	}
}

