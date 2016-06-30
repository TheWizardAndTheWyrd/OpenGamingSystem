using System;

namespace OpenGamingSystem.Entities.Notices
{
  public class NoticeModel
  {
    public int Id { get; set; }

    public int NoticeTypeId { get; set; }

    public int LanguageId { get; set; }

    public string Message { get; set; }

    public DateTime FromTime { get; set; }

    public DateTime ToTime { get; set; }

    public bool IsLive { get; set; }

    public string ImageURL { get; set; }

    public string ClickURL { get; set; }
  }
}
