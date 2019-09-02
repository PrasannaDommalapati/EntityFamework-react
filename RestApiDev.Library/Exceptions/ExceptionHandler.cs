using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RestApiDev.Library.Exceptions
{
    public class ExceptionHandler
    {

        private readonly RequestDelegate Request;

        public Func<HttpResponse, string, CancellationToken, Task> WriteAsync { get; set; }

        public ExceptionHandler(RequestDelegate request)
        {
            Request = request.ValidateForNotNull();
            WriteAsync = HttpResponseWritingExtensions.WriteAsync;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await Request(context).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

