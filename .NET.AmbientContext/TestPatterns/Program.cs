using System;
using GreatLibrary.GL;

namespace TestPatterns
{
  class OwnRootFinder : GreatLibrary.IRootFinder
  {
    int precision;
    public OwnRootFinder(int precision = 4) { this.precision = precision; }
    public double Find(double a)
    {
      double x = 1;
      for (int i = 0; i < precision; ++i)
      {
        x = 0.5 * (x + a / x);
      }
      return x;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      GL.Context.SetRootFinder(new OwnRootFinder(4));
      var actor = new Actor(new OwnRootFinder(2));
      actor.Act(16);
    }
  }
}
