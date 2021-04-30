using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Common
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
