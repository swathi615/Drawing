﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawing
{
    public class Point
    {
        public readonly int X;

        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            var p = ((Point)obj);
            return this.X == p.X && this.Y == p.Y;
        }

        public override int GetHashCode()
        {
            return new { X, Y }.GetHashCode();
        }
    }
}
