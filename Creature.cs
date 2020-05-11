using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EthanFinalProject
{
    class Creature
    {
        string Name;
        string Type;
        double Size;
        ConsoleColor Color;

        public Creature(string name, string type, double size, ConsoleColor color)
        {
            Name = name;
            Type = type;
            Size = size;
        }

        public void DrawAvatar()
        {
            ForegroundColor = Color;
            //SOURCE: https://ascii.co.uk/art/dinosaur
            WriteLine(@"               __
              / _)
     _/\/\/\_/ /
   _|         /
 _|  (  | (  |
/__.-'|_|--|_|");
            ResetColor();
        }


    }
}
