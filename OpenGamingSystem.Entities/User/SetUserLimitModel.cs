using System;

namespace OpenGamingSystem.Entities.User
{
  public class SetUserLimitModel
  {
    public int UserId { get; set; }

    public LimitType Type { get; set; }

    public LimitDuration Duration { get; set; }

    public Decimal LimitAmount { get; set; }
  }
}
