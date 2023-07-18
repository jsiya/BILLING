using System;

namespace BILLING.Models;

public class Tariff
{
    public Guid Id { get; set; }
    public int Speed { get; set; }
    public float Tax { get; set; }
}
