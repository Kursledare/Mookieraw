using System;

namespace TurnManager
{
    public struct Vector2
    {
        public Vector2(Int32 x,Int32 y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
        public static Vector2 operator -(Vector2 a)
        {
            return new Vector2(-a.X, -a.Y);
        }
        public static Vector2 operator -(Vector2 a, int b)
        {
            return new Vector2(a.X - b, a.Y - b);
        }
        public static Vector2 operator *(Vector2 a, int b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }
        public static float Distance(Vector2 a, Vector2 b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;
​
            var x2y2 = (dx * dx) + (dy * dy);
​
            return (float)Math.Sqrt(x2y2);
        }
    }
}