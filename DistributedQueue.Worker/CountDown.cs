using DistributedQueue.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class CountDown : ICountdownTimer
    {
        public Task CountdownTimerAsync(string name, int seconds, CancellationToken token)
        {
            var startTime = DateTime.Now;

            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"Compute task: {name}, {i}");
                System.Threading.Thread.Sleep(1000);

                if (token.IsCancellationRequested)
                {
                Console.WriteLine($"{DateTime.Now}: Cancelled compute: {name}");
                break;
                }
            }

            Console.WriteLine($"Compute Completed! ----> CountDownTimer: Task Number {name}");
            return Task.CompletedTask;
        }
    }
}
