using System;
using System.Collections.Generic;

namespace OpenGamingSystem.Entities.Wallet
{
  public class UserWalletModel
  {
    public int UserId { get; set; }

    public Decimal Balance { get; set; }

    public string Currency { get; set; }

    public List<BonusProductModel> UserBonuses { get; set; }
  }
}
