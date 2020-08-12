using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace Gæt_et_tal_spil
{
    public class Timer
    {
        public static Task CreateWriteTimer(int seconds, int numberOfRepeats, string text)
        {
            Task task = new Task(() =>
            {
                for (int i = 0; i < numberOfRepeats; i++)
                {
                    Task.Delay(seconds * 1000).Wait();
                    Console.WriteLine(text);
                }
            });
            task.Start();
            return task;
        }
    }
}
