using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Entity.DTOs.Articles;
using YigithanBlog.Entity.Entities;

namespace YigithanBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto,Article>().ReverseMap();
        }
    }
}
