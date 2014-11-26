using System;
using System.IO;
using System.Threading.Tasks;

namespace AwaitInCatchFinallyBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            //Before C# 6.0
            try
            {
                Stream s = new FileStream("test.txt", FileMode.Open);
            }
            catch
            {
                Logger.LogAsync("Exception occured while opening file").Wait();
            }
            finally
            {
                Logger.LogAsync("Operation rolled back").Wait();
            }

            //After C# 6.0
            try
            {
                Stream s = new FileStream("test.txt", FileMode.Open);
            }
            catch
            {
                await Logger.LogAsync("Exception occured while opening file");
            }
            finally
            {
                await Logger.LogAsync("Operation rolled back");
            }
        }
    }

    public class Logger
    {
        public static Task LogAsync(string message)
        {
            Console.WriteLine(message);
            return Task.CompletedTask;
        }
    }
}
