using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Common
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
