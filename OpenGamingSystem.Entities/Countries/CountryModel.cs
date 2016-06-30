using System;

namespace OpenGamingSystem.Entities.Countries
{
  public class CountryModel
  {
    public int CountryId { get; set; }

    public string Name { get; set; }

    public string AlphaCode2 { get; set; }

    public string AlphaCode3 { get; set; }

    public int NumericCode { get; set; }

    public string PhoneCode { get; set; }

    public int CurrencyId { get; set; }

    public int MinimumSignupAge { get; set; }

    public bool IsLive { get; set; }

    public DateTime Created { get; set; }

    public bool IsExcluded { get; set; }

    public bool IsFeatured { get; set; }

    public Decimal KycLimit { get; set; }

    public int DefaultLanguageId { get; set; }
  }
}
