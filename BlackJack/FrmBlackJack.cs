using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FrmBlackJack : Form
    {
        Deck deck;
        BlackJackHand dealerHand;
        BlackJackHand playerHand;

        public FrmBlackJack()
        {
            InitializeComponent();
        }
        private void FrmBlackJack_Load(object sender, EventArgs e)
        {

            deck = new Deck(); ;                  // A deck of cards.  A new deck for each game.
            dealerHand = new BlackJackHand();   // The dealer's hand.
            playerHand = new BlackJackHand();     // The user's hand.

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter your name before you can play");
            }
            else
            {
                lblDealer.Visible = true;
                lblPlayer.Visible = true;
                btnHit.Visible = true;
                btnStay.Visible = true;

                lblPlayer.Text = txtName.Text;
                txtName.Enabled = false;
                btnPlay.Enabled = false;
                //get two cards for dealer

                //get two cards fro the player
                Boolean winner = playBlackJack();
            }



        }


        public Boolean playBlackJack()
        {
            // Let the user play one game of Blackjack.
            // Return true if the user wins, false if the user loses.

            pnlPlayerCards.Visible = true;
            pnlDealerCards.Visible = true;


            

            //  Shuffle the deck, then deal two cards to each player. 

            deck.shuffle(); 
            
            dealerHand.addCard(deck.dealCard());
            txtDealerCard1.Text = dealerHand.getCard(0).toString();
            
            dealerHand.addCard(deck.dealCard());
            txtDealerCard2.Text = dealerHand.getCard(1).toString();
                       
            playerHand.addCard(deck.dealCard());
            txtPlayerCard1.Text = playerHand.getCard(0).toString();
                       
            playerHand.addCard(deck.dealCard());
            txtPlayerCard2.Text = playerHand.getCard(1).toString();
            

            /* Check if one of the players has Blackjack (two cards totaling to 21).
               The player with Blackjack wins the game.  Dealer wins ties.
            */

            if (dealerHand.getBlackjackValue() == 21)
            {
                MessageBox.Show("Dealer has the " + dealerHand.getCard(0).toString()
                                         + " and the " + dealerHand.getCard(1).toString() + ".\n" +
                                         "Player has the " + playerHand.getCard(0).toString()
                                           + " and the " + playerHand.getCard(1).toString() + ".\n" +
                                           "Dealer has Blackjack.  In event of tie dealer wins.\n" +
                                           "Game Over. Thank you for Playing.");
                this.Close();
                return false;
            }

            if (playerHand.getBlackjackValue() == 21)
            {
                MessageBox.Show("Dealer has the " + dealerHand.getCard(0).toString()
                                         + " and the " + dealerHand.getCard(1).toString() + ".\n" +
                                         "Player has the " + playerHand.getCard(0).toString()
                                           + " and the " + playerHand.getCard(1).toString() + ".\n" +
                                           "You have Blackjack. Congrats!!\n" +
                                           "Game Over. Thank you for Playing!");
                this.Close();
                return true;
            }

            checkStatus();

            /// return true;

            /*  If neither player has Blackjack, play the game.  First the user 
                gets a chance to draw cards (i.e., to "Hit").  The while loop ends 
                when the user chooses to "Stand".  If the user goes over 21,
                the user loses immediately.
            */


            /* Display user's cards, and let user decide to Hit or Stand. */




            //do
            //{
            //    userAction = scan.next().charAt(0);

            //    if (userAction != 'H' && userAction != 'S')
            //        System.out.println("Please respond H or S:  ");
            //} while (userAction != 'H' && userAction != 'S');

            ///* If the user Hits, the user gets a card.  If the user Stands,
            //   the loop ends (and it's the dealer's turn to draw cards).
            //*/

            //if (userAction == 'S')
            //{
            //    // Loop ends; user is done taking cards.
            //    break;
            //}
            //else
            //{  // userAction is 'H'.  Give the user a card.  
            //   // If the user goes over 21, the user loses.
            //    Card newCard = deck.dealCard();
            //    userHand.addCard(newCard);
            //    System.out.println();
            //    System.out.println("User hits.");
            //    System.out.println("Your card is the " + newCard);
            //    System.out.println("Your total is now " + userHand.getBlackjackValue());
            //    if (userHand.getBlackjackValue() > 21)
            //    {
            //        System.out.println();
            //        System.out.println("You busted by going over 21.  You lose.");
            //        System.out.println("Dealer's other card was the "
            //                                           + dealerHand.getCard(1));




            return true;

            //    /* If we get to this point, the user has Stood with 21 or less.  Now, it's
            //       the dealer's chance to draw.  Dealer draws cards until the dealer's
            //       total is > 16.  If dealer goes over 21, the dealer loses.
            //    */

            //    System.out.println();
            //    System.out.println("User stands.");
            //    System.out.println("Dealer's cards are");
            //    System.out.println("    " + dealerHand.getCard(0));
            //    System.out.println("    " + dealerHand.getCard(1));
            //    while (dealerHand.getBlackjackValue() <= 16)
            //    {
            //        Card newCard = deck.dealCard();
            //        System.out.println("Dealer hits and gets the " + newCard);
            //        dealerHand.addCard(newCard);
            //        if (dealerHand.getBlackjackValue() > 21)
            //        {
            //            System.out.println();
            //            System.out.println("Dealer busted by going over 21.  You win.");
            //            return true;
            //        }
            //    }
            //    System.out.println("Dealer's total is " + dealerHand.getBlackjackValue());

            //    /* If we get to this point, both players have 21 or less.  We
            //       can determine the winner by comparing the values of their hands. */

            //    System.out.println();
            //    if (dealerHand.getBlackjackValue() == userHand.getBlackjackValue())
            //    {
            //        System.out.println("Dealer wins on a tie.  You lose.");
            //        return false;
            //    }
            //    else if (dealerHand.getBlackjackValue() > userHand.getBlackjackValue())
            //    {
            //        System.out.println("Dealer wins, " + dealerHand.getBlackjackValue()
            //                        + " points to " + userHand.getBlackjackValue() + ".");
            //        return false;
            //    }
            //    else
            //    {
            //        System.out.println("You win, " + userHand.getBlackjackValue()
            //                        + " points to " + dealerHand.getBlackjackValue() + ".");
            //        return true;
            //    }

        }  // end playBlackjack()


        public void checkStatus()
        {
            StringBuilder status = new StringBuilder("Your cards are:");
            for (int i = 0; i < playerHand.getCardCount(); i++)
            {
                status.Append("    " + playerHand.getCard(i).toString());
            }
            status.Append("\nYour total is " + playerHand.getBlackjackValue());
            status.Append("\nDealer's cards are: ");
            for (int i = 0; i < playerHand.getCardCount(); i++)
            {
                status.Append("    " + dealerHand.getCard(i).toString());
            }
            status.Append("\nDealer total is " + dealerHand.getBlackjackValue());
            status.Append("\nHit or Stand?");

            MessageBox.Show(status.ToString());
        }


        private void btnStay_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click_1(object sender, EventArgs e)
        {
            Card newCard = deck.dealCard();
            playerHand.addCard(newCard);
            txtPlayerCard3.Text = newCard.toString();

            StringBuilder hitMessage = new StringBuilder("You just just hit. " +
                "\nYour card is the " + newCard +
                "Your total is now " + playerHand.getBlackjackValue());
            if (playerHand.getBlackjackValue() > 21)
            {
                hitMessage.Append("You busted by going over 21.  You lose.");
                hitMessage.Append("Dealer's other card was the "
                                                   + dealerHand.getCard(1).toString());
            }

            MessageBox.Show(hitMessage.ToString());
        }
    }
}
    
