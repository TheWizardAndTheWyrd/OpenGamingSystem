namespace OpenGamingSystem.Entities.Authentication
{
  public class ChangeSecurityQuestionModel
  {
    public string Password { get; set; }

    public int SecurityQuestionId { get; set; }

    public string SecurityAnswer { get; set; }
  }
}
