using ProgrammersBlog.Entities.DTOs.ArticleDTOs;

namespace ProgrammersBlog.Mvc.Models
{
    public class ArticleSearchViewModel
    {
        public ArticleListDto ArticleListDto { get; set; }
        public string Keyword { get; set; }
    }
}
