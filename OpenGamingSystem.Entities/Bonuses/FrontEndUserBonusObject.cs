using System;

namespace OpenGamingSystem.Entities.Bonuses
{
  public class FrontEndUserBonusObject
  {
    public string Name { get; set; }

    public string Description { get; set; }

    public string TermsLinks { get; set; }

    public Decimal RealBonusMoney { get; set; }

    public Decimal BonusMoney { get; set; }

    public string Status { get; set; }

    public DateTime DateCreated { get; set; }

    public Decimal WageringAmount { get; set; }

    public Decimal BonusWagering { get; set; }

    public DateTime? WagerBy { get; set; }

    public int BonusId { get; set; }

    public string ProductName { get; set; }

    public long UserBonusId { get; set; }

    public Decimal ForfeitAmount { get; set; }

    public int OpenBets { get; set; }
  }
}
