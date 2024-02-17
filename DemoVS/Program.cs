// Configura��o Builder 

using DemoVS;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipeline

// Middlewares
// Services

// Configura��o da App

var app = builder.Build();

app.UseMiddleware<LogTemplateMiddleware>();

// Configura��o de Comportamentos da App

app.MapGet("/", () => "Hello World!");

app.Map("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
