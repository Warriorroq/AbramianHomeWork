using System;
namespace AbramianHomeWork.Abram
{
    public class BooleanTask
    {
        public bool Boolean1(int a)
            => a > 0;
        public bool Boolean2(int a)
            => !(a % 2 == 0);
        public bool Bolean3(int a)
            => a % 2 == 0;
        public bool Boolean4(int a, int b)
            => a > 2 && b <= 3;
        public bool Boolean5(int a, int b)
            => a >= 0 || b < -2;
        public bool Boolean6(int a, int b, int c)
            => a < b && b < c;
        public bool Boolean7(int a, int b, int c)
            => (a > b && b > c) || (a < b && b < c);
        public bool Boolean8(int a, int b)
            => a % 2 == 1 && b % 2 == 1;
        public bool Boolean9(int a, int b)
            => a % 2 == 1 || b % 2 == 1;
        public bool Boolean10(int a, int b)
            => a % 2 - b % 2 == 1;
        public bool Boolean11(int a, int b)
            => a % 2 == b % 2;
        public bool Boolean12(int a, int b, int c)
            => a > 0 && b > 0 && c > 0;
        public bool Boolean13(int a, int b, int c)
            => a > 0 || b > 0 || c > 0;
        public bool Boolean14(int a, int b, int c)
            => HelperBoolean14(a, b, c) || HelperBoolean14(b, c, a) || HelperBoolean14(c, b, a);
        private bool HelperBoolean14(int biggerThanZero, int LessThanZero1, int LessThanZero2)
            => biggerThanZero > 0 && LessThanZero1 < 0 && LessThanZero2 < 0;
        public bool Boolean15(int a, int b, int c)
            => a * b * c > 0 && (a < 0 || b < 0 || c < 0);
        public bool Boolean16(int num)
            => num % 2 == 0 && num < 100 && num > 9;
        public bool Boolean17(int num)
            => num % 2 == 1 && num < 1000 && num > 100;
        public bool Boolean18(int a, int b, int c)
            => a == b || b == c || c == a;
        public bool Boolean20(int num)
            => num / 100 != num % 100 / 10 && num / 100 != num % 10 && num % 100 / 10 != num % 10;
        public bool Boolean21(int num)
            => num % 100 / 10 - num / 100 > 0 && num % 10 - num / 10 % 10 > 0;
        public bool Boolean22(int num)
            => Boolean21(num) || (num % 100 / 10 - num / 100 < 0 && num % 10 - num / 10 % 10 < 0);
        public bool Boolean23(int num)
            => num % 10 == num / 1000 && num % 100 / 10 == num / 100 % 10;
        public bool Boolean24(int a, int b, int c)
            => b * b - 4 * a * c >= 0;
        public bool Boolean25(int x,int y)
            => y > 0 && x < 0;
        public bool Boolean26(int x, int y)
            => y < 0 && x > 0;
        public bool Boolean27(int x, int y)
            => Boolean25(x, y) || (y < 0 && x < 0);
        public bool Boolean28(int x, int y)
            => (y < 0 && x < 0) || (x > 0 && y > 0);
        public bool Boolean29(int x1, int y1, int x2, int y2, int x3, int y3)
            => (x1 < x3 && x1 > x2) && (y1 < y2 && y1 > y3);
        public bool Boolean30(int a, int b, int c)
            => a == b && b == c;
        public bool Boolean31(int a, int b, int c)
            => (a == b && b != c) || (b == c && c != a) || (a == c && b != c);
        public bool Boolean32(int a, int b, int c)
            => IsPifagorTriangle(a, b, c) || IsPifagorTriangle(b, a, c) || IsPifagorTriangle(c, a, b);
        private bool IsPifagorTriangle(int bigPants, int smallPants, int smallPants2)
            => bigPants * bigPants > smallPants * smallPants + smallPants2 * smallPants2;
        public bool Boolean33(int a, int b, int c)
            => BiggerNum(a, b, c) > Math.Abs(BiggerNum(a, b, c) - a - b - c);
        private int BiggerNum(int num1, int num2, int num3)
            => num1 > num2 && num1 > num3 ? num1 : num2 > num3 ? num2 : num3;
        public bool Boolean34(int x, int y)
            => (x % 2 == 1 && y % 2 == 0) || (x % 2 == 0 && y % 2 == 1);
        public bool Boolean35(int x1, int y1, int x2, int y2)
            => Boolean34(x1, y1) == Boolean34(x2, y2);
        public bool Boolean36(int x1, int y1, int x2, int y2)
            => (x1 == x2 && y1 != y2) || (x1 != x2 && y1 == y2);
        public bool Boolean37(int x1, int y1, int x2, int y2)
            => Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
        public bool Boolean38(int x1, int y1, int x2, int y2)
            => Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        public bool Boolean39(int x1, int y1, int x2, int y2)
            => (Math.Abs(x2 - x1) == Math.Abs(y2 - y1)) || (Math.Abs(x2 - x1) > 0 && y2 == y1) || (Math.Abs(y2 - y1) > 0 && x2 == x1);
        public bool Boolean40(int x1, int y1, int x2, int y2)
            => (Math.Abs(x2 - x1) == 2 && Math.Abs(y2 - y1) == 1) || (Math.Abs(x2 - x1) == 1 && Math.Abs(y2 - y1) == 2);
    }
}
