using System.Collections.Generic;

namespace OpenGamingSystem.Entities.Bonuses
{
  public class FrontAllUserBonuses
  {
    public List<FrontEndUserBonusObject> UserBonuses { get; set; }

    public List<FrontUserFreeSpins> ClaimedFreeSpins { get; set; }
  }
}
