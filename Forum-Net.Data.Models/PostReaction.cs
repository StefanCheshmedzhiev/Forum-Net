using Forum_Net.Data.Common;
using Forum_Net.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Models
{
    public class PostReaction : IAuditInfo
    {
        public int Id { get; set; }

        public ReactionType ReactionType { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public string AuthorId { get; set; }

        public ForumUser Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
