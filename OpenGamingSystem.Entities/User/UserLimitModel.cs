using System;

namespace OpenGamingSystem.Entities.User
{
  public class UserLimitModel
  {
    public int Id { get; set; }

    public LimitType LimitType { get; set; }

    public LimitDuration Duration { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Decimal Amount { get; set; }
  }
}
