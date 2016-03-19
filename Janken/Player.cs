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
        public Tactics HandTactics { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public int ShowHand()
        {
            int hand = HandTactics.ReadTactics();

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
