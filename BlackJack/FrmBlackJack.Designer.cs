namespace BlackJack
{
    partial class FrmBlackJack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.pnlDealerCards = new System.Windows.Forms.Panel();
            this.txtDealerCard3 = new System.Windows.Forms.TextBox();
            this.txtDealerCard2 = new System.Windows.Forms.TextBox();
            this.txtDealerCard1 = new System.Windows.Forms.TextBox();
            this.dealerCard1 = new System.Windows.Forms.Label();
            this.pnlPlayerCards = new System.Windows.Forms.Panel();
            this.txtPlayerCard3 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard2 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard1 = new System.Windows.Forms.TextBox();
            this.pnlDealerCards.SuspendLayout();
            this.pnlPlayerCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(151, 19);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(390, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of BlackJack!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(193, 71);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Khaki;
            this.btnPlay.Location = new System.Drawing.Point(455, 69);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(41, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Bahnschrift", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(152, 135);
            this.lblDealer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(66, 23);
            this.lblDealer.TabIndex = 4;
            this.lblDealer.Text = "Dealer";
            this.lblDealer.Visible = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Bahnschrift", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(457, 135);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(65, 23);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.Visible = false;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Gold;
            this.btnHit.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(89, 362);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(246, 30);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.Gold;
            this.btnStay.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(349, 362);
            this.btnStay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(246, 30);
            this.btnStay.TabIndex = 8;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Visible = false;
            // 
            // pnlDealerCards
            // 
            this.pnlDealerCards.Controls.Add(this.txtDealerCard3);
            this.pnlDealerCards.Controls.Add(this.txtDealerCard2);
            this.pnlDealerCards.Controls.Add(this.txtDealerCard1);
            this.pnlDealerCards.Controls.Add(this.dealerCard1);
            this.pnlDealerCards.Location = new System.Drawing.Point(51, 159);
            this.pnlDealerCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDealerCards.Name = "pnlDealerCards";
            this.pnlDealerCards.Size = new System.Drawing.Size(263, 173);
            this.pnlDealerCards.TabIndex = 9;
            // 
            // txtDealerCard3
            // 
            this.txtDealerCard3.Location = new System.Drawing.Point(180, 18);
            this.txtDealerCard3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDealerCard3.Name = "txtDealerCard3";
            this.txtDealerCard3.Size = new System.Drawing.Size(63, 20);
            this.txtDealerCard3.TabIndex = 3;
            // 
            // txtDealerCard2
            // 
            this.txtDealerCard2.Location = new System.Drawing.Point(96, 18);
            this.txtDealerCard2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDealerCard2.Name = "txtDealerCard2";
            this.txtDealerCard2.Size = new System.Drawing.Size(63, 20);
            this.txtDealerCard2.TabIndex = 2;
            // 
            // txtDealerCard1
            // 
            this.txtDealerCard1.Location = new System.Drawing.Point(13, 18);
            this.txtDealerCard1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDealerCard1.Name = "txtDealerCard1";
            this.txtDealerCard1.Size = new System.Drawing.Size(63, 20);
            this.txtDealerCard1.TabIndex = 1;
            // 
            // dealerCard1
            // 
            this.dealerCard1.AutoSize = true;
            this.dealerCard1.Location = new System.Drawing.Point(13, 14);
            this.dealerCard1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(0, 13);
            this.dealerCard1.TabIndex = 0;
            // 
            // pnlPlayerCards
            // 
            this.pnlPlayerCards.Controls.Add(this.txtPlayerCard3);
            this.pnlPlayerCards.Controls.Add(this.txtPlayerCard2);
            this.pnlPlayerCards.Controls.Add(this.txtPlayerCard1);
            this.pnlPlayerCards.Location = new System.Drawing.Point(361, 159);
            this.pnlPlayerCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPlayerCards.Name = "pnlPlayerCards";
            this.pnlPlayerCards.Size = new System.Drawing.Size(263, 173);
            this.pnlPlayerCards.TabIndex = 10;
            // 
            // txtPlayerCard3
            // 
            this.txtPlayerCard3.Location = new System.Drawing.Point(182, 18);
            this.txtPlayerCard3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayerCard3.Name = "txtPlayerCard3";
            this.txtPlayerCard3.Size = new System.Drawing.Size(63, 20);
            this.txtPlayerCard3.TabIndex = 5;
            // 
            // txtPlayerCard2
            // 
            this.txtPlayerCard2.Location = new System.Drawing.Point(101, 18);
            this.txtPlayerCard2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayerCard2.Name = "txtPlayerCard2";
            this.txtPlayerCard2.Size = new System.Drawing.Size(63, 20);
            this.txtPlayerCard2.TabIndex = 4;
            // 
            // txtPlayerCard1
            // 
            this.txtPlayerCard1.Location = new System.Drawing.Point(19, 18);
            this.txtPlayerCard1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayerCard1.Name = "txtPlayerCard1";
            this.txtPlayerCard1.Size = new System.Drawing.Size(63, 20);
            this.txtPlayerCard1.TabIndex = 3;
            // 
            // FrmBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(669, 406);
            this.Controls.Add(this.pnlPlayerCards);
            this.Controls.Add(this.pnlDealerCards);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBlackJack";
            this.Text = "Form1";
            this.pnlDealerCards.ResumeLayout(false);
            this.pnlDealerCards.PerformLayout();
            this.pnlPlayerCards.ResumeLayout(false);
            this.pnlPlayerCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Panel pnlDealerCards;
        private System.Windows.Forms.Panel pnlPlayerCards;
        private System.Windows.Forms.TextBox txtDealerCard3;
        private System.Windows.Forms.TextBox txtDealerCard2;
        private System.Windows.Forms.TextBox txtDealerCard1;
        private System.Windows.Forms.Label dealerCard1;
        private System.Windows.Forms.TextBox txtPlayerCard3;
        private System.Windows.Forms.TextBox txtPlayerCard2;
        private System.Windows.Forms.TextBox txtPlayerCard1;
    }
}

