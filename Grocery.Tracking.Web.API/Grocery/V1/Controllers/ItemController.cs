using Grocery.Tracking.Web.API.Grocery.V1.Models;
using Grocery.Tracking.Web.API.DBContext;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Grocery.Tracking.Web.API.Grocery.V1.Controllers;

[ApiController]
[Route("api/v1/grocery/tracking/[controller]")]
public class ItemController(ILogger<ItemController> logger, BlogContext blogContext) : ControllerBase
{
    private readonly ILogger<ItemController> _logger = logger;
    private readonly BlogContext _blogContext = blogContext;

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
                FROM Grocery.Tracking.Post AS P
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
