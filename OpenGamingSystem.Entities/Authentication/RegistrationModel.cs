using System;

namespace OpenGamingSystem.Entities.Authentication
{
  public class RegistrationModel
  {
    public int VerificationTypeId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public int SexId { get; set; }

    public string Title { get; set; }

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

    public string MobileVerificationCode { get; set; }

    public string PhonePrefix { get; set; }

    public string Phone { get; set; }

    public int SecurityQuestionId { get; set; }

    public string SecurityAnswer { get; set; }

    public int CurrencyId { get; set; }

    public bool AllowsNewsAndOffers { get; set; }

    public bool AllowsNewsAndOffersSMS { get; set; }

    public string Reference { get; set; }

    public string UrlReferrer { get; set; }

    public string IdentityGuid { get; set; }

    public string UserAgent { get; set; }

    public string AffiliateSourceId { get; set; }

    public string AffiliateClientUUId { get; set; }

    public RegistrationAdditionalData UserAdditionalFields { get; set; }
  }
}
