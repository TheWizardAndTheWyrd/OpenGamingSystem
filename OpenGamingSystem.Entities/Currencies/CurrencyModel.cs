using System;

namespace OpenGamingSystem.Entities.Currencies
{
  public class CurrencyModel
  {
    public int CurrencyId { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public int Multiplier { get; set; }

    public string Format { get; set; }

    public Decimal ExchangeRate { get; set; }

    public Decimal MaxBetLimit { get; set; }
  }
}
