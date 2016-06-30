using System;

namespace OpenGamingSystem.Entities.Translations
{
  public class TranslationModel
  {
    public int TranslationId { get; set; }

    public string Language { get; set; }

    public string Path { get; set; }

    public string Code { get; set; }

    public string Translation { get; set; }

    public DateTime Created { get; set; }

    public DateTime LastChanged { get; set; }
  }
}
