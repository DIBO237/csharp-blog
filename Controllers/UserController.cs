using Microsoft.AspNetCore.Mvc;
using BlogApi.Models; // Replace with your model namespace
using BlogApi.Data;
using System.Text.Json.Serialization;
using BlogApi.Utils;

namespace BlogApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

   [HttpGet]
public IActionResult GetPost()
{
    var posts = _context.Blog.ToList(); // Retrieve all posts from the database

    return Ok(posts); // Return the array of posts
}

    [HttpPost("/postdata")]
    public IActionResult CreatePost([FromBody] Blog model)
    {
        if (model == null)
        {
            return BadRequest("Invalid data");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // You can map the ViewModel to your actual model if needed
        var post = new Blog
        {
            title = model.title,
            shortDesc = model.shortDesc,
            desc = model.desc,
            slug_id = model.slug_id
        };

        _context.Blog.Add(post);
        _context.SaveChanges();

       var success = new SuccesResponse 
       {
         Code = "200",
         Response = new { 
             userData = "hellow",
             hello = "dibya",
             postData = post
         },
         Message = "success fully creeted",
         Status = true

       };

        return Ok(success);
    }

}
