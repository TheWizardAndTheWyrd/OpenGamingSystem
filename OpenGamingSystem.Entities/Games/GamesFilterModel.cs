namespace OpenGamingSystem.Entities.Games
{
  public class GamesFilterModel
  {
    public string Category { get; set; }

    public int Sort { get; set; }

    public int Device { get; set; }

    public string Country { get; set; }

    public string SearchString { get; set; }

    public bool IsMinigame { get; set; }

    public string Language { get; set; }

    public string CurrencyCode { get; set; }
  }
}
