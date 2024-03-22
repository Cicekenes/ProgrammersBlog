using ProgrammersBlog.Entities.DTOs.CategoryDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto CategoryAddDto { get; set; }
        public string CategoryUpdatePartial { get; set; } //Hata vs için. Modelin son durumu için
        public CategoryDto CategoryDto { get; set; } // Category dönüşünde elde edilecek veri
    }
}
