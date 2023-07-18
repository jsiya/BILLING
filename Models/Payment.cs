using System;

namespace BILLING.Models;

public class Payment
{
    public int Id { get; set; }
    public DateTime PaymentDate { get; set; }
    public float Amount { get; set; }
    public string? Terminal { get; set; }
}
