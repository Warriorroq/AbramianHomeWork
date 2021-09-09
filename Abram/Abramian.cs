using System;
using System.Numerics;
namespace AbramianHomeWork.Abram
{
    public class Abramian
    {
        private IntegerTask _integer;
        private BooleanTask _boolean;
        private If _if;
        public Abramian()
        {
            _integer = new IntegerTask();
            _boolean = new BooleanTask();
            _if = new If();
        }
        public void Run()
        {
            Console.WriteLine(_if.If30(-4));
        }
    }
}
