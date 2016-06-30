using System;

namespace OpenGamingSystem.Entities.Games
{
  public class GameJackpotModel
  {
    public int GameId { get; set; }

    public string GameName { get; set; }

    public string Vendor { get; set; }

    public string CurrencyFormat { get; set; }

    public string CurrencyCode { get; set; }

    public Decimal Amount { get; set; }

    public string JackpotId { get; set; }
  }
}
