using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.DTOs.ArticleDTOs;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> GetAsync(int articleId);
        Task<IDataResult<ArticleListDto>> GetAllAsync();
        Task<IDataResult<ArticleListDto>> GetAllAsyncByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllAsyncByNonDeletedAndActive();
        Task<IDataResult<ArticleListDto>> GetAllAsyncByCategory(int categoryId);
        Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createdByName); //Datayı dönmeye gerek olmayan durumlarda IResult, dönülmesi gereken durumlarda IDataResult
        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int articleId, string modifiedByName); //isDeleted değerini false set etme.
        Task<IResult> HardDelete(int articleId); //Gerçek silme işlemi
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
