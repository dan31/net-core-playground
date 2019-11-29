using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
  static void Main(string[] args)
  {
    var serviceProvider = new ServiceCollection()
      .AddSingleton<ILoggerFactory, LoggerFactory>()
      .AddLogging(loggingBuilder => loggingBuilder
        .AddConsole()
        .AddDebug()
        .SetMinimumLevel(LogLevel.Debug))
      .AddSingleton<IFooService, FooService>()
      .AddSingleton<IBarService, BarService>()
      .BuildServiceProvider();

    var logger = serviceProvider
        .GetRequiredService<ILoggerFactory>()
        .CreateLogger<Program>();
    logger.LogDebug($"Starting application");

    var bar = serviceProvider.GetService<IBarService>();
    bar.DoSomeRealWork();
    logger.LogDebug("All done!");
  }
}