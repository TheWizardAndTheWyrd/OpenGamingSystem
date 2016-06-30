namespace OpenGamingSystem.Entities.Bonuses
{
  public class BonusTypeModel
  {
    public int TypeId { get; set; }

    public int ProductId { get; set; }

    public string Type { get; set; }

    public string Description { get; set; }

    public bool Enabled { get; set; }

    public int Priority { get; set; }

    public string ControllerPath { get; set; }

    public bool UniqueBonusCode { get; set; }

    public bool ShowBonusCode { get; set; }
  }
}
