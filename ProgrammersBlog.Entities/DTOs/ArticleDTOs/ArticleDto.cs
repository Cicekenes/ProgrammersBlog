using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs.ArticleDTOs
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}
