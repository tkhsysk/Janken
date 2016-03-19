using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Judge saito = new Judge();

            Player murata = new Player("村田");

            Player yamada = new Player("山田");

            saito.StartJanken(murata, yamada);

            Console.ReadLine();
        }
    }
}
