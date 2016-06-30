namespace OpenGamingSystem.Entities.Games
{
  public class GameCategoryModel
  {
    public int Id { get; set; }

    public string DisplayName { get; set; }

    public int OrderNumber { get; set; }

    public bool IsSelected { get; set; }

    public bool Visible { get; set; }

    public int LanguageId { get; set; }

    public string Tag { get; set; }

    public string LanguageCode { get; set; }

    public int SelectableId { get; set; }

    public string ImageURL { get; set; }
  }
}
