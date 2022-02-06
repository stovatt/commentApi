using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommentApi.Models;
using CommentApi.Models.RequestBodies;
using Microsoft.AspNetCore.Mvc;
using Sakur.WebApiUtilities.Models;

namespace CommentApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetComments()
        {
            List<Comment> comments = new List<Comment>();

            comments.Add(new Comment() { AuthorName = "Sarah", Content = "Hej!", Time = DateTime.Now });

            return new ApiResponse(comments);
        }

        [HttpPost("post")]
        public async Task<IActionResult> PostComments([FromBody] PostCommentBody body)
        {
            if (!body.Valid)
            {
                return new ApiResponse(body.GetInvalidBodyMessage(), System.Net.HttpStatusCode.BadRequest);
            }

            return new ApiResponse(new Comment(body));
        }
    }
}
