using System;

namespace OpenGamingSystem.Entities.Pages
{
  public class PageModel
  {
    public int PageId { get; set; }

    public string Name { get; set; }

    public string ShortTitle { get; set; }

    public DateTime Created { get; set; }

    public string Title { get; set; }

    public string Tag { get; set; }

    public bool Live { get; set; }

    public string ListOrder { get; set; }

    public string LinkURL { get; set; }

    public bool NewWindow { get; set; }

    public bool CanPrint { get; set; }

    public bool FullWidth { get; set; }

    public string MasterPage { get; set; }
  }
}
