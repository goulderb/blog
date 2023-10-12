using Blog.Web.API.Blog.V1.Model;
using Blog.Web.API.DBContext;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.API.Blog.V1.Controller;

[ApiController]
[Route("api/v1/blog/[controller]")]
public class PostController : ControllerBase
{
    private readonly ILogger<PostController> _logger;
    private readonly BlogContext _blogContext;

    public PostController(ILogger<PostController> logger, BlogContext blogContext)
    {
        _logger = logger;
        _blogContext = blogContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<IEnumerable<Post>> Index([FromQuery] PostFilter filter)
    {
        using var connection = _blogContext.CreateConnection();

        var results = await connection.QueryAsync<Post>(
            @"
            SELECT
                P.Post_ID AS PostID,
                P.Post_Subject AS Subject,
                P.Post_Body AS Body,
                P.Posted_Date AS PostedDate
            FROM Blog.Post AS P
            WHERE (@Subject IS NULL OR P.Post_Subject LIKE @Subject + '%')
                AND (@Body IS NULL OR P.Post_Body LIKE @Body + '%')
                AND (@StartDate IS NULL OR P.Posted_Date >= @StartDate)
                AND (@EndDate IS NULL OR P.Posted_Date >= @EndDate);
            ",
            filter
        );

        return results;
    }
}
