using System;
using System.Numerics;
namespace AbramianHomeWork.Abram
{
    public static class Vector2Extensions
    {
        public static float DistanceSquared(this Vector2 a, Vector2 b)
            => MathF.Pow(b.X - a.X, 2) + MathF.Pow(b.Y - a.Y, 2);
    }
}
