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
    }
}
