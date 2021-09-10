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
                < 3 => "winter",
                < 6 => "spring",
                < 9 => "summer",
                < 12 => "autumn",
                _ => throw new Exception("less or bigger (1 - 12)")
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
                1 => 31,
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
                _ => throw new Exception("incorrect input")
            };
        public int Case4(int month)
            => GetDaysInMonth(month);
        public int Case5(int n, int a, int b)
            => n switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
                _ => throw new Exception("n is not 1 - 4")
            };
        public int Case6(int convertTo, int length)
            => convertTo switch
            {
                1 => length / 10,
                2 => length * 1000,
                3 => length,
                4 => length / 1000,
                5 => length / 100,
                _ => throw new Exception("incorrect input")
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
            if (day > GetDaysInMonth(month))
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
                _ => throw new Exception("input error")
            };

        public IEnumerable Case11(char direction, params int[] moves)
            => Case10(direction, moves);
        public IEnumerable Case12(int element, float value)
        {
            float r = GetRadius(element,value), 
                d = r * 2, 
                l = d * MathF.PI, 
                s = r * r * MathF.PI;
            yield return r;
            yield return d;
            yield return l;
            yield return s;
        }
        private float GetRadius(int element, float value)
            => element switch
            {
                1 => value,
                2 => value / 2,
                3 => value / 2 / MathF.PI,
                4 => MathF.Sqrt(value / MathF.PI),
                _ => throw new Exception("Invait value")
            };
        public IEnumerable Case13(int element, float value)
        {
            float side = GetTwoSideTriangleSide(element, value), 
                hypotenuse = side * 1.41f,
                height = hypotenuse / 2,
                area = hypotenuse * height / 2;
            yield return side;
            yield return hypotenuse;
            yield return height;
            yield return area;
        }
        private float GetTwoSideTriangleSide(int element, float value)
            => element switch
            {
                1 => value,
                2 => value / 1.41f,
                3 => value * 1.41f,
                4 => MathF.Sqrt(value * 2),
                _ => throw new Exception("Invait value")
            };
        public IEnumerable Case14(int element, float value)
        {

            float side = GetEquilateralTriangleSide(element, value),
                R1 = side * 1.73f/6,
                R2 = R1 * 2,
                S = side * side * 1.73f / 4;
            yield return side;
            yield return R1;
            yield return R2;
            yield return S;
        }
        private float GetEquilateralTriangleSide(int element, float value)
            => element switch
            {
                1 => value,
                2 => value * 6 / 1.73f,
                3 => value * 3 / 1.73f,
                4 => MathF.Sqrt(value * 4 / 1.73f),
                _ => throw new Exception("Invait value")
            };
        public string Case15(int mask, int cost)
        {
            string description = string.Empty;
            description += GetCardMask(mask);
            description += " " + GetCardCost(cost);
            return description;
        }
        private string GetCardMask(int mask)
            => mask switch
            {
                1 => "pika",
                2 => "trefe",
                3 => "bubna",
                4 => "cherva",
                _ => throw new Exception("incorrect input")
            };
        private string GetCardCost(int cost)
            => cost switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                11 => "Valet",
                12 => "Queen",
                13 => "King",
                14 => "Tuz",
                _ => throw new Exception("incorrect input")
            };
        public string Case16(int years)
            => GetTenthIntoNum(years / 10) + " " + GetNumYear(years % 10);
        private string GetTenthIntoNum(int tenth)
            => tenth switch {
                2 => "двадцать",
                3 => "тридцать",
                4 => "сорок",
                5 => "пятьдесят",
                6 => "шестьдесят",
                7 => "семьдесят",
                8 => "восемьесят",
                9 => "девяносто",
                _ => throw new Exception("incorrect input")
            };
        private string GetNumYear(int tenth)
            => tenth switch
            {
                1 => "один год",
                2 => "два года",
                3 => "три года",
                4 => "четыре года",
                5 => "пять лет",
                6 => "шесть лет",
                7 => "семь лет",
                8 => "восемь лет",
                9 => "девять лет",
                _ => throw new Exception("incorrect input")
            };
        public string Case17(int number)
        {
            string description = string.Empty;
            if(number < 19)
            {
                if (number != 11)
                    description += GetNumberForTask(number % 10) + "надцать";
                else
                    description += "одинадцать";
                description += " заданий";
                
            }
            else
            {
                description += GetTenthIntoNum(number / 10) + " ";
                description += GetNumberForTask(number % 10);
                if (number % 10 == 0)
                    description += " задание";
                else if(number < 4)
                    description += " задания";
                else
                    description += " заданий";
            }
            return description;
        }
        private string GetNumberForTask(int number)
            => number switch
            {
                1 => "одно",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _ => throw new Exception("Invalid input")
            };
        public string Case18(int number)
        {
            string description = ConvertHundreadToNum(number / 100) + " ";
            if(number % 100 < 20)
            {
                if (number != 11)
                    description += GetNumberForTask(number % 10) + "надцать";
                else
                    description += "одинадцать";
            }
            else
            {
                description += GetTenthIntoNum(number % 100 / 10) + " ";
                description += GetNumberForTask(number % 10);
            }
            return description;
        }
        private string ConvertHundreadToNum(int number)
            => number switch
            {
                1 => "сто",
                2 => "двести",
                3 => "триста",
                4 => "четыреста",
                5 => "пятьсот",
                6 => "шестьсот",
                7 => "семьсот",
                8 => "восемьсот",
                9 => "девятьсот",
                _ => throw new Exception("incorrect input")
            };
        public string Case19(int year)
            => ConvertYearToColor(year) + " " + ConvertYearToAnimal(year);
        private string ConvertYearToColor(int year)
            => (year % 60 / 12) switch
            {
                0 => "зелёный",
                1 => "краный",
                2 => "жёлтый",
                3 => "белый",
                4 => "чёрный",
                _=> throw new Exception("incorrect input")
            };
        private string ConvertYearToAnimal(int year)
            => (year % 60 % 12) switch
            {
                0 => "крысы",
                1 => "коровы",
                2 => "тигра",
                3 => "зайца",
                4 => "дракона",
                5 => "змеи",
                6 => "лошади",
                7 => "овцы",
                8 => "обезьяны",
                9 => "курицы",
                10 => "собаки",
                11 => "свиньи",
                _ => throw new Exception("incorrect input")
            };
        public string Case20(int d, int m)
            => (m * 100 + d) switch
            {
                <= 191 => "Козерог",
                >= 1222 => "Козерог",
                <= 281 => "Водолей",
                <= 320 => "Рыбы",
                <= 419 => "Овен",
                <= 520 => "Телец",
                <= 621 => "Близнецы",
                <=722 => "Рак",
                <= 822 => "Лев",
                <= 922 => "Дева",
                <= 1022 => "Весы",
                <= 1122 => "Скорпион",
                <=1221 => "Стрелец",
            };
    }
}
