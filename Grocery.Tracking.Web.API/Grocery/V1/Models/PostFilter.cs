namespace Grocery.Tracking.Web.API.Grocery.V1.Models;

public class PostFilter
{
    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTimeOffset? StartDate { get; set; }

    public DateTimeOffset? EndDate { get; set; }
}
