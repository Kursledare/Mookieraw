using System;
using System.Text;

namespace GameEngine
{
    /// <summary>
    /// Represents a point in 2 dimensions.
    /// </summary>
    public class Vector2
    {
        public Vector2(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
        }
        public float X { get; set; }
        public float Y { get; set; }

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

        public static Vector2 operator -(Vector2 a, float b)
        {
            return new Vector2(a.X - b, a.Y - b);
        }

        public static Vector2 operator *(Vector2 a, float b)
        {
            return new Vector2(a.X*b, a.Y*b);
        }
        /// <summary>
        /// Calculate Distance between 2 Vector2
        /// </summary>
        /// <param name="a">First Vector2</param>
        /// <param name="b">Second Vector2</param>
        /// <returns>distance between the 2 Vector2</returns>
        public static float Distance(Vector2 a, Vector2 b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;
            var x2Y2 = dx*dx + dy*dy;
            return (float) Math.Sqrt(x2Y2);
        }
        /// <summary>
        /// Calculate Distance from this Vector2 to another Vector2
        /// </summary>
        /// <param name="b">Second Vector2</param>
        /// <returns>distance to the second Vector2</returns>
        public float Distance(Vector2 b)
        {
            return Distance(this, b);
        }
        /// <summary>
        /// Calculate Unit Vector based on the 2 Vector2(A Vector2 with magnitude of 1).
        /// </summary>
        /// <param name="a">First Vector2</param>
        /// <param name="b">Second Vector2</param>
        /// <returns>Unit Vector</returns>
        public static Vector2 Normalize(Vector2 a, Vector2 b)
        {
            var length = Distance(a, b);
            var nx = (b.X - a.X)/length;
            var ny = (b.Y - a.Y)/length;
            return new Vector2(nx,ny);
        }
        /// <summary>
        /// Calculate Unit Vector from this Vector2 to Second Vector2(A Vector2 with magnitude of 1).
        /// </summary>
        /// <param name="b">Second Vector2</param>
        /// <returns>Unit Vector</returns>
        public Vector2 Normalize(Vector2 b)
        {
            return Normalize(this, b);
        }
    }
}