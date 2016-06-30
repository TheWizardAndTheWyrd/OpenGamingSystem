namespace OpenGamingSystem.Entities.ResponsibleGaming
{
  public class SelfExclusionCategoryModel
  {
    public int Id { get; set; }

    public int PeriodDurationId { get; set; }

    public bool IsVisible { get; set; }

    public int GracePeriodDurationId { get; set; }

    public int GraceEffectiveDurationId { get; set; }

    public int MaxUsageTime { get; set; }
  }
}
