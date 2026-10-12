namespace IncomeTracker.Models;

public class Income(string incomeType, string provider, decimal amount, DateOnly paymentDate, Frequency frequency)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string IncomeType { get; set; } = incomeType;
    public string Provider { get; set; } = provider;
    public decimal Amount { get; set; } = amount;
    public DateOnly PaymentDate { get; set; } = paymentDate;
    public Frequency Frequency { get; set; } = frequency;
}