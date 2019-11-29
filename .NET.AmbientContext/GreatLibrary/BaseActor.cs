using System;

namespace GreatLibrary
{
  public class BaseActor
  {
    private GreatLibrary.IRootFinder root_finder_;
    public GreatLibrary.IRootFinder RootFinder { get { return root_finder_; } }
    public BaseActor() : this(null)
    {
    }
    public BaseActor(GreatLibrary.IRootFinder root_finder)
    {
      if (root_finder != null)
      {
        root_finder_ = root_finder;
      }
      else
      {
        root_finder_ = GreatLibrary.RootFinderContext.GetInstance().RootFinder;
      }
    }
  }
}
