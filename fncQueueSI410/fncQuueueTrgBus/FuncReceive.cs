using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace fncQuueueTrgBus
{
    public static class FuncReceive
    {
        [FunctionName("FuncReceive")]
        public static void Run([ServiceBusTrigger("qprueba", Connection = @"ServiceBusConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
