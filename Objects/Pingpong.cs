using System.Collections.Generic;
using System;

namespace Pingpong
{
  public class PingpongGenerator
  {
    private int _upperLimit;

    public PingpongGenerator(int input)
    {
      _upperLimit = input;
    }
    public List<string> CreateList()
    {
      List<string> _pingsAndPongs = new List<string>{};
      for (int i=1; i<=_upperLimit; i++)
      {
        if (i % 3 == 0)
        {
        _pingsAndPongs.Add("ping");
        }
        else
        {
          _pingsAndPongs.Add(i.ToString());
        }
      }
      return _pingsAndPongs;
    }
  }
}
