using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Entity.DTOs.Articles;
using YigithanBlog.Entity.Entities;

namespace YigithanBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();
    }
}
