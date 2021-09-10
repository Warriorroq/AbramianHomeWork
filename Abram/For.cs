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
        public List<int> For3(int a, int b)
        {
            a++;
            var nums = Enumerable.Range(a, b - a).ToList();
            nums.Add(nums.Count);
            return nums;
        }
        public IEnumerable For4(float price)
            => Enumerable.Range(1, 10).Select(x => x * price);
        public IEnumerable For5(float price)
            => Enumerable.Range(1, 10).Select(x => x * price / 10f);
        public IEnumerable For6(float price)
            => Enumerable.Range(1, 5).Select(x => (x / 5f + 1) * price);
        public int For7(int a, int b)
            => Enumerable.Range(a, b - a + 1).Sum();
    }
}
