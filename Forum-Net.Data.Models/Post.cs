using Forum_Net.Data.Common;
using Forum_Net.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Models
{
    public class Post : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public PostType Type { get; set; }

        public string Description { get; set; }

        public int Views { get; set; }

        public bool IsPinned { get; set; }

        public string AuthorId { get; set; }

        public ForumUser Author { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();

        public ICollection<PostTag> Tags { get; set; } = new HashSet<PostTag>();

        public ICollection<PostReaction> Reactions { get; set; } = new HashSet<PostReaction>();

        public ICollection<PostReport> Reports { get; set; } = new HashSet<PostReport>();
    }
}
