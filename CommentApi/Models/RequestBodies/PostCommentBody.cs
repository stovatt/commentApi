using System;
using Sakur.WebApiUtilities.BaseClasses;

namespace CommentApi.Models.RequestBodies
{
    public class PostCommentBody : RequestBody
    {
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime Time { get { return DateTime.Now; } }
        public int ThreadId { get; set; }

        public PostCommentBody()
        {
        }

        public override bool Valid
        {
            get { return !string.IsNullOrEmpty(AuthorName) && !string.IsNullOrEmpty(Content) && ThreadId != 0; }
        }
    }
}
