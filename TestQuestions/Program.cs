using Question1;

namespace Questions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aaabbcccdde";

            var outputString = CompressionManager.Compress(inputString);
            Console.WriteLine(outputString);
        }
    }
}
