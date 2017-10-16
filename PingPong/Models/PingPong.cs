namespace PingPong
{
  public class PingPong
  {

    public bool IsPingPong(int ping)
    {
      if (ping % 15 == 0)
      {
        return true;
    }
    else if (ping % 5 == 0)
    {
      return true;
    }
    else if (ping % 3 == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
}
