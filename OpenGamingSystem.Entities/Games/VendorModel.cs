namespace OpenGamingSystem.Entities.Games
{
  public class VendorModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string TypeName { get; set; }

    public VendorType VendorType { get; set; }
  }
}
