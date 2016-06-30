using System;

namespace OpenGamingSystem.Entities.Games
{
  public class RecentWinnersRequestModel
  {
    public int Count { get; set; }

    public Decimal MinimumWin { get; set; }

    public int? GameId { get; set; }
  }
}
