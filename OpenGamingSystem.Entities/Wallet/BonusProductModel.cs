using System.Collections.Generic;

namespace OpenGamingSystem.Entities.Wallet
{
  public class BonusProductModel
  {
    public string ProductName { get; set; }

    public List<UserBonusModel> Bonuses { get; set; }
  }
}
