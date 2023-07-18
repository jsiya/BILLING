using System;

namespace BILLING.Models;

public class Network
{
    public string? MAC { get; set; }
    public string? IP { get; set; }
    public DateTime StartTime { get; set; }
    public TimeSpan SessionTime { get; set; }
    public float Upload { get; set; }
    public float Download { get; set; }
    public bool Action { get; set; }//bugunku gun expiredateden boyuk olsa false olur
    public DateTime ExpireDate { get; set; }//odenis vaxti
    public DateTime LastModifyDate { get; set; }//sonuncu odenis
}
