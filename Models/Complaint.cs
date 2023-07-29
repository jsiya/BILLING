using System;

namespace BILLING.Models;

public class Complaint
{
    public Guid Id { get; set; }
    public string SubscriberId { get; set; }
    public string? Content { get; set; }
    public string? Description { get; set; }
    public DateTime SentDate { get; set; }
    public bool Status { get; set; }
}
