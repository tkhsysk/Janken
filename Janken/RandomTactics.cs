using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Janken
{
    class RandomTactics : Tactics
    {
        public int ReadTactics(){
            int hand = 0;

            Random rand = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
            int randomNum = rand.Next(3);

            if (randomNum == 0)
            {
                hand = Player.STONE;
            }
            else if (randomNum == 1)
            {
                hand = Player.SCISSORS;
            }
            else
            {
                hand = Player.PAPER;
            }

            return hand;
        }
    }
}
