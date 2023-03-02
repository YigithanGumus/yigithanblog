using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Core.Entities;

namespace YigithanBlog.Entity.Entities
{
    public class Image : EntityBase
    {
        public DateTime CreatedDate;

        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; } 
        public ICollection<AppUser> Users { get; set; } 
    }
}
