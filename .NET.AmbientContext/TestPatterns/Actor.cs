using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreatLibrary.GL;

namespace TestPatterns
{
  public class Actor : GreatLibrary.BaseActor
  {
    public void Act(double z)
    {
      Console.WriteLine($"{RootFinder.Find(z)}");
    }

    public Actor() : base(null) { }
    public Actor(GreatLibrary.IRootFinder root_finder) : base(root_finder) { }
  }
}
