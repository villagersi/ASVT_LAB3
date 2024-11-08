using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    public interface ICountdownTimer
    {
        Task CountdownTimerAsync(string name, int seconds, CancellationToken token);
    }
}
