using ProgrammersBlog.Entities.DTOs.ArticleDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int ArticlesCount { get; set; }
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
        public ArticleListDto Articles { get; set; }
    }
}
