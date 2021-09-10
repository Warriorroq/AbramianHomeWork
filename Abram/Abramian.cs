using System;
namespace AbramianHomeWork.Abram
{
    public class Abramian
    {
        private IntegerTask _integer;
        private BooleanTask _boolean;
        private If _if;
        private Case _case;
        private For _for;
        public Abramian()
        {
            _integer = new IntegerTask();
            _boolean = new BooleanTask();
            _if = new If();
            _case = new Case();
            _for = new For();
        }
        public void Run()
        {
            Console.WriteLine(_for.For13(4));
        }
    }
}
