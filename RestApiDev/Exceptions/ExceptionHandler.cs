using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace RestApiDev.Exceptions
{
    public class ExceptionHandler
    {

        private readonly RequestDelegate next;

        public Func<HttpResponse, string, CancellationToken, Task> WriteAsync { get; set; }

        public ExceptionHandler(RequestDelegate next)
        {
            this.next = next ?? throw new ArgumentNullException(nameof(next));
            WriteAsync = HttpResponseWritingExtensions.WriteAsync;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

