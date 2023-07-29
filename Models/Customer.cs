using System.Collections.Generic;

namespace BILLING.Models;

public class Customer
{
    public int Id { get; set; }
    public string? SubscriberId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? MAC { get; set; }
    public string? IdentityNumber { get; set; }
    public float Balance { get; set; }
    public Tariff? Tarif { get; set; }
    public Address? CustomerAdress { get; set; }
    public List<Payment>? PaymentHistory { get; set; }
    public List<Complaint>? Complaints { get; set; }
}
