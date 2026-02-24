using Lab3;

class Program
{
    static void Main(string[] args)
    {
        Triad myDate = new Date(30, 01, 2026);
        Triad myTime = new Time(23, 59, 59);

        Console.WriteLine("До збільшення:");
        Console.WriteLine(myDate);
        Console.WriteLine(myTime);

        myDate.Increase();
        myTime.Increase();

        Console.WriteLine("\nПісля збільшення на 1:");
        Console.WriteLine(myDate);
        Console.WriteLine(myTime);

        Console.ReadKey();
    }
}
