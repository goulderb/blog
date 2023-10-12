namespace Blog.Web.API.Blog.V1.Model;

public class PostFilter
{
    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTimeOffset? StartDate { get; set; }

    public DateTimeOffset? EndDate { get; set; }
}
