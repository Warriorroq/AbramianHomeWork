namespace AbramianHomeWork.Abram
{
    public class IntegerTask
    {
        public int Integer1(int distance)
            => distance / 100;
        public int Integer2(int massKg)
            => massKg / 1000;
        public int Integer3(int bytesCount)
            => bytesCount / 1024;
        public uint Integer4(uint lineLenght, uint cutLenght)
            => lineLenght / cutLenght;
        public uint Integer5(uint lineLenght, uint cutLenght)
            => lineLenght % cutLenght;
        public (int, int) Integer6(int num)
            => (num / 10, num % 10);
        public (int, int) Integer7(int num)
            => (num % 10 + num / 10, num % 10 * num / 10);
        public uint Integer8(uint num)
            => num % 10 * 10 + num / 10;
        public int Integer9(int num)
            => num / 100;
        public (int, int) Integer10(int num)
            => (num % 10, num / 10 % 10);
        public (int, int) Integer11(int num)
            => (num / 100 + num % 10 + num / 10 % 10, 
            (num / 100) * (num % 10) * (num / 10 % 10));
        public int Integer12(int num)
            => num / 100 + num % 10 * 100 + num % 100 / 10 * 10;
        public int Integer13(int num)
            => num % 100 * 10 + num / 100;
        public int Integer14(int num)
            => num / 10 + num % 10 * 100;
        public int Integer15(int num)
            => num % 10 +  num / 100 * 10 + num / 10 % 10 * 100;
        public int Integer16(int num)
            => num / 100 * 100 + num % 100 / 10 + num % 10 * 10;
        public int Integer17(int num)
            => num / 100 % 10;
        public int Integer18(int num)
            => num / 1000;
        public int Integer19(int seconds)
            => seconds / 60;
        public int Integer20(int seconds)
            => seconds / (60 * 60);
        public int Integer21(int seconds)
            => seconds - 60;
        public int Integer22(int seconds)
            => seconds - 60 * 60;
        public int Integer23(int seconds)
            => (seconds - 60 * 60) / 60;
        public int Integer24(int day)
            => day % 7;
        public int Integer25(int day)
            => (day + 2) % 7;
        public int Integer26(int day)
            => (day + 1) % 7;
        public int Integer27(int day)
            => (day + 5) % 7;
        public int Integer28(int day, int weekDay)
            => (day + weekDay - 1) % 7;
        public uint Integer29(uint A, uint B, uint C)
            => (A / C) * (B / C);
        public int Integer30(int year)
            => year / 100 + (year % 100 == 0 ? 0 : 1);
    }
}
