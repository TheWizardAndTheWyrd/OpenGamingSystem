using System;

namespace OpenGamingSystem.Entities.User
{
  public class UserObjectModel
  {
    public int? RegistrationVerificationTypeId { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string PasswordSalt { get; set; }

    public string Email { get; set; }

    public string Title { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public DateTime Birthdate { get; set; }

    public string MobilePrefix { get; set; }

    public string Mobile { get; set; }

    public string PhonePrefix { get; set; }

    public string Phone { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public int CountryId { get; set; }

    public string PostalCode { get; set; }

    public int SecurityQuestionId { get; set; }

    public string SecurityAnswerSalt { get; set; }

    public string SecurityAnswer { get; set; }

    public bool AllowsNewsAndOffers { get; set; }

    public bool AllowsNewsAndOffersSMS { get; set; }

    public string SignupIP { get; set; }

    public string LanguageCode { get; set; }

    public string SecurityQuestion { get; set; }

    public int LanguageId { get; set; }

    public int CurrencyId { get; set; }

    public int GamMatrixUserId { get; set; }

    public DateTime Created { get; set; }

    public Guid? EmailGUId { get; set; }

    public string Reference { get; set; }

    public int LoginTries { get; set; }

    public DateTime? LoginTryCoolDown { get; set; }

    public string PreferredLanguage { get; set; }

    public bool KYC { get; set; }

    public bool IsBlocked { get; set; }

    public bool GamemodeVisible { get; set; }

    public bool TrackFirstDeposit { get; set; }

    public DateTime? AccountVerifiedOn { get; set; }

    public bool? KYCIdApproved { get; set; }

    public bool? KYCAddressApproved { get; set; }

    public bool? KYCPaymentApproved { get; set; }

    public bool IsSuperAdmin { get; set; }

    public bool? KYCVerifiedBefore { get; set; }

    public Guid ChatGUId { get; set; }

    public int DepositCount { get; set; }

    public DateTime? LastDepositDate { get; set; }
  }
}
