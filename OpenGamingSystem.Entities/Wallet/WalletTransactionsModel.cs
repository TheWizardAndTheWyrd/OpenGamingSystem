using System;

namespace OpenGamingSystem.Entities.Wallet
{
  public class WalletTransactionsModel
  {
    public string TransactionId { get; set; }

    public DateTime Date { get; set; }

    public string TransactionType { get; set; }

    public string Description { get; set; }

    public string Currency { get; set; }

    public Decimal Amount { get; set; }

    public Decimal BalanceBefore { get; set; }

    public Decimal BalanceAfter { get; set; }

    public int StatusId { get; set; }

    public string Status { get; set; }

    public bool AllowWithdrawReversal { get; set; }

    public int WithdrawReversalTimeoutMinutes { get; set; }

    public string PaymentTranId { get; set; }

    public int TransactionTypeId { get; set; }
  }
}
