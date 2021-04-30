using Forum_Net.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Models
{
    public class Tag : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<PostTag> Posts { get; set; } = new HashSet<PostTag>();
    }
}
