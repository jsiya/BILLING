using System;

namespace BILLING.Models;

public class Address
{
    public Guid Id { get; set; }
    public Streets? Street { get; set; }
    public string? Apartment { get; set; }
    public string? Building { get; set; }
}
