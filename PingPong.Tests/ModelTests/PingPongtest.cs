using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(16));
    }

  }
}
