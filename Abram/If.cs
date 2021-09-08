using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            => nums.Where(num => num > 0).Select(num => num).ToList();
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
        public IEnumerable If16(int a,int b,int c)
        {
            if(a < b && b < c)
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
    }
}
