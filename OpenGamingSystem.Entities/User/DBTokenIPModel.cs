using System;

namespace OpenGamingSystem.Entities.User
{
  public class DBTokenIPModel
  {
    public string ForwardedFor { get; set; }

    public string Country { get; set; }

    public Guid Token { get; set; }

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastAccess { get; set; }

    public bool IsInvalidated { get; set; }

    public int? AdminUserId { get; set; }
  }
}
