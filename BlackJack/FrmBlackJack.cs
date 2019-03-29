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
        Player player;

        public Boolean dealerWins;
        public Boolean playerWins;

        int money = 20;          // Amount of money the user has.
        int bet;

        public FrmBlackJack()
        {
            InitializeComponent();
        }
        private void FrmBlackJack_Load(object sender, EventArgs e)
        {

            deck = new Deck(); ;                  // A deck of cards.  A new deck for each game.
            dealerHand = new BlackJackHand();   // The dealer's hand.
            playerHand = new BlackJackHand();     // The user's hand.
            playerWins = false;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter your name before you can play");
            }
            else
            {
                player = new Player(txtName.Text);

               

                btnClose.Visible = true;
                lblMoney.Visible = true;
                txtBet.Visible = true;
                btnBet.Visible = true;

                lblPlayer.Text = txtName.Text;
                txtName.Enabled = false;
                btnPlay.Enabled = false;

                player.setMoney(Convert.ToInt32(money));
                playRound();
            }



        }
        public void playRound()
        {
            // Amount user bets on a game.
            //Boolean userWins;   // Did the user win the game?

            // User starts with $20.
            btnHit.Enabled = true;
            btnStay.Enabled = true;
            btnPlayAgain.Enabled = false;
          

            lblMoney.Text = ("Your Money: " + player.getMoney().ToString());

            MessageBox.Show("You have " + player.getMoney().ToString() + " dollars.");
                
            MessageBox.Show("Please enter how many dollars you want to bet?  (Enter 0 to end.)");

          //  MessageBox.Show("You leave with $" + money.ToString() + '.');

        }

        public void playBlackJack()
        {
            // Let the user play one game of Blackjack.
            // Return true if the user wins, false if the user loses.

            //may need to clear panels here

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
                btnHit.Enabled = false;
                btnStay.Enabled = false;
                btnPlayAgain.Enabled = true;
                updateMoney();
                //playerWins =  false;
            }

            else if (playerHand.getBlackjackValue() == 21)
            {
                MessageBox.Show("Dealer has the " + dealerHand.getCard(0).toString()
                                         + " and the " + dealerHand.getCard(1).toString() + ".\n" +
                                         "Player has the " + playerHand.getCard(0).toString()
                                           + " and the " + playerHand.getCard(1).toString() + ".\n" +
                                           "You have Blackjack. Congrats!!\n" +
                                           "Game Over. Thank you for Playing!");
                player.setWinner(true);
                btnHit.Enabled = false;
                btnStay.Enabled = false;
                btnPlayAgain.Enabled = true;
                updateMoney();
                //dealerWins = false;
            }
            else
            {                
                StringBuilder status = new StringBuilder("Your cards are:");
                for (int i = 0; i < playerHand.getCardCount(); i++)
                {
                    status.Append("\n" + playerHand.getCard(i).toString());
                }
                status.Append("\nYour total is " + playerHand.getBlackjackValue());
                status.Append("\nDealer's is showing: ");
                status.Append(dealerHand.getCard(0).toString());
                status.Append("\nHit or Stand?");

                MessageBox.Show(status.ToString());

            }
                      
            

        }  // end playBlackjack()



        private void btnStay_Click(object sender, EventArgs e)
        {
            Boolean go = true;
            while (go)
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
                        player.setWinner(true);
                        go = false;
                        updateMoney();
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                        btnPlayAgain.Enabled = true;

                    }
                   
                }
                if (go == true)
                {
                    MessageBox.Show("Dealer's total is " + dealerHand.getBlackjackValue());
                    if (dealerHand.getBlackjackValue() == playerHand.getBlackjackValue())
                    {
                        MessageBox.Show("Dealer wins on a tie.  You lose.");
                        go = false;
                        updateMoney();
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                        btnPlayAgain.Enabled = true;
                        break;

                    }
                    if (dealerHand.getBlackjackValue() > playerHand.getBlackjackValue())
                    {
                        MessageBox.Show("Dealer wins, " + dealerHand.getBlackjackValue()
                                        + " points to " + playerHand.getBlackjackValue() + ".");
                        go = false;
                        updateMoney();
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                        btnPlayAgain.Enabled = true;
                        break;

                    }

                    else
                    {
                        MessageBox.Show("You win, " + playerHand.getBlackjackValue()
                                        + " points to " + dealerHand.getBlackjackValue() + ".");
                        player.setWinner(true);
                        updateMoney();
                        go = false;
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                        btnPlayAgain.Enabled = true;
                        break;

                    }

                }
            }
            MessageBox.Show("Click Play again button to play again.");

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
                // dealerWins = true;
                //btnHit.Enabled = false;
                //btnStay.e
                updateMoney();
                btnHit.Enabled = false;
                btnStay.Enabled = false;
                btnPlayAgain.Enabled = true;

            }
            MessageBox.Show(hitMessage.ToString());
            if (playerHand.getBlackjackValue() == 21)
            {
                MessageBox.Show("Congrats you win!");
                player.setWinner(true);
                updateMoney();
                btnHit.Enabled = false;
                btnStay.Enabled = false;
                btnPlayAgain.Enabled = true;
            }
            
        }

        public void updateMoney()
        {
            if (player.isWinner())
            {
                player.setMoney(player.getMoney() + bet);
            }
            else
            {
                player.setMoney(player.getMoney() - bet);
            }

            if (player.getMoney() == 0)
            {
                MessageBox.Show("Looks like you've are out of money!");
                MessageBox.Show("Now closing");
                this.Close();
            }

            lblMoney.Text = ("Your Money: " + player.getMoney().ToString());
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnBet.Enabled = true;
            txtBet.Enabled = true;

            dealerHand.clear();
            playerHand.clear();

            player.setWinner(false);
            
            playRound();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            btnBet.Enabled = false;
            txtBet.Enabled = false;
            lblDealer.Visible = true;
            lblPlayer.Visible = true;
            btnHit.Visible = true;
            btnStay.Visible = true;
            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = false;

            try
            {
                bet = Convert.ToInt32(txtBet.Text);
                if (bet < 0 || bet > player.getMoney())
                {
                    MessageBox.Show("Your answer must be between 0 and " + player.getMoney() + '.');
                }
                else if (bet == 0)
                {
                    MessageBox.Show("You must bet something to play!");
                }
                else
                {
                    playBlackJack();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing. You left with " + player.getMoney().ToString() + " dollars.");
            Application.Exit();
        }
    }
}
    
