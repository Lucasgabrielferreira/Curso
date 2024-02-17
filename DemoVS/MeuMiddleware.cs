using Serilog;
using System.Diagnostics;

namespace DemoVS
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;

        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Faz algo antes

            // Chama o próximo middleware no pipeline

            await _next(httpContext);

            // Faz algo depois
        }
    }

    public class LogTemplateMiddleware
    {
        private readonly RequestDelegate _next;

        public LogTemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Faz algo antes

            var SW = Stopwatch.StartNew();

            // Chama o próximo middleware no pipeline

            await _next(httpContext);

            SW.Stop();


            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"A execução demorou {SW.Elapsed.TotalMilliseconds}ms ({SW.Elapsed.TotalSeconds} segundos)");
            // Faz algo depois
        }
    }
}
