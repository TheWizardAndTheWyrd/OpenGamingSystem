using System;

namespace OpenGamingSystem.Entities.Authentication
{
  public class ForgotPasswordChangeModel
  {
    public Guid RecoveryCode { get; set; }

    public string Password { get; set; }
  }
}
