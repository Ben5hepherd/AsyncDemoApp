using System;
using System.Threading.Tasks;

namespace AsyncDemoApp
{
    public class Program
    {
        static void Main()
        {
            Run();
            Console.ReadLine();
        }

        async static void Run()
        {
            Task<int> getRandomNumberTask = GetRandomNumberTask();

            IndependentMethod();

            var randomNumber = await getRandomNumberTask;

            Console.WriteLine($"Random number: {randomNumber}");
        }

        static async Task<int> GetRandomNumberTask()
        {
            await Task.Delay(3000);
            return new Random().Next(0, 1500);
        }

        static void IndependentMethod()
        {
            Console.WriteLine("Please standby...");
        }
    }
}