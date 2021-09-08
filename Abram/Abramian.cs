using System;
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
            foreach(var b in _if.If16(1,99,9))
                Console.WriteLine(b);
        }
    }
}
