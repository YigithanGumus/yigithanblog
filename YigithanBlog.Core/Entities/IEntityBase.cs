using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YigithanBlog.Core.Entities
{
    public interface IEntityBase
    {
        bool IsDeleted { get; set; }
    }
}
