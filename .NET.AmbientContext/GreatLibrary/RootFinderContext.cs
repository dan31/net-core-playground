using System;

namespace GreatLibrary
{
  public class RootFinderContext
  {
    private static readonly RootFinderContext instance = new RootFinderContext();
    public IRootFinder RootFinder { get; private set; }
    private RootFinderContext()
    {
      RootFinder = new DefaultRootFinder();
    }
    public static RootFinderContext GetInstance()
    {
      return instance;
    }
    public void SetRootFinder(IRootFinder root_finder)
    {
      if (root_finder != null)
      {
        RootFinder = root_finder;
      }
    }
  }

  namespace GL
  {
    public static class GL
    {
      public static IRootFinder RootFinder { get { return RootFinderContext.GetInstance().RootFinder; } }
      public static RootFinderContext Context { get { return RootFinderContext.GetInstance(); } }
    }
  }
}