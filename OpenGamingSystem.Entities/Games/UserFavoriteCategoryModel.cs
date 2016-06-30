using System;

namespace OpenGamingSystem.Entities.Games
{
  public class UserFavoriteCategoryModel
  {
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }
  }
}
