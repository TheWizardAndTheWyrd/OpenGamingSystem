using System;

namespace OpenGamingSystem.Entities.Games
{
  public class RecentWinnersModel
  {
    public string UserName { get; set; }

    public string Currency { get; set; }

    public int GameId { get; set; }

    public string GameName { get; set; }

    public Decimal Win { get; set; }

    public Decimal BaseWin { get; set; }

    public string GameSlug { get; set; }

    public DateTime Date { get; set; }
  }
}
