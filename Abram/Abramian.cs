using System;
using System.Numerics;
namespace AbramianHomeWork.Abram
{
    public class Abramian
    {
        private IntegerTask _integer;
        private BooleanTask _boolean;
        private If _if;
        private Case _case;
        public Abramian()
        {
            _integer = new IntegerTask();
            _boolean = new BooleanTask();
            _if = new If();
            _case = new Case();
        }
        public void Run()
        {
            foreach(var i in _case.Case10('С' , 1, 1, 1, 1, -1, -1, 1, 1, 0))
                Console.WriteLine(i);
        }
    }
}
