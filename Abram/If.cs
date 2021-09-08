using System;
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
    }
}
