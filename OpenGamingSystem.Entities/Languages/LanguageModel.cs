using System;

namespace OpenGamingSystem.Entities.Languages
{
  public class LanguageModel
  {
    public int LanguageId { get; set; }

    public string Alpha2Code { get; set; }

    public string Alpha3Code { get; set; }

    public string Language { get; set; }

    public bool IsLive { get; set; }

    public string LCId { get; set; }

    public DateTime Created { get; set; }

    public string FlagURL { get; set; }
  }
}
