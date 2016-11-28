using Xunit;
using System.Collections.Generic;
namespace Pingpong
{
  public class PingpongTest
  {
    [Fact]
    public void PingpongGenerator_ListCreation_true()
    {
      //Arrange
      int input = 2;
      List<int> expectedList = new List<int>{1, 2};
      PingpongGenerator TestClass = new PingpongGenerator(2);

      //Act
      List<int> result = TestClass.CreateList();

      //Assert
      Assert.Equal(expectedList, result);
    }
  }
}
