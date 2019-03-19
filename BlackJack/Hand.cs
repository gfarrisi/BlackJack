using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        private List<Card> hand;
        public Hand()
        {
           hand = new List<Card>();
        }
        public void clear()
        {
            //remove all cards from hand
            foreach (Card c in hand)
            {
                hand.Remove(c);
            }
        }
        //remove specific card from hand
        public void removeCard(Card c)
        {
            // If the specified card is in the hand, it is removed.
            hand.Remove(c);
        }

        //adds a card to the hand list
        public void addCard(Card c)
        {           
            if (c != null)
            {
                hand.Add(c);
            }
        }
         // gets the number of cards in the hand
        public int getCardCount() 
        {        
            return hand.Count();
        }

         public Card getCard(int position) {
          // Get the card from the hand in given position, where positions
          // are numbered starting from 0.  If the specified position is
          // not the position number of a card in the hand, then null
          // is returned.
            if (position >= 0 && position < hand.size())
            {
                return (Card)hand.elementAt(position);
            }
            else
                return null;
            }
    }
}
