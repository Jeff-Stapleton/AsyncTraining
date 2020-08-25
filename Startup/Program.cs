using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Startup
{
    public static class Program
    {
        private static readonly string[] Words = {"Async", "can", "sometimes", "be", "a", "little", "tricky."};
        private static readonly Random Random = new Random(DateTime.Now.Second);
        private const int MaxPause = 4000;

        public static void Main(string[] args)
        {
            StartupDemo().Wait();

            Console.ReadKey();
        }

        private static async Task StartupDemo()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            OutputSentence(0);
            OutputSentence(1);
            OutputSentence(2);
            OutputSentence(3);
            OutputSentence(4);
            OutputSentence(5);
            OutputSentence(6);

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }

        private static async Task OutputSentence(int index)
        {
            await Task.Delay(Random.Next(500, MaxPause));

            Console.Write($"{Words[index]} ");
        }
    }
}