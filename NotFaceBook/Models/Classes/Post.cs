using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotFaceBook.Models.Classes
{
    public class Post
    {
        public int postId { get; set; }
        public string postText { get; set; }
        public DateTime postDateTime { get; set; }
        public int postLike { get; set; }
    }
}