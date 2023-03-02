using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Core.Entities;

namespace YigithanBlog.Entity.Entities
{
    public class Category : EntityBase
    {
        public DateTime CreatedDate;

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
