using System;
using System.Collections;
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
        public IEnumerable Case3(int month)
        {
            yield return GetSeason(month);
            yield return GetMonth(month);
        }
        private string GetSeason(int month)
            => month switch
            {
                12 => "winter",
                <3 => "winter",
                < 6 => "spring",
                < 9 => "summer",
                < 12 => "autumn",
                _=> throw new Exception("less or bigger (1 - 12)")
            };
        private string GetMonth(int month)
            => month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => throw new Exception("is not in 1 - 12")
            };
        private int GetDaysInMonth(int month)
            => month switch
            {
                1  => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _=>throw new Exception("incorrect input")
            };
        public int Case4(int month)
            => GetDaysInMonth(month);
        public int Case5(int n, int a, int b)
            => n switch{
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
                _=> throw new Exception("n is not 1 - 4")
            };
        public int Case6(int convertTo, int length)
            => convertTo switch
            {
                1 => length / 10,
                2 => length * 1000,
                3 => length,
                4 => length / 1000,
                5 => length / 100,
                _=>throw new Exception("incorrect input")
            };
        public int Case7(int convertTo, int mass)
            => convertTo switch
            {
                1 => mass,
                2 => mass / 10000,
                3 => mass / 1000,
                4 => mass * 1000,
                5 => mass * 100,
                _ => throw new Exception("incorrect input")
            };
        public IEnumerable Case8(int day, int month)
        {
            day--;
            if (day == 0)
            {
                month--;
                if (month == 0)
                    month = 12;
                day = GetDaysInMonth(month);
            }
            yield return day;
            yield return month;
        }
        public IEnumerable Case9(int day, int month)
        {
            day++;
            if(day > GetDaysInMonth(month))
            {
                month++;
                if (month > 12)
                    month = 1;
                day = 1;
            }
            yield return day;
            yield return month;
        }
        public IEnumerable Case10(char direction, params int[] moves)
        {
            int numDir = GetRobotCharDirectionToNum(direction);
            yield return direction;
            foreach (int move in moves)
            {
                numDir -= move;
                yield return move;
                yield return ConvertRobotNumDirectionToCharDirection(Math.Abs(numDir % 4));
            }
        }
        private char ConvertRobotNumDirectionToCharDirection(int num)
            => num switch
            {
                0 => 'С',
                1 => 'З',
                2 => 'Ю',
                3 => 'В',
                _ => throw new Exception("input error")
            };
        private int GetRobotCharDirectionToNum(char direction)
            => direction switch
            {
                'С' => 0,
                'З' => 1,
                'Ю' => 2,
                'В' => 3,
                _=>throw new Exception("input error")
            };
    }
}
