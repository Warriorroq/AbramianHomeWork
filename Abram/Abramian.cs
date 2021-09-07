using System;
namespace AbramianHomeWork.Abram
{
    public class Abramian
    {
        private IntegerTask _integer;
        public Abramian()
        {
            _integer = new IntegerTask();
        }
        public void Run()
        {
            Console.WriteLine(_integer.Integer30(2301));
        }
    }
}
