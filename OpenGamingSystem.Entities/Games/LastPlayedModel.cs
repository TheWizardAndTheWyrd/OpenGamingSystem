using System;

namespace OpenGamingSystem.Entities.Games
{
  public class LastPlayedModel
  {
    public int Id { get; set; }

    public int GameId { get; set; }

    public DateTime Created { get; set; }
  }
}
