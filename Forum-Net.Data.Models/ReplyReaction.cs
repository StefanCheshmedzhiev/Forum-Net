using Forum_Net.Data.Common;
using Forum_Net.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Models
{
    public class ReplyReaction : IAuditInfo
    {
        public int Id { get; set; }

        public ReactionType ReactionType { get; set; }

        public int ReplyId { get; set; }

        public Reply Reply { get; set; }

        public string AuthorId { get; set; }

        public ForumUser Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
