// Configuração Builder 

using DemoVS;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

// Middlewares
// Services

// Configuração da App

var app = builder.Build();

app.UseMiddleware<LogTemplateMiddleware>();

// Configuração de Comportamentos da App

app.MapGet("/", () => "Hello World!");

app.Map("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
