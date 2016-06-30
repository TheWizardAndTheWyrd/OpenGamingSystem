using System.Collections.Generic;

namespace OpenGamingSystem.Entities.Games
{
  public class GameModel
  {
    public int GameId { get; set; }

    public int VendorId { get; set; }

    public string VendorGameId { get; set; }

    public string Name { get; set; }

    public string ShortDescription { get; set; }

    public string Slug { get; set; }

    public int? SuggestedHeight { get; set; }

    public int? SuggestedWidth { get; set; }

    public bool IsNew { get; set; }

    public bool IsLive { get; set; }

    public bool IsHot { get; set; }

    public string Description { get; set; }

    public bool AllowRealPlay { get; set; }

    public bool AllowDemoPlay { get; set; }

    public string Category { get; set; }

    public string GameType { get; set; }

    public string Vendor { get; set; }

    public bool IsMiniGame { get; set; }

    public bool IsParent { get; set; }

    public int? ParentGameId { get; set; }

    public int? ChildSortOrder { get; set; }

    public List<GameModel> ChildGames { get; set; }

    public string ChildGameValue { get; set; }

    public bool InMaintenance { get; set; }

    public bool IsOffline { get; set; }

    public List<GameCategoryFrontModel> Categories { get; set; }

    public GameJackpotModel Jackpot { get; set; }

    public int OrderNumber { get; set; }
  }
}
