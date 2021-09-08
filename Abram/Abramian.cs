using System;
namespace AbramianHomeWork.Abram
{
    public class Abramian
    {
        private IntegerTask _integer;
        private BooleanTask _boolean;
        public Abramian()
        {
            _integer = new IntegerTask();
            _boolean = new BooleanTask();
        }
        public void Run()
        {
            Console.WriteLine(_boolean.Boolean34(2,2));
            
        }
    }
}
