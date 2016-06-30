using System;

namespace OpenGamingSystem.Entities.Promotions
{
  public class PromotionModel
  {
    public int PromotionId { get; set; }

    public string ImageURL { get; set; }

    public string Country { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public int Ordering { get; set; }

    public DateTime Created { get; set; }

    public DateTime GoLive { get; set; }

    public DateTime? Expires { get; set; }

    public int? ProductId { get; set; }

    public string TermsUrl { get; set; }

    public bool Featured { get; set; }
  }
}
