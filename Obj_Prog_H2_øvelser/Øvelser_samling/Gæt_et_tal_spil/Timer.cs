using System;
using System.Collections.Generic;
using System.Threading;
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
                int TimeLeft = 10;

                for (int i = 0; i < numberOfRepeats; i++)
                {
                    Task.Delay(seconds * 1000).Wait();
                    Console.WriteLine(text + TimeLeft--);

                    if(TimeLeft == 0) 
                    {
                        Console.WriteLine("Du er for langsom og tabte");
                        Environment.Exit(0);
                    }
                }
            });
            task.Start();
            return task;
        }

        // Cancelation forsøg
        static async Task Main()
        {
            var tokenSource2 = new CancellationTokenSource();
            CancellationToken ct = tokenSource2.Token;

            var task = Task.Run(() =>
            {
                // Were we already canceled?
                ct.ThrowIfCancellationRequested();

                bool moreToDo = true;
                while (moreToDo)
                {
                    // Poll on this property if you have to do
                    // other cleanup before throwing.
                    if (ct.IsCancellationRequested)
                    {
                        // Clean up here, then...
                        ct.ThrowIfCancellationRequested();
                    }
                }
            }, tokenSource2.Token); // Pass same token to Task.Run.

            tokenSource2.Cancel();

            // Just continue on this thread, or await with try-catch:
            try
            {
                await task;
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine($"{nameof(OperationCanceledException)} thrown with message: {e.Message}");
            }
            finally
            {
                tokenSource2.Dispose();
            }

            Console.ReadKey();
        }

    }
}
