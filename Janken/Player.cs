using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Janken
{
    class Player
    {
        public const int STONE = 0;
        public const int SCISSORS = 1;
        public const int PAPER = 2;


        private int _winCount = 0;

        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public int ShowHand()
        {
            int hand = 0;

            Random rand = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
            int randomNum = rand.Next(3);

            if(randomNum == 0)
            {
                hand = STONE;
            }
            else if(randomNum == 1)
            {
                hand = SCISSORS;
            }
            else
            {
                hand = PAPER;
            }

            return hand;
        }

        public int GetWinCount()
        {
            return _winCount;
        }

        public void NotifyResult(bool result)
        {
            _winCount = result ? _winCount + 1 : _winCount;
        }


    }
}
