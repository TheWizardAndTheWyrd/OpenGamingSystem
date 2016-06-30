namespace OpenGamingSystem.Entities.Authentication
{
  public class VerifyUserBySMSModel
  {
    public string MobilePrefix { get; set; }

    public string Mobile { get; set; }

    public string MobileVerificationCode { get; set; }
  }
}
