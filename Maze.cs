﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace EthanFinalProject
{
    class Maze
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;

        public Maze(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);

        }

        public void DrawMaze()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);

                    if (element == "X")
                    {
                        ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }

                    Write(element);
                }
            }
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }


        public bool Walkable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }

            return Grid[y, x] == " " || Grid[y, x] == "X";

        }
    }
}
