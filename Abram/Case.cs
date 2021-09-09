using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbramianHomeWork.Abram
{
    public class Case
    {
        public string Case1(int day)
            => day switch
            {
                1 => "пн",
                2 => "вт",
                3 => "ср",
                4 => "чт",
                5 => "пт",
                6 => "сб",
                7 => "вс",
                _ => throw new Exception($"{nameof(day)} isn't 1-7")
            };
        public string Case2(int day)
            => day switch
            {
                1 => "плохо",
                2 => "неудоблетворительно",
                3 => "удоблетворительно",
                4 => "хорошо",
                5 => "отлично",
                _ => "ошибка"
            };
    }
}
