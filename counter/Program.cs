namespace counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        counter counter = new counter();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        // ska skriva ut 3
        Console.WriteLine("counter: " + counter.GetValue());
        counter.Reset();
        // ska skriva ut 0
        Console.WriteLine("counter: " + counter.GetValue());
    }
    }
}