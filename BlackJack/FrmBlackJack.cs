using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FrmBlackJack : Form
    {
        Deck deck;
        BlackJackHand dealerHand;
        BlackJackHand playerHand;

        private Boolean dealerWins = false;
        private Boolean playerWins = false;

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

                playBlackJack();
            }



        }


        public void playBlackJack()
        {
            // Let the user play one game of Blackjack.
            // Return true if the user wins, false if the user loses.

            pnlPlayerCards.Visible = true;
            pnlDealerCards.Visible = true;

                       

            //  Shuffle the deck, then deal two cards to each player. 

            deck.shuffle(); 
            
            dealerHand.addCard(deck.dealCard());
            txtDealerCard1.Text = dealerHand.getCard(0).toString();

            //generatePicture card
            //pnlDealer.addPicture(dealerHand.getCard(0).imageString());
         
            
            dealerHand.addCard(deck.dealCard());
            txtDealerCard2.Text = "Hidden";
               
                       
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
                playerWins =  false;
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
                dealerWins = false;
            }

            StringBuilder status = new StringBuilder("Your cards are:");
            for (int i = 0; i < playerHand.getCardCount(); i++)
            {
                status.Append("    " + playerHand.getCard(i).toString());
            }
            status.Append("\nYour total is " + playerHand.getBlackjackValue());
            status.Append("\nDealer's is showing: ");
            status.Append(dealerHand.getCard(0).toString());
            status.Append("\nHit or Stand?");

            MessageBox.Show(status.ToString());
                                
            

        }  // end playBlackjack()



        private void btnStay_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("You decided to stay.\nDealer will now show all cards.");
            //dealer turns over other cards
            txtDealerCard2.Text = dealerHand.getCard(1).toString();
            while (dealerHand.getBlackjackValue() < 17)
            {
                Card newCard = deck.dealCard();
                //  StringBuilder dealerTurn = new StringBuilder();
                MessageBox.Show("Dealer hits and gets the " + newCard.toString());
                dealerHand.addCard(newCard);
                if (dealerHand.getBlackjackValue() > 21)
                {
                    MessageBox.Show("Dealer busted by going over 21.  You win.");
                   
                }
            }
            MessageBox.Show("Dealer's total is " + dealerHand.getBlackjackValue());
            if (dealerHand.getBlackjackValue() == playerHand.getBlackjackValue())
            {
                MessageBox.Show("Dealer wins on a tie.  You lose.");
                dealerWins = true;
                this.Close();
            }
            else if (dealerHand.getBlackjackValue() > playerHand.getBlackjackValue())
            {
                MessageBox.Show("Dealer wins, " + dealerHand.getBlackjackValue()
                                + " points to " + playerHand.getBlackjackValue() + ".");
                dealerWins = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You win, " + playerHand.getBlackjackValue()
                                + " points to " + dealerHand.getBlackjackValue() + ".");
                playerWins = true;
                this.Close();
            }
        }

        private void btnHit_Click_1(object sender, EventArgs e)
        {
            Card newCard = deck.dealCard();
            playerHand.addCard(newCard);
            txtPlayerCard3.Text = newCard.toString();


            StringBuilder hitMessage = new StringBuilder("You just just hit. " +
                "\nYour new card is " + newCard.toString() +
                "\nYour total is now " + playerHand.getBlackjackValue());
            if (playerHand.getBlackjackValue() > 21)
            {
                hitMessage.Append("\nYou busted by going over 21. You lose. \n");
                hitMessage.Append("Dealer's other card was the "
                                                   + dealerHand.getCard(1).toString());
                dealerWins = true;
                this.Close();
            }
            if(playerHand.getBlackjackValue() == 21)
            {
                MessageBox.Show("Congrats you will!");
                playerWins = true;
            }
            MessageBox.Show(hitMessage.ToString());
        }
    }
}
    
