﻿using System;

namespace snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}