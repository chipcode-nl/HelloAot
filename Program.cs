using System.Diagnostics;

var stopwatch = Stopwatch.StartNew();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Start();
stopwatch.Stop();
Console.WriteLine($"start time {stopwatch.ElapsedMilliseconds} ms");

app.WaitForShutdown();
Console.WriteLine("stopped");
