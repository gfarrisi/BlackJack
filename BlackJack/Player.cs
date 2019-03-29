using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        string name;
        int money;
        Boolean winner;

        public Player(string name)
        {
            this.name = name;
        }

        public void setMoney(int money)
        {
            this.money = money;
        }
        public int getMoney()
        {
            return this.money;
        }
        public void setWinner(Boolean isWinner)
        {
            this.winner = isWinner;
        }
        public Boolean isWinner()
        {
            return this.winner;
        }
    }
}
