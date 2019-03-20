using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BlackJackHand: Hand
    {
        public BlackJackHand()
        { 
        }
        public int getBlackjackValue()
        {
            // Returns the value of this hand for the
            // game of Blackjack.
            int handValue = 0;      // The value computed for the hand.
            Boolean containsAce = false;  // This will be set to true if the
                          //   hand contains an ace.
            int cards = base.getCardCount();    // Number of cards in the hand.
            
            for (int i = 0; i < cards; i++)
            {
                // Add the value of the i-th card in the hand.
                Card card;    // The i-th card;     
                int cardVal;  // The blackjack value of the i-th card.
                card = base.getCard(i);
                cardVal = card.getValue();  // The normal value, 1 to 13.
                if (cardVal > 10)
                {
                    cardVal = 10;   // For a Jack, Queen, or King.
                }
                if (cardVal == 1)
                {
                    containsAce = true;     // There is at least one ace.
                }
                handValue += cardVal;
            }

            // Now, val is the value of the hand, counting any ace as 1.
            // If there is an ace, and if changing its value from 1 to 
            // 11 would leave the score less than or equal to 21,
            // then do so by adding the extra 10 points to val. 

            if (containsAce == true && handValue + 10 <= 21)
                handValue = handValue + 10;

            return handValue;

        }  

    }
}
