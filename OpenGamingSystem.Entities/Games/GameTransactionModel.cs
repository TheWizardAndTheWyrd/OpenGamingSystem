using System;

namespace OpenGamingSystem.Entities.Games
{
  public class GameTransactionModel
  {
    public string ActivityId { get; set; }

    public DateTime Date { get; set; }

    public string Game { get; set; }

    public string Vendor { get; set; }

    public string Currency { get; set; }

    public string ActivityType { get; set; }

    public Decimal Bet { get; set; }

    public Decimal Win { get; set; }

    public Decimal WalletAmount { get; set; }

    public Decimal BonusAmount { get; set; }

    public string Bonus { get; set; }
  }
}
