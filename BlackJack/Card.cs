using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is a comment for testing github commit

    //nathan was here
namespace BlackJack
{
    //second test comment
    // represents one of the 52 cards in a deck of playing cards
    // each card has a suit and a value

    class Card
    {
        private const int SPADES = 0, HEARTS = 1, DIAMONDS = 2, CLUBS = 3;
        private const int ACE = 1, JACK = 11, QUEEN = 12, KING = 13;

        private int suit; //spades, hearts, diamond, or clubs
        private int value; //value from 1 to 13

        public Card(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public int getSuit()
        {
            // Return the int that codes for this card's suit.
            return suit;
        }

        public int getValue()
        {
            // Return the int that codes for this card's value.
            return value;
        }

        public String getSuitAsString()
        {
            //Return a string representing the card's suit
            switch (suit)
            {
                case SPADES:
                    return "Spades";
                case HEARTS:
                    return "Hearts";
                case DIAMONDS:
                    return "Diamonds";
                case CLUBS:
                    return "Clubs";
                default:
                    return "0";
            }
        }

        public String getValueAsString()
        {
            // Return a string representing the card's value.            
            switch (value)
            {
                case 1: return "Ace";
                case 2: return "2";
                case 3: return "3";
                case 4: return "4";
                case 5: return "5";
                case 6: return "6";
                case 7: return "7";
                case 8: return "8";
                case 9: return "9";
                case 10: return "10";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return "0";
            }
        }
        //not sure if i'll need..
        public String toString()
        {
            // Return a String representation of this card, such as
            // "10 of Hearts" or "Queen of Spades".
            return getValueAsString() + " of " + getSuitAsString();
        }

        public String imageString()
        {
            return "suit" + getSuit().ToString() + "value" + getValue().ToString();
        }

    }
}
