namespace OpenGamingSystem.Entities.Banners
{
  public class BannerModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public string ButtonLoggedInText { get; set; }

    public string ButtonLoggedOutText { get; set; }

    public string BannerImageURL { get; set; }

    public string BannerClickURL { get; set; }

    public string BannerStyle { get; set; }

    public string BannerClickTarget { get; set; }

    public string ButtonLoggedInClickURL { get; set; }

    public string ButtonLoggedInStyle { get; set; }

    public string ButtonLoggedInXPosition { get; set; }

    public string ButtonLoggedInYPosition { get; set; }

    public string ButtonLoggedOutClickURL { get; set; }

    public string ButtonLoggedOutClickTarget { get; set; }

    public string ButtonLoggedOutStyle { get; set; }

    public string ButtonLoggedOutXPosition { get; set; }

    public string ButtonLoggedOutYPosition { get; set; }

    public bool Featured { get; set; }

    public int DrawOrder { get; set; }

    public string HTML { get; set; }
  }
}
