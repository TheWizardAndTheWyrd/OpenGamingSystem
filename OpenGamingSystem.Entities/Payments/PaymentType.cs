using System;

namespace OpenGamingSystem.Entities.Payments
{
  public class PaymentType
  {
    public int PaymentTypeId { get; set; }

    public string Name { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public Decimal MinAmount { get; set; }

    public Decimal MaxAmount { get; set; }

    public string ProcessingTime { get; set; }

    public bool IsFeePercentage { get; set; }

    public Decimal Fee { get; set; }

    public bool FeeAddedOnRequest { get; set; }

    public Decimal MinFee { get; set; }

    public Decimal MaxFee { get; set; }

    public Decimal MinWithdrawAmount { get; set; }

    public Decimal MaxWithdrawAmount { get; set; }

    public string WithdrawProcessingTime { get; set; }

    public bool IsWithdrawFeePercentage { get; set; }

    public Decimal WithdrawFee { get; set; }

    public Decimal WithdrawMinFee { get; set; }

    public Decimal WithdrawMaxFee { get; set; }

    public int CaptureAfterMinutes { get; set; }

    public bool TwoStepWithdraw { get; set; }

    public bool CardProcessing { get; set; }

    public bool BankTransfer { get; set; }
  }
}
