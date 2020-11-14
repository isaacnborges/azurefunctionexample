using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;

namespace isaacnborges.Function
{
    public static class Function1
    {
        [FunctionName("FunctionExample")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var environment = Environment.GetEnvironmentVariable("EnvironmentExample");

            var responseMessage = $"Hello from {environment}";

            return new OkObjectResult(responseMessage);
        }
    }
}
