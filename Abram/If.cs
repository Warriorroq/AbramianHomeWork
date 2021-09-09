using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbramianHomeWork.Abram
{
    public class If
    {
        public int If1(int num)
            => num > 0 ? num + 1 : num;
        public int If2(int num)
            => num > 0 ? num + 1 : num - 2;
        public int If3(int num)
            => num > 0 ? num + 1 : num < 0 ? num - 2 : 10;
        public void If4(params int[] num)
            => num.ToList().ForEach(num => {
                if (num > 0)
                    Console.WriteLine(num);
            });
        public List<int> If5(params int[] nums)
            => nums.Where(num => num > 0).ToList();
        public int If6(int a, int b)
            => a > b ? a : b;
        public int If7(int a, int b)
            => a > b ? 0 : 1;
        public IEnumerable If8(int a, int b)
        {
            if (a > b)
            {
                yield return a;
                yield return b;
            }
            else
            {
                yield return b;
                yield return a;
            }
        }
        public (int, int) If9(int a, int b)
        {
            if (a > b)
                return (a, b);
            return (b, a);
        }
        public (int, int) If10(int a, int b)
            => a != b ? (a + b, a + b) : (0, 0);
        public (int, int) If11(int a, int b)
            => a > b ? (a, a) : a < b ? (b, b) : (0, 0);
        public int If12(int a, int b, int c)
            => a > b ? b > c ? c : b : a;
        public int If13(int a, int b, int c)
            => (b < a && a < c) || (b > a && a > c) ? a :
            (a < b && b < c) || (a > b || b > c) ? b : c;
        public IEnumerable If14(int a, int b, int c)
        {
            var temp = If13(a, b, c);
            if (a != temp)
                yield return a;
            if (b != temp)
                yield return b;
            if (c != temp)
                yield return c;
        }
        public int If15(int a, int b, int c)
            => a + b + c - If13(a, b, c);
        public IEnumerable If16(int a, int b, int c)
        {
            if (a < b && b < c)
            {
                yield return a * 2;
                yield return b * 2;
                yield return c * 2;
            }
            else
            {
                yield return a * -1;
                yield return b * -1;
                yield return c * -1;
            }
        }
        public IEnumerable If17(int a, int b, int c)
        {
            if ((a < b && b < c) || (a > b && b > c))
            {
                yield return a * 2;
                yield return b * 2;
                yield return c * 2;
            }
            else
            {
                yield return a * -1;
                yield return b * -1;
                yield return c * -1;
            }
        }
        public int If18(int a, int b, int c)
            => a == b ? 3 : a == c ? 2 : 1;
        public int If19(int a, int b, int c, int d)
            => a == b && b == c ? d : a == c ? b : a == d ? c : a;
        public Vector2 If20(Vector2 a, Vector2 b, Vector2 c)
            => a.DistanceSquared(b) > a.DistanceSquared(c) ? c : b;
        public int If21(Vector2 dot)
            => dot.X == 0 && dot.Y == 0 ? 0 : dot.X != 0 && dot.Y != 0 ? 3 : dot.X == 0 ? 2 : 1;
        public int If22(Vector2 dot)
            => dot.X > 0 && dot.Y > 0 ? 1 :
            dot.X < 0 && dot.Y > 0 ? 2 :
            dot.Y < 0 && dot.X < 0 ? 3 : 4;
        public Vector2 If23(Vector2 a, Vector2 b, Vector2 c)
            => a.X == b.X ? If23Helper(a, b, c) : a.X == c.X ? If23Helper(a, c, b) : If23Helper(b, c, a);
        private Vector2 If23Helper(Vector2 a, Vector2 b, Vector2 c)
        {
            Vector2 d;
            d.X = c.X;
            if (a.Y == c.Y)
                d.Y = b.Y;
            else
                d.Y = a.Y;
            return d;
        }
        public float If24(float x)
            => x > 0 ? 2 * MathF.Sin(x) : 6 - x;
        public float If25(float x)
            => x < -2 || x > 2 ? 2 * x : -3 * x;
        public float If26(float x)
            => x <= 0 ? -x : 0 < x && x < 2 ? x * x : 4;
        public float If27(float x)
            => x < 0 ? 0 : x / 2 % 1 < 0.5f ? 1 : -1;
        public bool If28(int year)
            => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0; //DateTime.IsLeapYear()
        public string If29(int num)
        {
            string description = $"num {num} is ";
            if (num == 0)
                return "num is zero";
            if (num > 0)
                description += "bigger";
            else
                description += "less";
            description += " zero and ";
            if (num % 2 == 0)
                description += "2n";
            else
                description += "2n + 1";
            return description;
        }
        public string If30(int num)
        {
            string description = If29(num) + " and has ";
            num = Math.Abs(num);
            if (num > 100)
                description += "three numbers";
            else if (num > 10)
                description += "two numbers";
            else
                description += "one number";
            description += " in it";
            return description;
        }
    }
}
