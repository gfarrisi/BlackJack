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
    }
}
