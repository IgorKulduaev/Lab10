Console.Write("Введите часы: ");
int hours = int.Parse(Console.ReadLine()!);
Console.Write("Введите минуты: ");
int minutes = int.Parse(Console.ReadLine()!);
Console.Write("Введите секунды: ");
int seconds = int.Parse(Console.ReadLine()!);
Console.Write("Введите Фамилию: ");
string surname = Console.ReadLine()!;
Console.Write("Введите оператора: ");
string oper = Console.ReadLine()!;
//Time vreme = new Time(hours, minutes, seconds);
//vreme.Print();
TimeChild call = new TimeChild(hours, minutes, seconds, surname, oper);
call.lgota();

public class Time
{
    protected int hours;
    protected int minutes;
    protected int seconds;

    public Time(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.Seconds = seconds;
    }
    public int Hours
    {
        get => hours;
        set => hours = (value >= 0 || value < 24) ? value : 0;
    }

    public int Minutes
    {
        get => minutes;
        set => minutes = (value >= 0 || value < 60) ? value : 0;
    }

    public int Seconds
    {
        get => seconds;
        set => seconds = (value >= 0 || value < 60) ? value : 0;
    }

    public int TotalMinutes()
    {
        return hours * 60 + minutes;
    }

    public void tenMinutes()
    {

        int allMinutes = hours * 60 + minutes;
        allMinutes -= 10;

        if (allMinutes < 0)
            allMinutes += 24 * 60;

        hours = (allMinutes / 60) % 24;
        minutes = allMinutes % 60;
    }

    public void Print()
    {
        Console.WriteLine($"Время: {hours:D2}:{minutes:D2}:{seconds:D2}");
        Console.WriteLine($"Количество полных минут: {TotalMinutes()}");

        tenMinutes();
        Console.WriteLine($"Уменьшение на 10 мин: {hours:D2}:{minutes:D2}:{seconds:D2}");

    }
}
    class TimeChild : Time
    {
        private string surname;
        private string oper;

        public TimeChild(int hours, int minutes, int seconds, string _surname, string _oper)
            : base(hours, minutes, seconds)
        {
            this.surname = _surname;
            this.oper = _oper;
        }

        public void lgota()
        {
            if (hours < 8)
                Console.WriteLine("Ваше время является льготным");
            else
                Console.WriteLine("Ваше время НЕ является льготным");
        }

    }
