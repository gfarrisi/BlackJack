using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BlackJack
{
    class Deck
    {
        private Card[] deck; //array that holds the cards of the deck
        private int cardsUsed; //counter for cards dealt from the deck

        public Deck()
        {
            deck = new Card[52];

            int cardIndex = 0; // the index for card in the array
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck[cardIndex] = new Card(suit, value);
                    cardIndex++; 
                }
            }
            cardsUsed = 0;
        }

        //not sure i will need..
        //maybe to start game..
        public void shuffle()
        {
            //shufffles all card (including those used) ino a random order
            //for (int i = 51; i > 0; i--)
            //{
            //    Random rnd = new Random();
            //    int rand = rnd.Next(52);

            //    //swapping the given index value with a random index value
            //    Card temp = deck[i];
            //    deck[i] = deck[rand];
            //    deck[rand] = temp;
            //    string random = rand.ToString();
            //}
            //for (int i = 0; i < deck.Length; i++)
            //{
                RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
                deck = deck.OrderBy(x => GetNextInt32(rnd)).ToArray();
                //int rand = rnd.Next(52);
                // int rand = Random.Range(i, deck.Length);
                //swapping the given index value with a random index value
                //Card temp = deck[i  ];
                //deck[i] = deck[rand];
                //deck[rand] = temp;
                //MessageBox.Show(rand.ToString());
            //}
           


            //resetting the cards used back to zero because it refreshes the usage
            cardsUsed = 0;

            
            StringBuilder cards = new StringBuilder("");
            foreach (Card c in deck)
            {
                cards.Append(c.toString() + "\n ");
            }
          //  MessageBox.Show(cards.ToString());
        }
        static int GetNextInt32(RNGCryptoServiceProvider rnd)
        {
            byte[] randomInt = new byte[4];
            rnd.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }
        public int cardsLeft()
        {
            //cards left after card gets used
            return 52 - cardsUsed;
        }

        //returns/deals one card from the deck array
        public Card dealCard()
        {
            //shuffles cards if all are used
            if (cardsUsed == 52)
                shuffle();
            //increases cards used
            cardsUsed++;
            //returns the card used - contains suit and value
            return deck[cardsUsed - 1];
        }
    }
}
