using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EthanFinalProject
{
    class Player
    {
        string PlayerName = "Player";
        //Items: Key, T.rex Eggs, Stick
        List<string> Items = new List<string>() { };

        public Player(string name)
        {
            PlayerName = name;
        }

    }
}
