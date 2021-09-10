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
            var nums = Enumerable.Range(a, b - 1).Select(a => a).ToList();
            nums.Add(nums.Count);
            return nums;
        }
    }
}
