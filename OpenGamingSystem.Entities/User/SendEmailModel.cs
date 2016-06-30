using System.Collections.Generic;

namespace OpenGamingSystem.Entities.User
{
  public class SendEmailModel
  {
    public int EmailTemplateId { get; set; }

    public string SendEmailTo { get; set; }

    public Dictionary<string, string> EmailBodyPlaceholderValues { get; set; }

    public string LanguageCode { get; set; }
  }
}
