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
        public FrmBlackJack()
        {
            InitializeComponent();
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
                //get two cards for dealer

                //get two cards fro the player

            }
        }
    }
}
