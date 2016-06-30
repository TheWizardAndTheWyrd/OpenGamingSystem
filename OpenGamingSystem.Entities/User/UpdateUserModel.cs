namespace OpenGamingSystem.Entities.User
{
  public class UpdateUserModel
  {
    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string PostalCode { get; set; }

    public string City { get; set; }

    public string MobilePrefix { get; set; }

    public string Mobile { get; set; }

    public string PhonePrefix { get; set; }

    public string Phone { get; set; }

    public bool AllowsNewsAndOffers { get; set; }

    public bool AllowsNewsAndOffersSMS { get; set; }
  }
}
