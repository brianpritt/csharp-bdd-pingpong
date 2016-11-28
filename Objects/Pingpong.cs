using System.Collections.Generic;

namespace Pingpong
{
  public class PingpongGenerator
  {
    private int _upperLimit;

    public PingpongGenerator(int input)
    {
      _upperLimit = input;
    }
    public List<int> CreateList()
    {
      List<int> _pingsAndPongs = new List<int>{};
      for (int i=1; i<=_upperLimit; i++)
      {
        _pingsAndPongs.Add(i);
      }
      return _pingsAndPongs;
    }
  }
}
