using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Janken
{
    class Judge
    {
        public void StartJanken(Player player1, Player player2)
        {
            for(int i = 0; i < 3; i++)
            {
                Player winner = JudgeJanken(player1, player2);

                if(winner != null)
                {
                    winner.NotifyResult(true);
                    Console.WriteLine(winner.Name);
                }
            }

            Player finalWinner = JudgeFinalWinner(player1, player2);

            if (finalWinner != null)
            {
                Console.WriteLine(finalWinner.Name + "の勝ちです。");
            }
            else
            {
                Console.WriteLine("引き分けです。");
            }
        }

        public Player JudgeJanken(Player player1, Player player2)
        {
            Player winner = null;

            int player1Hand = player1.ShowHand();
            int player2Hand = player2.ShowHand();

            bool judge1 = player1Hand == Player.STONE && player2Hand == Player.SCISSORS;
            bool judge2 = player1Hand == Player.SCISSORS && player2Hand == Player.PAPER;
            bool judge3 = player1Hand == Player.PAPER && player2Hand == Player.STONE;

            bool judge4 = player1Hand == Player.STONE && player2Hand == Player.PAPER;
            bool judge5 = player1Hand == Player.SCISSORS && player2Hand == Player.STONE;
            bool judge6 = player1Hand == Player.PAPER && player2Hand == Player.SCISSORS;

            if (judge1 || judge2 || judge3)
            {
                winner = player1;
            }
            else if (judge4 || judge5 || judge6)
            {
                winner = player2;
            }

            return winner;
        }

        public Player JudgeFinalWinner(Player player1, Player player2)
        {
            Player winner = null;

            int player1WinCount = player1.GetWinCount();
            int player2WinCount = player2.GetWinCount();

            if(player1WinCount > player2WinCount)
            {
                winner = player1;
            }
            else if(player1WinCount < player2WinCount)
            {
                winner = player2;
            }

            return winner;
        }
    }
}
