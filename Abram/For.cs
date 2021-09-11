using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbramianHomeWork.Abram
{
    public class For
    {
        public IEnumerable For1(int n, int k)
            => Enumerable.Range(0, n).Select(n => k);
        public List<int> For2(int a, int b)
        {
            var nums = Enumerable.Range(a, b - 1).ToList();
            nums.Add(nums.Count);
            return nums;
        }
        public IEnumerable<int> For3(int a, int b)
            =>Enumerable.Range(a + 1, b - a - 1).Append(b - a - 1);
        public IEnumerable For4(float price)
            => Enumerable.Range(1, 10).Select(x => x * price);
        public IEnumerable For5(float price)
            => Enumerable.Range(1, 10).Select(x => x * price / 10f);
        public IEnumerable For6(float price)
            => Enumerable.Range(1, 5).Select(x => (x / 5f + 1) * price);
        public int For7(int a, int b)
            => Enumerable.Range(a, b - a + 1).Sum();
        public int For8(int a, int b)
            => Enumerable.Range(a, b - a + 1).Aggregate((x,y) => x * y);
        public int For9(int a, int b)
            => Enumerable.Range(a, b - a + 1).Select(x => x * x).Sum();
        public float For10(int n)
            => Enumerable.Range(1, n).Select(x => 1f/x).Sum();
        public float For11(int n)
            => Enumerable.Range(0, n).Select(x => (n + x)*(n + x)).Sum();
        public float For12(int n)
            => Enumerable.Range(1, n).Select(x => (1 + x / 10f)).Aggregate((x, y) => x * y);
        public float For13(int n)
            => Enumerable.Range(1, n).Select(x => (x % 2 == 0 ? -1 : 1) * (1 + x / 10f)).Sum();
        public float For14(int n)
            => Enumerable.Range(1, n).Select(x => 2 * x - 1).Sum();
        public int For15(int a, int n)
            => Enumerable.Range(0, n).Select(x => a).Aggregate((x, y) => x * y);
        public List<int> For16(int a, int n)
        {
            var nums = new List<int>();
            var a1 = a;
            for (var i = 1;i<=n;i++)
            {
                nums.Add(a1);
                a1 *= a;
            }
            return nums;
        }
        public int For17(int a, int n)
        {
            int sum = 1, a1 = a;
            for (var i = 1; i <= n; i++)
            {
                sum += a1;
                a1 *= a;
            }
            return sum;
        }
        public int For18(int a, int n)
        {
            int sum = 1, a1 = a, sign = -1;
            for (var i = 1; i <= n; i++)
            {
                sum += sign * a1;
                a1 *= a;
                sign *= -1;
            }
            return sum;
        }
        public List<decimal> For19(int n)
        {
            var nums = new List<decimal>();
            nums.Add(1);
            decimal num1 = 1, num2 = 2;
            for(;n > 0;n--)
            {
                nums.Add(num1 * num2);
                num2++; 
                num1++;
            }
            return nums;
        }
    }
}
