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
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(227, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(555, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of BlackJack!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(290, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(428, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 26);
            this.txtName.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Khaki;
            this.btnPlay.Location = new System.Drawing.Point(682, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(62, 35);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Bahnschrift", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(228, 208);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(98, 34);
            this.lblDealer.TabIndex = 4;
            this.lblDealer.Text = "Dealer";
            this.lblDealer.Visible = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Bahnschrift", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(686, 208);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(96, 34);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.Visible = false;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Gold;
            this.btnHit.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(134, 557);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(369, 46);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.Gold;
            this.btnStay.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(523, 557);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(369, 46);
            this.btnStay.TabIndex = 8;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Visible = false;
            // 
            // FrmBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1004, 625);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FrmBlackJack";
            this.Text = "Form1";
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
    }
}

