using System;

namespace OpenGamingSystem.Entities.Bonuses
{
  public class FrontUserFreeSpins
  {
    public long UserFreeSpinsId { get; set; }

    public int UserId { get; set; }

    public int BonusId { get; set; }

    public string BonusName { get; set; }

    public int VendorId { get; set; }

    public DateTime DateCreated { get; set; }
  }
}
