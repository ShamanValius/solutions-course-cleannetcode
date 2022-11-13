using MyRealizationNotion;

Console.WriteLine("Hello, World!");

var stoppingTokenSource = new CancellationTokenSource();
Console.CancelKeyPress += (sender, e) => stoppingTokenSource.Cancel();

var app = new Application();
app.Run(stoppingTokenSource.Token);
