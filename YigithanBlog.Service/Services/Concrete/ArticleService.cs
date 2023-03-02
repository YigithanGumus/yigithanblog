using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Data.UnitOfWorks;
using YigithanBlog.Entity.DTOs.Articles;
using YigithanBlog.Entity.Entities;
using YigithanBlog.Service.Services.Abstractions;

namespace YigithanBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper Mapper)
        {
            this.unitOfWork = unitOfWork;
            mapper = Mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesAsync()
        {
            var articles= await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);


            return map;
        }
    }
}
