using System;
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
            Console.WriteLine(_case.Case20(25, 7));
        }
    }
}
