using Forum_Net.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Models
{
    public class UserFollower : IAuditInfo, IDeletableEntity
    {
        public string UserId { get; set; }

        public ForumUser User { get; set; }

        public string FollowerId { get; set; }

        public ForumUser Follower { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
