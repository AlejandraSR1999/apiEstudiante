using System;
using System.Threading.Tasks;
using asrfncestudiante.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace asrfncestudiante
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task RunAsync(
            [ServiceBusTrigger("colaexamen", Connection = "MyConn")] string myQueueItem,
            [CosmosDB(databaseName: "dbtelemetria", collectionName: "datos", ConnectionStringSetting = "strCosmos")] IAsyncCollector<object> datos,
            ILogger log)
        {
            try
            {
                log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
                var data = JsonConvert.DeserializeObject<Data>(myQueueItem);
                await datos.AddAsync(data);
            }
            catch (Exception e)
            {
                log.LogError($"No fue posible insertar datos: {e.Message}");
            }
        }
    }
}