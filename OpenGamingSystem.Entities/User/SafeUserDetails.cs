using System;

namespace OpenGamingSystem.Entities.User
{
  public class SafeUserDetails
  {
    public int UserId { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public int SexId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string PostalCode { get; set; }

    public string City { get; set; }

    public int CountryId { get; set; }

    public int LanguageId { get; set; }

    public string MobilePrefix { get; set; }

    public string Mobile { get; set; }

    public string PhonePrefix { get; set; }

    public int SecurityQuestionId { get; set; }

    public int CurrencyId { get; set; }

    public bool AllowsNewsAndOffers { get; set; }

    public bool AllowsNewsAndOffersSMS { get; set; }

    public string Reference { get; set; }

    public int? PreferredLanguageId { get; set; }

    public string CountryCode { get; set; }

    public string Language { get; set; }

    public string Currency { get; set; }

    public string PrefLanguage { get; set; }

    public bool GamemodeVisible { get; set; }

    public DateTime? AcceptedTermsOn { get; set; }

    public SafeUserAdditionalFields AdditionalFields { get; set; }
  }
}
