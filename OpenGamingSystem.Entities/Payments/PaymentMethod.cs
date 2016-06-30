using System;

namespace OpenGamingSystem.Entities.Payments
{
  public class PaymentMethod : PaymentType
  {
    public int PaymentMethodId { get; set; }

    public string PaymentTypeId { get; set; }

    public string Image { get; set; }

    public bool IsDeposit { get; set; }

    public bool IsLive { get; set; }

    public new DateTime Created { get; set; }

    public DateTime LastEdited { get; set; }

    public int CreatedBy { get; set; }

    public int LastEditedBy { get; set; }

    public int Sort { get; set; }

    public string Description { get; set; }

    public bool CallExternalPaymentFunction { get; set; }

    public bool ReturnJson { get; set; }

    public int ExternalPaymentFrameWidth { get; set; }

    public int ExternalPaymentFrameHeight { get; set; }

    public int ExternalPaymentFrameTop { get; set; }

    public string PaymentMethodCode { get; set; }
  }
}
