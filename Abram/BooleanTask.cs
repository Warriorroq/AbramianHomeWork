using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            => num / 100 != num % 100 / 10 && num / 100 != num % 10;
    }
}
