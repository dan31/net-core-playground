using System;

namespace GreatLibrary
{
  public interface IRootFinder
  {
    public double Find(double x);
  }

  public class DefaultRootFinder : IRootFinder
  {
    public double Find(double x) { return Math.Sqrt(x); }
  }
}
