namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int id = i;

                new Thread(() =>
                {
                    while (true)
                    {
                        Console.WriteLine($"Reader {id}: {Server.GetCount()}");
                        Thread.Sleep(500);
                    }
                }).Start();
            }

            new Thread(() =>
            {
                int value = 0;
                while (true)
                {
                    value++;
                    Server.AddToCount(value);
                    Console.WriteLine($"Writer: {value}");
                    Thread.Sleep(1000);
                }
            }).Start();

        }
    }
}
