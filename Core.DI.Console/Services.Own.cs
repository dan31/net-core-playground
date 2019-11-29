using Microsoft.Extensions.Logging;

public class BarService : IBarService
{
  private readonly IFooService _fooService;
  private readonly ILogger<BarService> _logger;
  public BarService(ILoggerFactory loggerFactory, IFooService fooService)
  {
    _fooService = fooService;
    _logger = loggerFactory.CreateLogger<BarService>();
  }

  public void DoSomeRealWork()
  {
    for (int i = 0; i < 10; i++)
    {
      _fooService.DoThing(i);
      _logger.LogInformation($"Ha ha here {i}");
    }
  }
}

public class FooService : IFooService
{
  private readonly ILogger<FooService> _logger;
  public FooService(ILoggerFactory loggerFactory)
  {
    _logger = loggerFactory.CreateLogger<FooService>();
  }

  public void DoThing(int number)
  {
    _logger.LogInformation($"Doing the thing {number}");
  }
}