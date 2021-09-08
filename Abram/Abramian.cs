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
            var a = _if.If5(1, 2, 3, 4, 5, -1, 0, 0, 0, -2, -3);
            foreach(var b in a)
                Console.WriteLine(b);
            
        }
    }
}
