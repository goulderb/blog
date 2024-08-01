namespace Grocery.Tracking.Web.API.Grocery.V1.Models;

public class Post
{
    public int PostID { get; set; }

    public required string Subject { get; set; }

    public required string Body { get; set; }

    public required DateTimeOffset PostedDate { get; set; }
}