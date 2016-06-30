using System;

namespace OpenGamingSystem.Entities.User
{
  public class KYCLinkedObjectModel
  {
    public int KycId { get; set; }

    public int UserId { get; set; }

    public int TypeId { get; set; }

    public string Path { get; set; }

    public int Status { get; set; }

    public string ReasonText { get; set; }

    public string StatusMessage { get; set; }

    public string Expires { get; set; }

    public DateTime? DateUploaded { get; set; }

    public DateTime? DateVerified { get; set; }

    public int LastModifiedBy { get; set; }

    public DateTime? DateLastModified { get; set; }

    public DateTime DateCreated { get; set; }

    public string KycTypeName { get; set; }

    public string HelpText { get; set; }

    public bool ShowToUser { get; set; }

    public bool NeedUserAction { get; set; }

    public string StatusText { get; set; }
  }
}
