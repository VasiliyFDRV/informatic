using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2023
{
    public struct Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length
        {
            get => Math.Sqrt(X * X + Y * Y);
        }

        public List<double> XY
        {
            get => new List<double> { X, Y };
        }

        public Vector2D(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X},{Y})";

        public override bool Equals(object obj)
        {
            if (obj is Vector2D)
                return X == ((Vector2D)obj).X && Y == ((Vector2D)obj).Y;

            throw new ArgumentException("Объект для сравнения не является  вектором");
        }

        public override int GetHashCode() => XY.GetHashCode();

        public static bool operator ==(Vector2D a, Vector2D b) => a.Equals(b);
        public static bool operator !=(Vector2D a, Vector2D b) => !a.Equals(b);

        public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a.X + b.X, a.Y + b.Y);
        public static Vector2D operator -(Vector2D a, Vector2D b) => new Vector2D(a.X - b.X, a.Y - b.Y);

        public static double operator *(Vector2D a, Vector2D b) => a.X * a.Y + b.X * b.Y;
        public static Vector2D operator *(double k, Vector2D a) => new Vector2D(k * a.X, k * a.Y);
        public static Vector2D operator *(Vector2D a, double k) => new Vector2D(k * a.X, k * a.Y);


    }
}
