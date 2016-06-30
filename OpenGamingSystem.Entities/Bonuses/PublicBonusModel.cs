using System;
using System.Collections.Generic;

namespace OpenGamingSystem.Entities.Bonuses
{
  public class PublicBonusModel
  {
    public int BonusId { get; set; }

    public int TypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string Period { get; set; }

    public bool Enabled { get; set; }

    public string TermsLink { get; set; }

    public bool ManualBonus { get; set; }

    public bool MaxBetOn { get; set; }

    public bool IncludeInList { get; set; }

    public List<string> PromoCodes { get; set; }

    public BonusTypeModel BonusTypeDetails { get; set; }
  }
}
