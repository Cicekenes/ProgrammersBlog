using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs.CategoryDTOs
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
