using System;
using CommentApi.Models.RequestBodies;

namespace CommentApi.Models
{
    public class Comment
    {
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int ThreadId { get; set; }

        public Comment()
        {
        }

        public Comment(PostCommentBody postCommentBody)
        {
            AuthorName = postCommentBody.AuthorName;
            Content = postCommentBody.Content;
            Time = postCommentBody.Time;
            ThreadId = postCommentBody.ThreadId;

        }
    }
}
